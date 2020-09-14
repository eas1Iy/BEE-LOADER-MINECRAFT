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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dowloand));
            this.label1 = new System.Windows.Forms.Label();
            this._elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this._dragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this._dragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2WinProgressIndicator1 = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this._ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this._toolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 17F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this.label1.Location = new System.Drawing.Point(12, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Загрузка модов....";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this._toolTip.SetToolTip(this.label1, "<b>Происходит загрузка модов, пожалуйста подождите!</b>");
            // 
            // _elipse
            // 
            this._elipse.BorderRadius = 15;
            this._elipse.TargetControl = this;
            // 
            // _dragControl2
            // 
            this._dragControl2.TargetControl = this;
            this._dragControl2.UseTransparentDrag = true;
            // 
            // _dragControl1
            // 
            this._dragControl1.TargetControl = this.label1;
            this._dragControl1.UseTransparentDrag = true;
            // 
            // guna2WinProgressIndicator1
            // 
            this.guna2WinProgressIndicator1.AnimationSpeed = 80;
            this.guna2WinProgressIndicator1.AutoStart = true;
            this.guna2WinProgressIndicator1.CircleSize = 5F;
            this.guna2WinProgressIndicator1.Location = new System.Drawing.Point(226, 29);
            this.guna2WinProgressIndicator1.Name = "guna2WinProgressIndicator1";
            this.guna2WinProgressIndicator1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this.guna2WinProgressIndicator1.Size = new System.Drawing.Size(154, 154);
            this.guna2WinProgressIndicator1.TabIndex = 2;
            // 
            // _toolTip
            // 
            this._toolTip.AllowLinksHandling = true;
            this._toolTip.Font = new System.Drawing.Font("Malgun Gothic", 14F, System.Drawing.FontStyle.Bold);
            this._toolTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this._toolTip.MaximumSize = new System.Drawing.Size(0, 0);
            this._toolTip.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            // 
            // dowloand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(602, 258);
            this.Controls.Add(this.guna2WinProgressIndicator1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dowloand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СП405 - Обновление...";
            this.Load += new System.EventHandler(this.dowloand_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse _elipse;
        private Guna.UI2.WinForms.Guna2DragControl _dragControl2;
        private Guna.UI2.WinForms.Guna2DragControl _dragControl1;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator guna2WinProgressIndicator1;
        private Guna.UI2.WinForms.Guna2ShadowForm _ShadowForm;
        private Guna.UI2.WinForms.Guna2HtmlToolTip _toolTip;
    }
}

