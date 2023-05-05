namespace SurtiPro
{
    partial class Formsgbox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formsgbox));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botones1 = new SurtiPro.Botones();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btncerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelContainer.Controls.Add(this.label4);
            this.panelContainer.Controls.Add(this.label3);
            this.panelContainer.Controls.Add(this.label2);
            this.panelContainer.Controls.Add(this.label1);
            this.panelContainer.Controls.Add(this.pictureBox1);
            this.panelContainer.Controls.Add(this.botones1);
            this.panelContainer.Controls.Add(this.panelTitleBar);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(520, 307);
            this.panelContainer.TabIndex = 0;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // botones1
            // 
            this.botones1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.botones1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.botones1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.botones1.BorderRadius = 20;
            this.botones1.BorderSize = 0;
            this.botones1.FlatAppearance.BorderSize = 0;
            this.botones1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botones1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botones1.ForeColor = System.Drawing.Color.White;
            this.botones1.Location = new System.Drawing.Point(188, 223);
            this.botones1.Name = "botones1";
            this.botones1.Size = new System.Drawing.Size(150, 45);
            this.botones1.TabIndex = 1;
            this.botones1.Text = "Aceptar";
            this.botones1.TextColor = System.Drawing.Color.White;
            this.botones1.UseVisualStyleBackColor = false;
            this.botones1.Click += new System.EventHandler(this.botones1_Click);
            this.botones1.MouseEnter += new System.EventHandler(this.botones1_MouseEnter);
            this.botones1.MouseLeave += new System.EventHandler(this.botones1_MouseLeave);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelTitleBar.Controls.Add(this.btncerrar);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(520, 40);
            this.panelTitleBar.TabIndex = 0;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btncerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncerrar.Location = new System.Drawing.Point(469, 0);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(51, 40);
            this.btncerrar.TabIndex = 0;
            this.btncerrar.Text = "X";
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            this.btncerrar.MouseEnter += new System.EventHandler(this.btncerrar_MouseEnter);
            this.btncerrar.MouseLeave += new System.EventHandler(this.btncerrar_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(123, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "En este caso, debes contactarte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(123, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "con el soporte del sistema.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(123, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Llame al: +573154030044";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(123, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "ó al +573146538898.";
            // 
            // Formsgbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 307);
            this.Controls.Add(this.panelContainer);
            this.Name = "Formsgbox";
            this.Text = "Formsgbox";
            this.Activated += new System.EventHandler(this.Formsgbox_Activated);
            this.Load += new System.EventHandler(this.Formsgbox_Load);
            this.ResizeEnd += new System.EventHandler(this.Formsgbox_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.Formsgbox_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Formsgbox_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Formsgbox_MouseDown);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelTitleBar;
        private Botones botones1;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}