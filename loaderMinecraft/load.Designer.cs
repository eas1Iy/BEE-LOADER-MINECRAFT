namespace loaderMinecraft
{
    partial class load
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(load));
            this.label1 = new System.Windows.Forms.Label();
            this._ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.playButt = new Guna.UI2.WinForms.Guna2Button();
            this.changeExe = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.changeMods = new Guna.UI2.WinForms.Guna2Button();
            this.fixButt = new Guna.UI2.WinForms.Guna2Button();
            this.delButt = new Guna.UI2.WinForms.Guna2Button();
            this._ResizeForm = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.guna2ResizeBox1 = new Guna.UI2.WinForms.Guna2ResizeBox();
            this._dragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this._dragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this._elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pathMods = new Guna.UI2.WinForms.Guna2TextBox();
            this.pathMinecraft = new Guna.UI2.WinForms.Guna2TextBox();
            this._animate = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this._helpButt = new Guna.UI2.WinForms.Guna2Button();
            this._logoGif = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this._logoGif)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать в загрузчик модов!";
            // 
            // playButt
            // 
            this.playButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.playButt.Animated = true;
            this.playButt.BorderRadius = 8;
            this.playButt.CheckedState.Parent = this.playButt;
            this.playButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButt.CustomImages.Parent = this.playButt;
            this.playButt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this.playButt.Font = new System.Drawing.Font("Bahnschrift Condensed", 20F);
            this.playButt.ForeColor = System.Drawing.Color.White;
            this.playButt.HoverState.Parent = this.playButt;
            this.playButt.Location = new System.Drawing.Point(9, 195);
            this.playButt.Name = "playButt";
            this.playButt.ShadowDecoration.Parent = this.playButt;
            this.playButt.Size = new System.Drawing.Size(190, 52);
            this.playButt.TabIndex = 1;
            this.playButt.Text = "Играть";
            this.playButt.Click += new System.EventHandler(this.playButt_Click);
            // 
            // changeExe
            // 
            this.changeExe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeExe.Animated = true;
            this.changeExe.BorderRadius = 8;
            this.changeExe.CheckedState.Parent = this.changeExe;
            this.changeExe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeExe.CustomImages.Parent = this.changeExe;
            this.changeExe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this.changeExe.Font = new System.Drawing.Font("Bahnschrift Condensed", 13F);
            this.changeExe.ForeColor = System.Drawing.Color.White;
            this.changeExe.HoverState.Parent = this.changeExe;
            this.changeExe.Location = new System.Drawing.Point(452, 62);
            this.changeExe.Name = "changeExe";
            this.changeExe.ShadowDecoration.Parent = this.changeExe;
            this.changeExe.Size = new System.Drawing.Size(76, 24);
            this.changeExe.TabIndex = 2;
            this.changeExe.Text = "Выбрать";
            this.changeExe.Click += new System.EventHandler(this.changeExe_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Путь к майнкрафту:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(32, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Папка с модами:";
            // 
            // changeMods
            // 
            this.changeMods.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeMods.Animated = true;
            this.changeMods.BorderRadius = 8;
            this.changeMods.CheckedState.Parent = this.changeMods;
            this.changeMods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeMods.CustomImages.Parent = this.changeMods;
            this.changeMods.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this.changeMods.Font = new System.Drawing.Font("Bahnschrift Condensed", 13F);
            this.changeMods.ForeColor = System.Drawing.Color.White;
            this.changeMods.HoverState.Parent = this.changeMods;
            this.changeMods.Location = new System.Drawing.Point(452, 107);
            this.changeMods.Name = "changeMods";
            this.changeMods.ShadowDecoration.Parent = this.changeMods;
            this.changeMods.Size = new System.Drawing.Size(76, 24);
            this.changeMods.TabIndex = 6;
            this.changeMods.Text = "Выбрать";
            this.changeMods.Click += new System.EventHandler(this.changeMods_Click);
            // 
            // fixButt
            // 
            this.fixButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fixButt.Animated = true;
            this.fixButt.BorderRadius = 8;
            this.fixButt.CheckedState.Parent = this.fixButt;
            this.fixButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fixButt.CustomImages.Parent = this.fixButt;
            this.fixButt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this.fixButt.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.fixButt.ForeColor = System.Drawing.Color.White;
            this.fixButt.HoverState.Parent = this.fixButt;
            this.fixButt.Location = new System.Drawing.Point(205, 224);
            this.fixButt.Name = "fixButt";
            this.fixButt.ShadowDecoration.Parent = this.fixButt;
            this.fixButt.Size = new System.Drawing.Size(112, 23);
            this.fixButt.TabIndex = 8;
            this.fixButt.Text = "Проверить моды";
            this.fixButt.Click += new System.EventHandler(this.fixButt_Click);
            // 
            // delButt
            // 
            this.delButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.delButt.Animated = true;
            this.delButt.BorderRadius = 8;
            this.delButt.CheckedState.Parent = this.delButt;
            this.delButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delButt.CustomImages.Parent = this.delButt;
            this.delButt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this.delButt.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.delButt.ForeColor = System.Drawing.Color.White;
            this.delButt.HoverState.Parent = this.delButt;
            this.delButt.Location = new System.Drawing.Point(205, 195);
            this.delButt.Name = "delButt";
            this.delButt.ShadowDecoration.Parent = this.delButt;
            this.delButt.Size = new System.Drawing.Size(112, 23);
            this.delButt.TabIndex = 9;
            this.delButt.Text = "Удалить моды";
            this.delButt.Click += new System.EventHandler(this.delButt_Click);
            // 
            // guna2ResizeBox1
            // 
            this.guna2ResizeBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ResizeBox1.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.guna2ResizeBox1.ForeColor = System.Drawing.Color.Empty;
            this.guna2ResizeBox1.Location = new System.Drawing.Point(508, 237);
            this.guna2ResizeBox1.Name = "guna2ResizeBox1";
            this.guna2ResizeBox1.Size = new System.Drawing.Size(20, 20);
            this.guna2ResizeBox1.TabIndex = 10;
            this.guna2ResizeBox1.TargetControl = this;
            // 
            // _dragControl1
            // 
            this._dragControl1.TargetControl = this;
            this._dragControl1.UseTransparentDrag = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(498, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(30, 19);
            this.guna2ControlBox1.TabIndex = 11;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(462, 2);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(30, 19);
            this.guna2ControlBox2.TabIndex = 12;
            // 
            // _dragControl2
            // 
            this._dragControl2.TargetControl = this.label1;
            this._dragControl2.UseTransparentDrag = true;
            // 
            // _elipse
            // 
            this._elipse.TargetControl = this;
            // 
            // pathMods
            // 
            this.pathMods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathMods.BackColor = System.Drawing.Color.White;
            this.pathMods.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.pathMods.BorderRadius = 8;
            this.pathMods.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pathMods.DefaultText = "";
            this.pathMods.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pathMods.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pathMods.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pathMods.DisabledState.Parent = this.pathMods;
            this.pathMods.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pathMods.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this.pathMods.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.pathMods.FocusedState.Parent = this.pathMods;
            this.pathMods.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F);
            this.pathMods.ForeColor = System.Drawing.Color.White;
            this.pathMods.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.pathMods.HoverState.Parent = this.pathMods;
            this.pathMods.Location = new System.Drawing.Point(156, 107);
            this.pathMods.Margin = new System.Windows.Forms.Padding(5, 11, 5, 11);
            this.pathMods.Name = "pathMods";
            this.pathMods.PasswordChar = '\0';
            this.pathMods.PlaceholderForeColor = System.Drawing.Color.White;
            this.pathMods.PlaceholderText = "";
            this.pathMods.SelectedText = "";
            this.pathMods.ShadowDecoration.Parent = this.pathMods;
            this.pathMods.Size = new System.Drawing.Size(288, 24);
            this.pathMods.TabIndex = 13;
            // 
            // pathMinecraft
            // 
            this.pathMinecraft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathMinecraft.Animated = true;
            this.pathMinecraft.AutoRoundedCorners = true;
            this.pathMinecraft.BackColor = System.Drawing.Color.White;
            this.pathMinecraft.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.pathMinecraft.BorderRadius = 8;
            this.pathMinecraft.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pathMinecraft.DefaultText = "";
            this.pathMinecraft.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pathMinecraft.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pathMinecraft.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pathMinecraft.DisabledState.Parent = this.pathMinecraft;
            this.pathMinecraft.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pathMinecraft.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this.pathMinecraft.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.pathMinecraft.FocusedState.Parent = this.pathMinecraft;
            this.pathMinecraft.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F);
            this.pathMinecraft.ForeColor = System.Drawing.Color.White;
            this.pathMinecraft.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.pathMinecraft.HoverState.Parent = this.pathMinecraft;
            this.pathMinecraft.Location = new System.Drawing.Point(157, 62);
            this.pathMinecraft.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pathMinecraft.Name = "pathMinecraft";
            this.pathMinecraft.PasswordChar = '\0';
            this.pathMinecraft.PlaceholderForeColor = System.Drawing.Color.White;
            this.pathMinecraft.PlaceholderText = "";
            this.pathMinecraft.SelectedText = "";
            this.pathMinecraft.ShadowDecoration.Parent = this.pathMinecraft;
            this.pathMinecraft.Size = new System.Drawing.Size(288, 24);
            this.pathMinecraft.TabIndex = 14;
            // 
            // _animate
            // 
            this._animate.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            // 
            // _helpButt
            // 
            this._helpButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._helpButt.Animated = true;
            this._helpButt.BorderRadius = 8;
            this._helpButt.CheckedState.Parent = this._helpButt;
            this._helpButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this._helpButt.CustomImages.Parent = this._helpButt;
            this._helpButt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this._helpButt.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this._helpButt.ForeColor = System.Drawing.Color.White;
            this._helpButt.HoverState.Parent = this._helpButt;
            this._helpButt.Location = new System.Drawing.Point(323, 224);
            this._helpButt.Name = "_helpButt";
            this._helpButt.ShadowDecoration.Parent = this._helpButt;
            this._helpButt.Size = new System.Drawing.Size(70, 23);
            this._helpButt.TabIndex = 15;
            this._helpButt.Text = "Помощь";
            this._helpButt.Click += new System.EventHandler(this._helpButt_Click);
            // 
            // _logoGif
            // 
            this._logoGif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._logoGif.Image = global::loaderMinecraft.Properties.Resources.tenor;
            this._logoGif.Location = new System.Drawing.Point(399, 197);
            this._logoGif.Name = "_logoGif";
            this._logoGif.Size = new System.Drawing.Size(100, 50);
            this._logoGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._logoGif.TabIndex = 16;
            this._logoGif.TabStop = false;
            this._logoGif.Click += new System.EventHandler(this._logoGif_Click);
            // 
            // load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(531, 259);
            this.Controls.Add(this._helpButt);
            this.Controls.Add(this._logoGif);
            this.Controls.Add(this.pathMinecraft);
            this.Controls.Add(this.pathMods);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2ResizeBox1);
            this.Controls.Add(this.delButt);
            this.Controls.Add(this.fixButt);
            this.Controls.Add(this.changeMods);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.changeExe);
            this.Controls.Add(this.playButt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(480, 204);
            this.Name = "load";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "load";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.load_FormClosing);
            this.Load += new System.EventHandler(this.load_Load);
            ((System.ComponentModel.ISupportInitialize)(this._logoGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ShadowForm _ShadowForm;
        private Guna.UI2.WinForms.Guna2Button playButt;
        private Guna.UI2.WinForms.Guna2Button changeExe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button changeMods;
        private Guna.UI2.WinForms.Guna2Button fixButt;
        private Guna.UI2.WinForms.Guna2Button delButt;
        private Guna.UI2.WinForms.Guna2ResizeForm _ResizeForm;
        private Guna.UI2.WinForms.Guna2ResizeBox guna2ResizeBox1;
        private Guna.UI2.WinForms.Guna2DragControl _dragControl1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2DragControl _dragControl2;
        private Guna.UI2.WinForms.Guna2Elipse _elipse;
        private Guna.UI2.WinForms.Guna2TextBox pathMods;
        private Guna.UI2.WinForms.Guna2TextBox pathMinecraft;
        private Guna.UI2.WinForms.Guna2AnimateWindow _animate;
        private Guna.UI2.WinForms.Guna2Button _helpButt;
        private System.Windows.Forms.PictureBox _logoGif;
    }
}