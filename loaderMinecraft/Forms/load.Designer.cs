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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(load));
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            this._welcomLbl = new System.Windows.Forms.Label();
            this.playButt = new Guna.UI2.WinForms.Guna2Button();
            this.changeExe = new Guna.UI2.WinForms.Guna2Button();
            this.pathMi = new System.Windows.Forms.Label();
            this.pathMo = new System.Windows.Forms.Label();
            this.changeMods = new Guna.UI2.WinForms.Guna2Button();
            this.fixButt = new Guna.UI2.WinForms.Guna2Button();
            this.delButt = new Guna.UI2.WinForms.Guna2Button();
            this._ResizeForm = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.resize = new Guna.UI2.WinForms.Guna2ResizeBox();
            this._closeButt = new Guna.UI2.WinForms.Guna2ControlBox();
            this._hideButt = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pathMods = new Guna.UI2.WinForms.Guna2TextBox();
            this.pathMinecraft = new Guna.UI2.WinForms.Guna2TextBox();
            this._animate = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this._helpButt = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.editPathMods = new Guna.UI2.WinForms.Guna2Button();
            this.editPathMinecraft = new Guna.UI2.WinForms.Guna2Button();
            this.seprator = new Guna.UI2.WinForms.Guna2Separator();
            this._dragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this._dragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.onlineLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tooltip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this._anim = new Guna.UI2.WinForms.Guna2Transition();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this._anim2 = new Guna.UI2.WinForms.Guna2Transition();
            this.updateServerInfo = new System.Windows.Forms.Timer(this.components);
            this._gitButt = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel1.SuspendLayout();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _welcomLbl
            // 
            this._welcomLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._welcomLbl.AutoSize = true;
            this._anim.SetDecoration(this._welcomLbl, Guna.UI2.AnimatorNS.DecorationType.None);
            this._anim2.SetDecoration(this._welcomLbl, Guna.UI2.AnimatorNS.DecorationType.None);
            this._welcomLbl.Font = new System.Drawing.Font("Malgun Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._welcomLbl.Location = new System.Drawing.Point(9, 10);
            this._welcomLbl.Name = "_welcomLbl";
            this._welcomLbl.Size = new System.Drawing.Size(235, 31);
            this._welcomLbl.TabIndex = 0;
            this._welcomLbl.Text = "BEE LOADER version ";
            this._welcomLbl.Visible = false;
            // 
            // playButt
            // 
            this.playButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.playButt.Animated = true;
            this.playButt.BorderRadius = 8;
            this.playButt.CheckedState.Parent = this.playButt;
            this.playButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playButt.CustomImages.Parent = this.playButt;
            this._anim2.SetDecoration(this.playButt, Guna.UI2.AnimatorNS.DecorationType.None);
            this._anim.SetDecoration(this.playButt, Guna.UI2.AnimatorNS.DecorationType.None);
            this.playButt.Enabled = false;
            this.playButt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this.playButt.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.playButt.ForeColor = System.Drawing.Color.White;
            this.playButt.HoverState.Parent = this.playButt;
            this.playButt.Location = new System.Drawing.Point(9, 190);
            this.playButt.Name = "playButt";
            this.playButt.ShadowDecoration.Parent = this.playButt;
            this.playButt.Size = new System.Drawing.Size(190, 52);
            this.playButt.TabIndex = 1;
            this.playButt.Text = "Играть";
            this.tooltip.SetToolTip(this.playButt, "Нажмите, чтобы играть.");
            this.playButt.Visible = false;
            this.playButt.Click += new System.EventHandler(this.playButt_Click);
            // 
            // changeExe
            // 
            this.changeExe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeExe.Animated = true;
            this.changeExe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.changeExe.BorderRadius = 8;
            this.changeExe.BorderThickness = 1;
            this.changeExe.CheckedState.Parent = this.changeExe;
            this.changeExe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeExe.CustomImages.Parent = this.changeExe;
            this._anim2.SetDecoration(this.changeExe, Guna.UI2.AnimatorNS.DecorationType.None);
            this._anim.SetDecoration(this.changeExe, Guna.UI2.AnimatorNS.DecorationType.None);
            this.changeExe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this.changeExe.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.changeExe.ForeColor = System.Drawing.Color.White;
            this.changeExe.HoverState.Parent = this.changeExe;
            this.changeExe.Location = new System.Drawing.Point(340, 5);
            this.changeExe.Name = "changeExe";
            this.changeExe.ShadowDecoration.Parent = this.changeExe;
            this.changeExe.Size = new System.Drawing.Size(76, 24);
            this.changeExe.TabIndex = 2;
            this.changeExe.Text = "Выбрать";
            this.tooltip.SetToolTip(this.changeExe, "Необходимо выбрать .exe вашего лаунчера.");
            this.changeExe.Click += new System.EventHandler(this.changeExe_Click);
            // 
            // pathMi
            // 
            this._anim.SetDecoration(this.pathMi, Guna.UI2.AnimatorNS.DecorationType.None);
            this._anim2.SetDecoration(this.pathMi, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pathMi.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.pathMi.Location = new System.Drawing.Point(5, 4);
            this.pathMi.Name = "pathMi";
            this.pathMi.Size = new System.Drawing.Size(161, 21);
            this.pathMi.TabIndex = 3;
            this.pathMi.Text = "Путь к майнкрафту:";
            // 
            // pathMo
            // 
            this._anim.SetDecoration(this.pathMo, Guna.UI2.AnimatorNS.DecorationType.None);
            this._anim2.SetDecoration(this.pathMo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pathMo.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.pathMo.Location = new System.Drawing.Point(7, 53);
            this.pathMo.Name = "pathMo";
            this.pathMo.Size = new System.Drawing.Size(157, 21);
            this.pathMo.TabIndex = 5;
            this.pathMo.Text = "Папка с модами:";
            // 
            // changeMods
            // 
            this.changeMods.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeMods.Animated = true;
            this.changeMods.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.changeMods.BorderRadius = 8;
            this.changeMods.BorderThickness = 1;
            this.changeMods.CheckedState.Parent = this.changeMods;
            this.changeMods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeMods.CustomImages.Parent = this.changeMods;
            this._anim2.SetDecoration(this.changeMods, Guna.UI2.AnimatorNS.DecorationType.None);
            this._anim.SetDecoration(this.changeMods, Guna.UI2.AnimatorNS.DecorationType.None);
            this.changeMods.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this.changeMods.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.changeMods.ForeColor = System.Drawing.Color.White;
            this.changeMods.HoverState.Parent = this.changeMods;
            this.changeMods.Location = new System.Drawing.Point(340, 50);
            this.changeMods.Name = "changeMods";
            this.changeMods.ShadowDecoration.Parent = this.changeMods;
            this.changeMods.Size = new System.Drawing.Size(76, 24);
            this.changeMods.TabIndex = 6;
            this.changeMods.Text = "Выбрать";
            this.tooltip.SetToolTip(this.changeMods, "Необходимо выбрать папку, куда будут загружены моды.");
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
            this._anim2.SetDecoration(this.fixButt, Guna.UI2.AnimatorNS.DecorationType.None);
            this._anim.SetDecoration(this.fixButt, Guna.UI2.AnimatorNS.DecorationType.None);
            this.fixButt.Enabled = false;
            this.fixButt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this.fixButt.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.fixButt.ForeColor = System.Drawing.Color.White;
            this.fixButt.HoverState.Parent = this.fixButt;
            this.fixButt.Location = new System.Drawing.Point(205, 219);
            this.fixButt.Name = "fixButt";
            this.fixButt.ShadowDecoration.Parent = this.fixButt;
            this.fixButt.Size = new System.Drawing.Size(128, 23);
            this.fixButt.TabIndex = 8;
            this.fixButt.Text = "Проверить моды";
            this.tooltip.SetToolTip(this.fixButt, "Проверит загруженные моды, майнкрафт запущен не будет.");
            this.fixButt.Visible = false;
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
            this._anim2.SetDecoration(this.delButt, Guna.UI2.AnimatorNS.DecorationType.None);
            this._anim.SetDecoration(this.delButt, Guna.UI2.AnimatorNS.DecorationType.None);
            this.delButt.Enabled = false;
            this.delButt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this.delButt.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.delButt.ForeColor = System.Drawing.Color.White;
            this.delButt.HoverState.Parent = this.delButt;
            this.delButt.Location = new System.Drawing.Point(205, 190);
            this.delButt.Name = "delButt";
            this.delButt.ShadowDecoration.Parent = this.delButt;
            this.delButt.Size = new System.Drawing.Size(128, 23);
            this.delButt.TabIndex = 9;
            this.delButt.Text = "Удалить моды";
            this.tooltip.SetToolTip(this.delButt, "Очистит ваши загруженные моды.");
            this.delButt.Visible = false;
            this.delButt.Click += new System.EventHandler(this.delButt_Click);
            // 
            // resize
            // 
            this.resize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resize.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this._anim2.SetDecoration(this.resize, Guna.UI2.AnimatorNS.DecorationType.None);
            this._anim.SetDecoration(this.resize, Guna.UI2.AnimatorNS.DecorationType.None);
            this.resize.ForeColor = System.Drawing.Color.Empty;
            this.resize.Location = new System.Drawing.Point(503, 224);
            this.resize.Name = "resize";
            this.resize.Size = new System.Drawing.Size(20, 20);
            this.resize.TabIndex = 10;
            this.resize.TargetControl = this;
            this.resize.Visible = false;
            // 
            // _closeButt
            // 
            this._closeButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._closeButt.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this._closeButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this._anim2.SetDecoration(this._closeButt, Guna.UI2.AnimatorNS.DecorationType.None);
            this._anim.SetDecoration(this._closeButt, Guna.UI2.AnimatorNS.DecorationType.None);
            this._closeButt.FillColor = System.Drawing.Color.White;
            this._closeButt.HoverState.Parent = this._closeButt;
            this._closeButt.IconColor = System.Drawing.Color.Black;
            this._closeButt.Location = new System.Drawing.Point(491, 4);
            this._closeButt.Name = "_closeButt";
            this._closeButt.ShadowDecoration.Parent = this._closeButt;
            this._closeButt.Size = new System.Drawing.Size(30, 19);
            this._closeButt.TabIndex = 11;
            this._closeButt.Visible = false;
            // 
            // _hideButt
            // 
            this._hideButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._hideButt.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this._hideButt.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this._hideButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this._anim2.SetDecoration(this._hideButt, Guna.UI2.AnimatorNS.DecorationType.None);
            this._anim.SetDecoration(this._hideButt, Guna.UI2.AnimatorNS.DecorationType.None);
            this._hideButt.FillColor = System.Drawing.Color.White;
            this._hideButt.HoverState.Parent = this._hideButt;
            this._hideButt.IconColor = System.Drawing.Color.Black;
            this._hideButt.Location = new System.Drawing.Point(455, 4);
            this._hideButt.Name = "_hideButt";
            this._hideButt.ShadowDecoration.Parent = this._hideButt;
            this._hideButt.Size = new System.Drawing.Size(30, 19);
            this._hideButt.TabIndex = 12;
            this._hideButt.Visible = false;
            // 
            // pathMods
            // 
            this.pathMods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathMods.BackColor = System.Drawing.Color.White;
            this.pathMods.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.pathMods.BorderRadius = 11;
            this.pathMods.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._anim2.SetDecoration(this.pathMods, Guna.UI2.AnimatorNS.DecorationType.None);
            this._anim.SetDecoration(this.pathMods, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pathMods.DefaultText = "";
            this.pathMods.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pathMods.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pathMods.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pathMods.DisabledState.Parent = this.pathMods;
            this.pathMods.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pathMods.Enabled = false;
            this.pathMods.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this.pathMods.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.pathMods.FocusedState.Parent = this.pathMods;
            this.pathMods.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathMods.ForeColor = System.Drawing.Color.White;
            this.pathMods.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.pathMods.HoverState.Parent = this.pathMods;
            this.pathMods.Location = new System.Drawing.Point(166, 50);
            this.pathMods.Margin = new System.Windows.Forms.Padding(5, 11, 5, 11);
            this.pathMods.Name = "pathMods";
            this.pathMods.PasswordChar = '\0';
            this.pathMods.PlaceholderForeColor = System.Drawing.Color.White;
            this.pathMods.PlaceholderText = "";
            this.pathMods.SelectedText = "";
            this.pathMods.ShadowDecoration.Parent = this.pathMods;
            this.pathMods.Size = new System.Drawing.Size(166, 24);
            this.pathMods.TabIndex = 13;
            this.pathMods.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pathMinecraft
            // 
            this.pathMinecraft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathMinecraft.Animated = true;
            this.pathMinecraft.AutoRoundedCorners = true;
            this.pathMinecraft.BackColor = System.Drawing.Color.White;
            this.pathMinecraft.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.pathMinecraft.BorderRadius = 11;
            this.pathMinecraft.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._anim2.SetDecoration(this.pathMinecraft, Guna.UI2.AnimatorNS.DecorationType.None);
            this._anim.SetDecoration(this.pathMinecraft, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pathMinecraft.DefaultText = "";
            this.pathMinecraft.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pathMinecraft.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pathMinecraft.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pathMinecraft.DisabledState.Parent = this.pathMinecraft;
            this.pathMinecraft.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pathMinecraft.Enabled = false;
            this.pathMinecraft.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this.pathMinecraft.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.pathMinecraft.FocusedState.Parent = this.pathMinecraft;
            this.pathMinecraft.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pathMinecraft.ForeColor = System.Drawing.Color.White;
            this.pathMinecraft.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.pathMinecraft.HoverState.Parent = this.pathMinecraft;
            this.pathMinecraft.Location = new System.Drawing.Point(167, 5);
            this.pathMinecraft.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pathMinecraft.Name = "pathMinecraft";
            this.pathMinecraft.PasswordChar = '\0';
            this.pathMinecraft.PlaceholderForeColor = System.Drawing.Color.White;
            this.pathMinecraft.PlaceholderText = "";
            this.pathMinecraft.SelectedText = "";
            this.pathMinecraft.ShadowDecoration.Parent = this.pathMinecraft;
            this.pathMinecraft.Size = new System.Drawing.Size(166, 24);
            this.pathMinecraft.TabIndex = 14;
            this.pathMinecraft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _animate
            // 
            this._animate.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            // 
            // _helpButt
            // 
            this._helpButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._helpButt.Animated = true;
            this._helpButt.BorderRadius = 8;
            this._helpButt.CheckedState.Parent = this._helpButt;
            this._helpButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this._helpButt.CustomImages.Parent = this._helpButt;
            this._anim2.SetDecoration(this._helpButt, Guna.UI2.AnimatorNS.DecorationType.None);
            this._anim.SetDecoration(this._helpButt, Guna.UI2.AnimatorNS.DecorationType.None);
            this._helpButt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this._helpButt.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this._helpButt.ForeColor = System.Drawing.Color.White;
            this._helpButt.HoverState.Parent = this._helpButt;
            this._helpButt.Location = new System.Drawing.Point(337, 219);
            this._helpButt.Name = "_helpButt";
            this._helpButt.ShadowDecoration.Parent = this._helpButt;
            this._helpButt.Size = new System.Drawing.Size(70, 23);
            this._helpButt.TabIndex = 15;
            this._helpButt.Text = "Помощь";
            this.tooltip.SetToolTip(this._helpButt, "Справка.");
            this._helpButt.Visible = false;
            this._helpButt.Click += new System.EventHandler(this._helpButt_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2GradientPanel1.Controls.Add(this.editPathMods);
            this.guna2GradientPanel1.Controls.Add(this.editPathMinecraft);
            this.guna2GradientPanel1.Controls.Add(this.pathMods);
            this.guna2GradientPanel1.Controls.Add(this.pathMi);
            this.guna2GradientPanel1.Controls.Add(this.changeMods);
            this.guna2GradientPanel1.Controls.Add(this.pathMinecraft);
            this.guna2GradientPanel1.Controls.Add(this.pathMo);
            this.guna2GradientPanel1.Controls.Add(this.changeExe);
            this._anim2.SetDecoration(this.guna2GradientPanel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this._anim.SetDecoration(this.guna2GradientPanel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2GradientPanel1.Location = new System.Drawing.Point(9, 52);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(515, 79);
            this.guna2GradientPanel1.TabIndex = 17;
            this.guna2GradientPanel1.Visible = false;
            // 
            // editPathMods
            // 
            this.editPathMods.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editPathMods.Animated = true;
            this.editPathMods.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.editPathMods.BorderRadius = 8;
            this.editPathMods.BorderThickness = 1;
            this.editPathMods.CheckedState.Parent = this.editPathMods;
            this.editPathMods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editPathMods.CustomImages.Parent = this.editPathMods;
            this._anim2.SetDecoration(this.editPathMods, Guna.UI2.AnimatorNS.DecorationType.None);
            this._anim.SetDecoration(this.editPathMods, Guna.UI2.AnimatorNS.DecorationType.None);
            this.editPathMods.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this.editPathMods.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.editPathMods.ForeColor = System.Drawing.Color.White;
            this.editPathMods.HoverState.Parent = this.editPathMods;
            this.editPathMods.Location = new System.Drawing.Point(421, 49);
            this.editPathMods.Name = "editPathMods";
            this.editPathMods.ShadowDecoration.Parent = this.editPathMods;
            this.editPathMods.Size = new System.Drawing.Size(85, 24);
            this.editPathMods.TabIndex = 16;
            this.editPathMods.Text = "Редактир.";
            this.tooltip.SetToolTip(this.editPathMods, "Необходимо сохранять, после ручного редактирования!");
            this.editPathMods.Click += new System.EventHandler(this.editPathMods_Click);
            // 
            // editPathMinecraft
            // 
            this.editPathMinecraft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editPathMinecraft.Animated = true;
            this.editPathMinecraft.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(162)))), ((int)(((byte)(44)))));
            this.editPathMinecraft.BorderRadius = 8;
            this.editPathMinecraft.BorderThickness = 1;
            this.editPathMinecraft.CheckedState.Parent = this.editPathMinecraft;
            this.editPathMinecraft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editPathMinecraft.CustomImages.Parent = this.editPathMinecraft;
            this._anim2.SetDecoration(this.editPathMinecraft, Guna.UI2.AnimatorNS.DecorationType.None);
            this._anim.SetDecoration(this.editPathMinecraft, Guna.UI2.AnimatorNS.DecorationType.None);
            this.editPathMinecraft.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this.editPathMinecraft.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.editPathMinecraft.ForeColor = System.Drawing.Color.White;
            this.editPathMinecraft.HoverState.Parent = this.editPathMinecraft;
            this.editPathMinecraft.Location = new System.Drawing.Point(421, 4);
            this.editPathMinecraft.Name = "editPathMinecraft";
            this.editPathMinecraft.ShadowDecoration.Parent = this.editPathMinecraft;
            this.editPathMinecraft.Size = new System.Drawing.Size(85, 24);
            this.editPathMinecraft.TabIndex = 15;
            this.editPathMinecraft.Text = "Редактир.";
            this.tooltip.SetToolTip(this.editPathMinecraft, "Необходимо сохранять, после ручного редактирования!");
            this.editPathMinecraft.Click += new System.EventHandler(this.editPathMinecraft_Click);
            // 
            // seprator
            // 
            this.seprator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this._anim2.SetDecoration(this.seprator, Guna.UI2.AnimatorNS.DecorationType.None);
            this._anim.SetDecoration(this.seprator, Guna.UI2.AnimatorNS.DecorationType.None);
            this.seprator.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this.seprator.Location = new System.Drawing.Point(37, 158);
            this.seprator.Name = "seprator";
            this.seprator.Size = new System.Drawing.Size(465, 5);
            this.seprator.TabIndex = 18;
            this.seprator.Visible = false;
            // 
            // _dragControl2
            // 
            this._dragControl2.TargetControl = this._welcomLbl;
            this._dragControl2.UseTransparentDrag = true;
            // 
            // _dragControl1
            // 
            this._dragControl1.TargetControl = this.guna2CustomGradientPanel2;
            this._dragControl1.UseTransparentDrag = true;
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Controls.Add(this._gitButt);
            this.guna2CustomGradientPanel2.Controls.Add(this.onlineLbl);
            this.guna2CustomGradientPanel2.Controls.Add(this.label3);
            this.guna2CustomGradientPanel2.Controls.Add(this.statusLbl);
            this.guna2CustomGradientPanel2.Controls.Add(this.label1);
            this.guna2CustomGradientPanel2.Controls.Add(this.resize);
            this.guna2CustomGradientPanel2.Controls.Add(this._hideButt);
            this.guna2CustomGradientPanel2.Controls.Add(this._closeButt);
            this._anim2.SetDecoration(this.guna2CustomGradientPanel2, Guna.UI2.AnimatorNS.DecorationType.None);
            this._anim.SetDecoration(this.guna2CustomGradientPanel2, Guna.UI2.AnimatorNS.DecorationType.None);
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
            // onlineLbl
            // 
            this.onlineLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.onlineLbl.Cursor = System.Windows.Forms.Cursors.Help;
            this._anim.SetDecoration(this.onlineLbl, Guna.UI2.AnimatorNS.DecorationType.None);
            this._anim2.SetDecoration(this.onlineLbl, Guna.UI2.AnimatorNS.DecorationType.None);
            this.onlineLbl.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.onlineLbl.Location = new System.Drawing.Point(380, 131);
            this.onlineLbl.Name = "onlineLbl";
            this.onlineLbl.Size = new System.Drawing.Size(66, 21);
            this.onlineLbl.TabIndex = 16;
            this.onlineLbl.Text = "0/10";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._anim.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this._anim2.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.label3.Location = new System.Drawing.Point(302, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Онлайн:";
            // 
            // statusLbl
            // 
            this.statusLbl.Cursor = System.Windows.Forms.Cursors.Help;
            this._anim.SetDecoration(this.statusLbl, Guna.UI2.AnimatorNS.DecorationType.None);
            this._anim2.SetDecoration(this.statusLbl, Guna.UI2.AnimatorNS.DecorationType.None);
            this.statusLbl.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.statusLbl.Location = new System.Drawing.Point(202, 131);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(94, 21);
            this.statusLbl.TabIndex = 14;
            this.statusLbl.Text = "Работает";
            // 
            // label1
            // 
            this._anim.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this._anim2.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(65, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Статус сервера:";
            // 
            // tooltip
            // 
            this.tooltip.AllowLinksHandling = true;
            this.tooltip.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this.tooltip.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.tooltip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this.tooltip.MaximumSize = new System.Drawing.Size(0, 0);
            this.tooltip.TitleFont = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.tooltip.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            // 
            // _anim
            // 
            this._anim.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this._anim.Cursor = null;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this._anim.DefaultAnimation = animation1;
            this._anim.Interval = 15;
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2CustomGradientPanel2);
            this._anim2.SetDecoration(this.guna2CustomGradientPanel1, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(533, 254);
            this.guna2CustomGradientPanel1.TabIndex = 19;
            // 
            // _anim2
            // 
            this._anim2.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizBlind;
            this._anim2.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this._anim2.DefaultAnimation = animation2;
            this._anim2.Interval = 15;
            // 
            // updateServerInfo
            // 
            this.updateServerInfo.Enabled = true;
            this.updateServerInfo.Interval = 5000;
            this.updateServerInfo.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // _gitButt
            // 
            this._gitButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._gitButt.Animated = true;
            this._gitButt.BorderRadius = 8;
            this._gitButt.CheckedState.Parent = this._gitButt;
            this._gitButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this._gitButt.CustomImages.Parent = this._gitButt;
            this._anim2.SetDecoration(this._gitButt, Guna.UI2.AnimatorNS.DecorationType.None);
            this._anim.SetDecoration(this._gitButt, Guna.UI2.AnimatorNS.DecorationType.None);
            this._gitButt.FillColor = System.Drawing.Color.Transparent;
            this._gitButt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this._gitButt.ForeColor = System.Drawing.Color.White;
            this._gitButt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(96)))));
            this._gitButt.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this._gitButt.HoverState.FillColor = System.Drawing.Color.Transparent;
            this._gitButt.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this._gitButt.HoverState.Parent = this._gitButt;
            this._gitButt.Image = global::BEE.Properties.Resources._github;
            this._gitButt.ImageSize = new System.Drawing.Size(50, 50);
            this._gitButt.Location = new System.Drawing.Point(437, 182);
            this._gitButt.Name = "_gitButt";
            this._gitButt.ShadowDecoration.Parent = this._gitButt;
            this._gitButt.Size = new System.Drawing.Size(62, 57);
            this._gitButt.TabIndex = 17;
            this._gitButt.Click += new System.EventHandler(this._gitButt_Click);
            // 
            // load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(533, 254);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.seprator);
            this.Controls.Add(this._helpButt);
            this.Controls.Add(this.delButt);
            this.Controls.Add(this.fixButt);
            this.Controls.Add(this.playButt);
            this.Controls.Add(this._welcomLbl);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this._anim2.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this._anim.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(509, 224);
            this.Name = "load";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BEE - Главное меню";
            this.TransparencyKey = System.Drawing.Color.Green;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.load_FormClosing);
            this.Load += new System.EventHandler(this.load_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _welcomLbl;
        private Guna.UI2.WinForms.Guna2Button playButt;
        private Guna.UI2.WinForms.Guna2Button changeExe;
        private System.Windows.Forms.Label pathMi;
        private System.Windows.Forms.Label pathMo;
        private Guna.UI2.WinForms.Guna2Button changeMods;
        private Guna.UI2.WinForms.Guna2Button fixButt;
        private Guna.UI2.WinForms.Guna2Button delButt;
        private Guna.UI2.WinForms.Guna2ResizeForm _ResizeForm;
        private Guna.UI2.WinForms.Guna2ResizeBox resize;
        private Guna.UI2.WinForms.Guna2ControlBox _closeButt;
        private Guna.UI2.WinForms.Guna2ControlBox _hideButt;
        private Guna.UI2.WinForms.Guna2TextBox pathMods;
        private Guna.UI2.WinForms.Guna2TextBox pathMinecraft;
        private Guna.UI2.WinForms.Guna2AnimateWindow _animate;
        private Guna.UI2.WinForms.Guna2Button _helpButt;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Separator seprator;
        private Guna.UI2.WinForms.Guna2DragControl _dragControl2;
        private Guna.UI2.WinForms.Guna2DragControl _dragControl1;
        private Guna.UI2.WinForms.Guna2Button editPathMods;
        private Guna.UI2.WinForms.Guna2Button editPathMinecraft;
        private Guna.UI2.WinForms.Guna2HtmlToolTip tooltip;
        private Guna.UI2.WinForms.Guna2Transition _anim;
        private Guna.UI2.WinForms.Guna2Transition _anim2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label onlineLbl;
        private System.Windows.Forms.Timer updateServerInfo;
        private Guna.UI2.WinForms.Guna2Button _gitButt;
    }
}