namespace loaderMinecraft
{
    partial class LoaderLoading
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
            this.components = new System.ComponentModel.Container();
            this._animate = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this._elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this._drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this._shadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._animateOff = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // _elipse
            // 
            this._elipse.BorderRadius = 15;
            this._elipse.TargetControl = this;
            // 
            // _drag
            // 
            this._drag.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pictureBox1.Image = global::loaderMinecraft.Properties.Resources.tenor;
            this.pictureBox1.Location = new System.Drawing.Point(142, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // _animateOff
            // 
            this._animateOff.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this._animateOff.Interval = 30;
            // 
            // LoaderLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(531, 259);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoaderLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoaderLoading";
            this.Load += new System.EventHandler(this.LoaderLoading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow _animate;
        private Guna.UI2.WinForms.Guna2Elipse _elipse;
        private Guna.UI2.WinForms.Guna2DragControl _drag;
        private Guna.UI2.WinForms.Guna2ShadowForm _shadow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2AnimateWindow _animateOff;
    }
}