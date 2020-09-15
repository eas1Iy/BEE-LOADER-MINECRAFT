﻿namespace loaderMinecraft
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
            Guna.UI.Animation.Animation animation6 = new Guna.UI.Animation.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoaderLoading));
            this._animate = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this._drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.update = new System.Windows.Forms.Label();
            this.gunaVSeparator1 = new Guna.UI.WinForms.GunaVSeparator();
            this._anim = new Guna.UI.WinForms.GunaTransition(this.components);
            this._updateLoading = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this._drag2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this._drag3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _animate
            // 
            this._animate.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            // 
            // _drag
            // 
            this._drag.TargetControl = this.guna2CustomGradientPanel2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this._anim.SetDecoration(this.pictureBox1, Guna.UI.Animation.DecorationType.None);
            this.pictureBox1.Image = global::BEE.Properties.Resources.bee_animator;
            this.pictureBox1.Location = new System.Drawing.Point(12, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // update
            // 
            this._anim.SetDecoration(this.update, Guna.UI.Animation.DecorationType.None);
            this.update.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
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
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(0);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 1F;
            this._anim.DefaultAnimation = animation6;
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
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2CustomGradientPanel2);
            this._anim.SetDecoration(this.guna2CustomGradientPanel1, Guna.UI.Animation.DecorationType.None);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(168)))), ((int)(((byte)(50)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(168)))), ((int)(((byte)(50)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(533, 254);
            this.guna2CustomGradientPanel1.TabIndex = 20;
            // 
            // guna2CustomGradientPanel2
            // 
            this._anim.SetDecoration(this.guna2CustomGradientPanel2, Guna.UI.Animation.DecorationType.None);
            this.guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(3, 3);
            this.guna2CustomGradientPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.ShadowDecoration.Parent = this.guna2CustomGradientPanel2;
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(527, 248);
            this.guna2CustomGradientPanel2.TabIndex = 20;
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
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this._anim.SetDecoration(this, Guna.UI.Animation.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoaderLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BEE - Загрузка программы..";
            this.Load += new System.EventHandler(this.LoaderLoading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow _animate;
        private Guna.UI2.WinForms.Guna2DragControl _drag;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label update;
        private Guna.UI.WinForms.GunaVSeparator gunaVSeparator1;
        private Guna.UI.WinForms.GunaTransition _anim;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator _updateLoading;
        private Guna.UI2.WinForms.Guna2DragControl _drag2;
        private Guna.UI2.WinForms.Guna2DragControl _drag3;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
    }
}