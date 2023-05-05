namespace SurtiPro
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblforget = new System.Windows.Forms.Label();
            this.lblreg = new System.Windows.Forms.Label();
            this.btnlogin = new SurtiPro.Botones();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.circularPictureBox1 = new SurtiPro.CircularPictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnminimizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.Button();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelContainer.Controls.Add(this.pictureBox1);
            this.panelContainer.Controls.Add(this.lblforget);
            this.panelContainer.Controls.Add(this.lblreg);
            this.panelContainer.Controls.Add(this.btnlogin);
            this.panelContainer.Controls.Add(this.label3);
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.circularPictureBox1);
            this.panelContainer.Controls.Add(this.panelTitleBar);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(852, 487);
            this.panelContainer.TabIndex = 0;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(245, 323);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblforget
            // 
            this.lblforget.AutoSize = true;
            this.lblforget.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblforget.ForeColor = System.Drawing.Color.DimGray;
            this.lblforget.Location = new System.Drawing.Point(347, 432);
            this.lblforget.Name = "lblforget";
            this.lblforget.Size = new System.Drawing.Size(129, 19);
            this.lblforget.TabIndex = 6;
            this.lblforget.Text = "Olvidé mi clave";
            this.lblforget.Click += new System.EventHandler(this.lblforget_Click);
            this.lblforget.MouseEnter += new System.EventHandler(this.lblforget_MouseEnter);
            this.lblforget.MouseLeave += new System.EventHandler(this.lblforget_MouseLeave);
            // 
            // lblreg
            // 
            this.lblreg.AutoSize = true;
            this.lblreg.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreg.ForeColor = System.Drawing.Color.DimGray;
            this.lblreg.Location = new System.Drawing.Point(361, 393);
            this.lblreg.Name = "lblreg";
            this.lblreg.Size = new System.Drawing.Size(104, 19);
            this.lblreg.TabIndex = 5;
            this.lblreg.Text = "Registrarse";
            this.lblreg.Click += new System.EventHandler(this.lblreg_Click);
            this.lblreg.MouseEnter += new System.EventHandler(this.lblreg_MouseEnter);
            this.lblreg.MouseLeave += new System.EventHandler(this.lblreg_MouseLeave);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnlogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnlogin.BorderRadius = 20;
            this.btnlogin.BorderSize = 0;
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(303, 323);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(233, 51);
            this.btnlogin.TabIndex = 4;
            this.btnlogin.Text = "Iniciar sesión";
            this.btnlogin.TextColor = System.Drawing.Color.White;
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(140, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Clave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(140, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.circularPictureBox1.BorderColor = System.Drawing.Color.Teal;
            this.circularPictureBox1.BorderColor2 = System.Drawing.Color.Aquamarine;
            this.circularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.circularPictureBox1.BorderSize = 6;
            this.circularPictureBox1.GradientAngle = 50F;
            this.circularPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("circularPictureBox1.Image")));
            this.circularPictureBox1.Location = new System.Drawing.Point(550, 134);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(222, 222);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPictureBox1.TabIndex = 1;
            this.circularPictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelTitleBar.Controls.Add(this.btnminimizar);
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Controls.Add(this.btncerrar);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(852, 50);
            this.panelTitleBar.TabIndex = 0;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnminimizar
            // 
            this.btnminimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnminimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnminimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminimizar.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnminimizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnminimizar.Location = new System.Drawing.Point(751, 0);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(52, 50);
            this.btnminimizar.TabIndex = 2;
            this.btnminimizar.Text = "-";
            this.btnminimizar.UseVisualStyleBackColor = false;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(266, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "SurtiPro Administración";
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btncerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncerrar.Location = new System.Drawing.Point(803, 0);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(49, 50);
            this.btncerrar.TabIndex = 1;
            this.btncerrar.Text = "X";
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            this.btncerrar.MouseEnter += new System.EventHandler(this.btncerrar_MouseEnter);
            this.btncerrar.MouseLeave += new System.EventHandler(this.btncerrar_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(852, 487);
            this.Controls.Add(this.panelContainer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown_1);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelTitleBar;
        private CircularPictureBox circularPictureBox1;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnminimizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Botones btnlogin;
        private System.Windows.Forms.Label lblforget;
        private System.Windows.Forms.Label lblreg;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

