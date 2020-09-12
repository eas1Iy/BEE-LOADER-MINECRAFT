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
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.playButt = new Guna.UI2.WinForms.Guna2Button();
            this.changeExe = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pathMinecraft = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pathMods = new System.Windows.Forms.Label();
            this.changeMods = new Guna.UI2.WinForms.Guna2Button();
            this.fixButt = new Guna.UI2.WinForms.Guna2Button();
            this.delButt = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ResizeForm1 = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.guna2ResizeBox1 = new Guna.UI2.WinForms.Guna2ResizeBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
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
            this.changeExe.Font = new System.Drawing.Font("Bahnschrift Condensed", 13F);
            this.changeExe.ForeColor = System.Drawing.Color.White;
            this.changeExe.HoverState.Parent = this.changeExe;
            this.changeExe.Location = new System.Drawing.Point(412, 62);
            this.changeExe.Name = "changeExe";
            this.changeExe.ShadowDecoration.Parent = this.changeExe;
            this.changeExe.Size = new System.Drawing.Size(76, 23);
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
            // pathMinecraft
            // 
            this.pathMinecraft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathMinecraft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pathMinecraft.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathMinecraft.ForeColor = System.Drawing.Color.White;
            this.pathMinecraft.Location = new System.Drawing.Point(158, 63);
            this.pathMinecraft.Name = "pathMinecraft";
            this.pathMinecraft.Size = new System.Drawing.Size(248, 24);
            this.pathMinecraft.TabIndex = 4;
            this.pathMinecraft.Text = "minecraft";
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
            // pathMods
            // 
            this.pathMods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pathMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pathMods.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pathMods.ForeColor = System.Drawing.Color.White;
            this.pathMods.Location = new System.Drawing.Point(158, 107);
            this.pathMods.Name = "pathMods";
            this.pathMods.Size = new System.Drawing.Size(248, 24);
            this.pathMods.TabIndex = 7;
            this.pathMods.Text = "mods";
            this.pathMods.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // changeMods
            // 
            this.changeMods.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeMods.Animated = true;
            this.changeMods.BorderRadius = 8;
            this.changeMods.CheckedState.Parent = this.changeMods;
            this.changeMods.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeMods.CustomImages.Parent = this.changeMods;
            this.changeMods.Font = new System.Drawing.Font("Bahnschrift Condensed", 13F);
            this.changeMods.ForeColor = System.Drawing.Color.White;
            this.changeMods.HoverState.Parent = this.changeMods;
            this.changeMods.Location = new System.Drawing.Point(412, 106);
            this.changeMods.Name = "changeMods";
            this.changeMods.ShadowDecoration.Parent = this.changeMods;
            this.changeMods.Size = new System.Drawing.Size(76, 23);
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
            this.guna2ResizeBox1.Location = new System.Drawing.Point(468, 237);
            this.guna2ResizeBox1.Name = "guna2ResizeBox1";
            this.guna2ResizeBox1.Size = new System.Drawing.Size(20, 20);
            this.guna2ResizeBox1.TabIndex = 10;
            this.guna2ResizeBox1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(458, 2);
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
            this.guna2ControlBox2.Location = new System.Drawing.Point(422, 2);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(30, 19);
            this.guna2ControlBox2.TabIndex = 12;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.TargetControl = this.label1;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(491, 259);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2ResizeBox1);
            this.Controls.Add(this.delButt);
            this.Controls.Add(this.fixButt);
            this.Controls.Add(this.pathMods);
            this.Controls.Add(this.changeMods);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pathMinecraft);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.changeExe);
            this.Controls.Add(this.playButt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(472, 204);
            this.Name = "load";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "load";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.load_FormClosing);
            this.Load += new System.EventHandler(this.load_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2Button playButt;
        private Guna.UI2.WinForms.Guna2Button changeExe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pathMinecraft;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label pathMods;
        private Guna.UI2.WinForms.Guna2Button changeMods;
        private Guna.UI2.WinForms.Guna2Button fixButt;
        private Guna.UI2.WinForms.Guna2Button delButt;
        private Guna.UI2.WinForms.Guna2ResizeForm guna2ResizeForm1;
        private Guna.UI2.WinForms.Guna2ResizeBox guna2ResizeBox1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
    }
}