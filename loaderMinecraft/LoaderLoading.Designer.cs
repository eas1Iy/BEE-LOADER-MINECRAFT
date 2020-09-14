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
            Guna.UI.Animation.Animation animation3 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoaderLoading));
            this._animate = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this._elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this._drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._animateOff = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this._shadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.update = new System.Windows.Forms.Label();
            this.gunaVSeparator1 = new Guna.UI.WinForms.GunaVSeparator();
            this._anim = new Guna.UI.WinForms.GunaTransition(this.components);
            this._updateLoading = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this._drag2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this._drag3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
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
            this._anim.SetDecoration(this.pictureBox1, Guna.UI.Animation.DecorationType.None);
            this.pictureBox1.Image = global::BEE.Properties.Resources.tenor;
            this.pictureBox1.Location = new System.Drawing.Point(12, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // _animateOff
            // 
            this._animateOff.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this._animateOff.Interval = 30;
            // 
            // update
            // 
            this._anim.SetDecoration(this.update, Guna.UI.Animation.DecorationType.None);
            this.update.Font = new System.Drawing.Font("Malgun Gothic", 10F);
            this.update.Location = new System.Drawing.Point(249, 9);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(270, 236);
            this.update.TabIndex = 1;
            this.update.Text = "update";
            this.update.Visible = false;
            // 
            // gunaVSeparator1
            // 
            this.gunaVSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._anim.SetDecoration(this.gunaVSeparator1, Guna.UI.Animation.DecorationType.None);
            this.gunaVSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this.gunaVSeparator1.Location = new System.Drawing.Point(233, 33);
            this.gunaVSeparator1.Name = "gunaVSeparator1";
            this.gunaVSeparator1.Size = new System.Drawing.Size(10, 200);
            this.gunaVSeparator1.TabIndex = 2;
            // 
            // _anim
            // 
            this._anim.AnimationType = Guna.UI.Animation.AnimationType.Transparent;
            this._anim.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 1F;
            this._anim.DefaultAnimation = animation3;
            // 
            // _updateLoading
            // 
            this._updateLoading.AnimationSpeed = 80;
            this._updateLoading.AutoStart = true;
            this._updateLoading.CircleSize = 1F;
            this._anim.SetDecoration(this._updateLoading, Guna.UI.Animation.DecorationType.None);
            this._updateLoading.Location = new System.Drawing.Point(350, 86);
            this._updateLoading.Name = "_updateLoading";
            this._updateLoading.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this._updateLoading.Size = new System.Drawing.Size(75, 75);
            this._updateLoading.TabIndex = 3;
            // 
            // _drag2
            // 
            this._drag2.TargetControl = this.update;
            // 
            // _drag3
            // 
            this._drag3.TargetControl = this.pictureBox1;
            // 
            // LoaderLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(533, 254);
            this.Controls.Add(this._updateLoading);
            this.Controls.Add(this.update);
            this.Controls.Add(this.gunaVSeparator1);
            this.Controls.Add(this.pictureBox1);
            this._anim.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoaderLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СП405 - Загрузка программы..";
            this.Load += new System.EventHandler(this.LoaderLoading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow _animate;
        private Guna.UI2.WinForms.Guna2Elipse _elipse;
        private Guna.UI2.WinForms.Guna2DragControl _drag;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2AnimateWindow _animateOff;
        private Guna.UI2.WinForms.Guna2ShadowForm _shadow;
        private System.Windows.Forms.Label update;
        private Guna.UI.WinForms.GunaVSeparator gunaVSeparator1;
        private Guna.UI.WinForms.GunaTransition _anim;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator _updateLoading;
        private Guna.UI2.WinForms.Guna2DragControl _drag2;
        private Guna.UI2.WinForms.Guna2DragControl _drag3;
    }
}