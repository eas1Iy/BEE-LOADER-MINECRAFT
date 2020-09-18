namespace loaderMinecraft
{
    partial class dowloand
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation4 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dowloand));
            this._labelLoading = new System.Windows.Forms.Label();
            this._dragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this._updateLoading = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this.updateDowloand = new System.Windows.Forms.Label();
            this._dragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this._loadingMods = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this._ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this._toolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.gunaVSeparator1 = new Guna.UI.WinForms.GunaVSeparator();
            this._anim = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this._dragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _labelLoading
            // 
            this._labelLoading.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._anim.SetDecoration(this._labelLoading, Guna.UI2.AnimatorNS.DecorationType.None);
            this._labelLoading.Font = new System.Drawing.Font("Malgun Gothic", 15F);
            this._labelLoading.ForeColor = System.Drawing.SystemColors.ControlText;
            this._labelLoading.Location = new System.Drawing.Point(12, 141);
            this._labelLoading.Name = "_labelLoading";
            this._labelLoading.Size = new System.Drawing.Size(189, 29);
            this._labelLoading.TabIndex = 1;
            this._labelLoading.Text = "Загрузка модов....";
            this._labelLoading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this._toolTip.SetToolTip(this._labelLoading, "<b>Происходит загрузка модов, пожалуйста подождите!</b>");
            this._labelLoading.Visible = false;
            // 
            // _dragControl2
            // 
            this._dragControl2.TargetControl = this.guna2CustomGradientPanel2;
            this._dragControl2.UseTransparentDrag = true;
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Controls.Add(this.panel1);
            this._anim.SetDecoration(this.guna2CustomGradientPanel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(3, 3);
            this.guna2CustomGradientPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.ShadowDecoration.Parent = this.guna2CustomGradientPanel2;
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(630, 173);
            this.guna2CustomGradientPanel2.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._updateLoading);
            this.panel1.Controls.Add(this.updateDowloand);
            this._anim.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(226, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 155);
            this.panel1.TabIndex = 5;
            // 
            // _updateLoading
            // 
            this._updateLoading.AnimationSpeed = 80;
            this._updateLoading.AutoStart = true;
            this._updateLoading.CircleSize = 1F;
            this._anim.SetDecoration(this._updateLoading, Guna.UI2.AnimatorNS.DecorationType.None);
            this._updateLoading.Location = new System.Drawing.Point(165, 37);
            this._updateLoading.Name = "_updateLoading";
            this._updateLoading.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this._updateLoading.Size = new System.Drawing.Size(75, 75);
            this._updateLoading.TabIndex = 4;
            // 
            // updateDowloand
            // 
            this.updateDowloand.AutoEllipsis = true;
            this._anim.SetDecoration(this.updateDowloand, Guna.UI2.AnimatorNS.DecorationType.None);
            this.updateDowloand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateDowloand.Font = new System.Drawing.Font("Malgun Gothic", 10F);
            this.updateDowloand.ForeColor = System.Drawing.SystemColors.ControlText;
            this.updateDowloand.Location = new System.Drawing.Point(0, 0);
            this.updateDowloand.Name = "updateDowloand";
            this.updateDowloand.Size = new System.Drawing.Size(395, 155);
            this.updateDowloand.TabIndex = 3;
            this.updateDowloand.Text = "update";
            this.updateDowloand.Visible = false;
            // 
            // _dragControl1
            // 
            this._dragControl1.TargetControl = this._labelLoading;
            this._dragControl1.UseTransparentDrag = true;
            // 
            // _loadingMods
            // 
            this._loadingMods.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this._loadingMods.AnimationSpeed = 80;
            this._loadingMods.AutoStart = true;
            this._loadingMods.CircleSize = 5F;
            this._anim.SetDecoration(this._loadingMods, Guna.UI2.AnimatorNS.DecorationType.None);
            this._loadingMods.Location = new System.Drawing.Point(43, 15);
            this._loadingMods.Name = "_loadingMods";
            this._loadingMods.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this._loadingMods.Size = new System.Drawing.Size(123, 123);
            this._loadingMods.TabIndex = 2;
            this._loadingMods.Visible = false;
            // 
            // _toolTip
            // 
            this._toolTip.AllowLinksHandling = true;
            this._toolTip.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this._toolTip.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this._toolTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this._toolTip.MaximumSize = new System.Drawing.Size(0, 0);
            this._toolTip.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this._toolTip.UseGdiPlusTextRendering = true;
            // 
            // gunaVSeparator1
            // 
            this.gunaVSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._anim.SetDecoration(this.gunaVSeparator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gunaVSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this.gunaVSeparator1.Location = new System.Drawing.Point(213, 12);
            this.gunaVSeparator1.Name = "gunaVSeparator1";
            this.gunaVSeparator1.Size = new System.Drawing.Size(10, 152);
            this.gunaVSeparator1.TabIndex = 4;
            this.gunaVSeparator1.Visible = false;
            // 
            // _anim
            // 
            this._anim.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this._anim.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 1F;
            this._anim.DefaultAnimation = animation4;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2CustomGradientPanel2);
            this._anim.SetDecoration(this.guna2CustomGradientPanel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(168)))), ((int)(((byte)(50)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(168)))), ((int)(((byte)(50)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(636, 179);
            this.guna2CustomGradientPanel1.TabIndex = 20;
            // 
            // _dragControl3
            // 
            this._dragControl3.TargetControl = this._loadingMods;
            this._dragControl3.UseTransparentDrag = true;
            // 
            // dowloand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(636, 179);
            this.Controls.Add(this.gunaVSeparator1);
            this.Controls.Add(this._loadingMods);
            this.Controls.Add(this._labelLoading);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this._anim.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dowloand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BEE - Обновление...";
            this.Load += new System.EventHandler(this.dowloand_Load);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _labelLoading;
        private Guna.UI2.WinForms.Guna2DragControl _dragControl2;
        private Guna.UI2.WinForms.Guna2DragControl _dragControl1;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator _loadingMods;
        private Guna.UI2.WinForms.Guna2ShadowForm _ShadowForm;
        private Guna.UI2.WinForms.Guna2HtmlToolTip _toolTip;
        private Guna.UI.WinForms.GunaVSeparator gunaVSeparator1;
        private Guna.UI2.WinForms.Guna2Transition _anim;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator _updateLoading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label updateDowloand;
        private Guna.UI2.WinForms.Guna2DragControl _dragControl3;
    }
}

