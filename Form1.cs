using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurtiPro
{
    public partial class Form1 : Form
    {
        private int borderRadius = 20;
        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(0, 192, 192);
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.panelTitleBar.BackColor = borderColor;
            this.BackColor = borderColor;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000;
                return cp;
            }
        }

        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1) 
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);
                        
                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);
                        
                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }
        private void ControlRegionAndBorder(Control control, float radius, Graphics graph, Color borderColor)
        {
            using (GraphicsPath roundPath = GetRoundedPath(control.ClientRectangle, radius))
            using (Pen penBorder = new Pen(borderColor, 1))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                control.Region = new Region(roundPath);
                graph.DrawPath(penBorder, roundPath);
            }
        }

        private void DrawPath(Rectangle rect, Graphics graph, Color color)
        {
            using (GraphicsPath roundPath=GetRoundedPath(rect,borderRadius))
                using(Pen penBorder = new Pen(color, 3))
            {
                graph.DrawPath(penBorder, roundPath);
            }
        }

        private struct FormBoundsColors
        {
            public Color TopLeftColor;
            public Color TopRightColor;
            public Color BottomLeftColor;
            public Color BottomRightColor;
        }
        private FormBoundsColors GetFormBoundsColors()
        {
            var fbColor = new FormBoundsColors();
            using (var bmp = new Bitmap(1, 1))
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                Rectangle rectBmp = new Rectangle(0, 0, 1, 1);
                
                rectBmp.X = this.Bounds.X - 1;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopLeftColor = bmp.GetPixel(0, 0);
                
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopRightColor = bmp.GetPixel(0, 0);
                
                rectBmp.X = this.Bounds.X;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomLeftColor = bmp.GetPixel(0, 0);
                
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomRightColor = bmp.GetPixel(0, 0);
            }
            return fbColor;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            e.Graphics.SmoothingMode= SmoothingMode.AntiAlias;
            Rectangle rectform = this.ClientRectangle;
            int nWidth = rectform.Width / 2;
            int nHeight = rectform.Height / 2;
            var fbColors =GetFormBoundsColors();

            DrawPath(rectform, e.Graphics, fbColors.TopLeftColor);

            Rectangle rectTopRight = new Rectangle(nWidth, rectform.Y, nWidth, nHeight);
            DrawPath(rectTopRight, e.Graphics, fbColors.TopRightColor);

            Rectangle rectBottomLeft = new Rectangle(rectform.X, rectform.X + nHeight, nWidth, nHeight);
            DrawPath(rectBottomLeft, e.Graphics, fbColors.BottomLeftColor);

            Rectangle rectBottomRight = new Rectangle(nWidth, rectform.Y + nHeight, nWidth, nHeight);
            DrawPath(rectBottomRight, e.Graphics, fbColors.BottomRightColor);
        }
       
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            FormRegionAndBorder(this,borderRadius,e.Graphics,borderColor,borderSize);
        }
        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            ControlRegionAndBorder(panelContainer,borderRadius-(borderSize/2), e.Graphics, borderColor);
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btncerrar.FlatStyle = FlatStyle.Flat;
            btncerrar.FlatAppearance.BorderSize = 0;

            btnminimizar.FlatStyle = FlatStyle.Flat;
            btnminimizar.FlatAppearance.BorderSize = 0;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncerrar_MouseEnter(object sender, EventArgs e)
        {
            this.btncerrar.BackColor = Color.Red;
        }

        private void btncerrar_MouseLeave(object sender, EventArgs e)
        {
            this.btncerrar.BackColor = Color.FromArgb(0, 192, 192);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

        }

        private void lblreg_MouseEnter(object sender, EventArgs e)
        {
            this.lblreg.BackColor = Color.FromArgb(0, 192, 192);
        }

        private void lblforget_MouseEnter(object sender, EventArgs e)
        {
            this.lblforget.BackColor = Color.FromArgb(0, 192, 192);
        }

        private void lblreg_MouseLeave(object sender, EventArgs e)
        {
            this.lblreg.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void lblforget_MouseLeave(object sender, EventArgs e)
        {
            this.lblforget.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void lblreg_Click(object sender, EventArgs e)
        {
            Form siguienteFormulario = new Formsgbox();
            siguienteFormulario.Show();
        }

        private void lblforget_Click(object sender, EventArgs e)
        {
            Form siguienteFormulario = new Formsgbox();
            siguienteFormulario.Show();
        }
    }
}