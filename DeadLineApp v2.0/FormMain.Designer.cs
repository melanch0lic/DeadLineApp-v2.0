namespace DeadLineApp_v2._0
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelShadow = new System.Windows.Forms.Panel();
            this.notifyIconDeadLine = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradientPanelDesktop = new DeadLineApp_v2._0.GradientPanel();
            this.gradientPanelTitleBar = new DeadLineApp_v2._0.GradientPanel();
            this.iconButtonMinimize = new FontAwesome.Sharp.IconButton();
            this.iconButtonExit = new FontAwesome.Sharp.IconButton();
            this.labelTitleofChildForm = new System.Windows.Forms.Label();
            this.iconCurrenChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.gradientPanelMenu = new DeadLineApp_v2._0.GradientPanel();
            this.iconButtonOptions = new FontAwesome.Sharp.IconButton();
            this.iconButtonHelp = new FontAwesome.Sharp.IconButton();
            this.iconButtonCalendar = new FontAwesome.Sharp.IconButton();
            this.iconButtonMenu = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStripNotify.SuspendLayout();
            this.gradientPanelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrenChildForm)).BeginInit();
            this.gradientPanelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 75);
            this.panelShadow.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(995, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // notifyIconDeadLine
            // 
            this.notifyIconDeadLine.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconDeadLine.Icon")));
            this.notifyIconDeadLine.Text = "DeadLine Calender";
            this.notifyIconDeadLine.Visible = true;
            this.notifyIconDeadLine.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconDeadLine_MouseClick);
            // 
            // contextMenuStripNotify
            // 
            this.contextMenuStripNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.помощьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.contextMenuStripNotify.Name = "contextMenuStripNotify";
            this.contextMenuStripNotify.Size = new System.Drawing.Size(181, 70);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // gradientPanelDesktop
            // 
            this.gradientPanelDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientPanelDesktop.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.gradientPanelDesktop.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.gradientPanelDesktop.Location = new System.Drawing.Point(220, 84);
            this.gradientPanelDesktop.MinimumSize = new System.Drawing.Size(1, 1);
            this.gradientPanelDesktop.Name = "gradientPanelDesktop";
            this.gradientPanelDesktop.Size = new System.Drawing.Size(995, 585);
            this.gradientPanelDesktop.TabIndex = 3;
            // 
            // gradientPanelTitleBar
            // 
            this.gradientPanelTitleBar.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.gradientPanelTitleBar.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.gradientPanelTitleBar.Controls.Add(this.iconButtonMinimize);
            this.gradientPanelTitleBar.Controls.Add(this.iconButtonExit);
            this.gradientPanelTitleBar.Controls.Add(this.labelTitleofChildForm);
            this.gradientPanelTitleBar.Controls.Add(this.iconCurrenChildForm);
            this.gradientPanelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.gradientPanelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.gradientPanelTitleBar.Name = "gradientPanelTitleBar";
            this.gradientPanelTitleBar.Size = new System.Drawing.Size(995, 75);
            this.gradientPanelTitleBar.TabIndex = 1;
            this.gradientPanelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gradientPanelTitleBar_MouseDown);
            // 
            // iconButtonMinimize
            // 
            this.iconButtonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.iconButtonMinimize.FlatAppearance.BorderSize = 0;
            this.iconButtonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMinimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonMinimize.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.iconButtonMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButtonMinimize.IconColor = System.Drawing.Color.White;
            this.iconButtonMinimize.IconSize = 20;
            this.iconButtonMinimize.Location = new System.Drawing.Point(915, 3);
            this.iconButtonMinimize.Name = "iconButtonMinimize";
            this.iconButtonMinimize.Rotation = 0D;
            this.iconButtonMinimize.Size = new System.Drawing.Size(35, 20);
            this.iconButtonMinimize.TabIndex = 6;
            this.iconButtonMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonMinimize.UseVisualStyleBackColor = false;
            this.iconButtonMinimize.Click += new System.EventHandler(this.iconButtonMinimize_Click);
            // 
            // iconButtonExit
            // 
            this.iconButtonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.iconButtonExit.FlatAppearance.BorderSize = 0;
            this.iconButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonExit.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.iconButtonExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButtonExit.IconColor = System.Drawing.Color.White;
            this.iconButtonExit.IconSize = 20;
            this.iconButtonExit.Location = new System.Drawing.Point(956, 3);
            this.iconButtonExit.Name = "iconButtonExit";
            this.iconButtonExit.Rotation = 0D;
            this.iconButtonExit.Size = new System.Drawing.Size(35, 20);
            this.iconButtonExit.TabIndex = 4;
            this.iconButtonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonExit.UseVisualStyleBackColor = false;
            this.iconButtonExit.Click += new System.EventHandler(this.iconButtonExit_Click_1);
            // 
            // labelTitleofChildForm
            // 
            this.labelTitleofChildForm.AutoSize = true;
            this.labelTitleofChildForm.BackColor = System.Drawing.Color.Transparent;
            this.labelTitleofChildForm.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitleofChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitleofChildForm.Location = new System.Drawing.Point(72, 39);
            this.labelTitleofChildForm.Name = "labelTitleofChildForm";
            this.labelTitleofChildForm.Size = new System.Drawing.Size(65, 23);
            this.labelTitleofChildForm.TabIndex = 3;
            this.labelTitleofChildForm.Text = "Home";
            // 
            // iconCurrenChildForm
            // 
            this.iconCurrenChildForm.BackColor = System.Drawing.Color.Transparent;
            this.iconCurrenChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.iconCurrenChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrenChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(126)))), ((int)(((byte)(241)))));
            this.iconCurrenChildForm.IconSize = 44;
            this.iconCurrenChildForm.Location = new System.Drawing.Point(17, 28);
            this.iconCurrenChildForm.Name = "iconCurrenChildForm";
            this.iconCurrenChildForm.Size = new System.Drawing.Size(49, 44);
            this.iconCurrenChildForm.TabIndex = 2;
            this.iconCurrenChildForm.TabStop = false;
            // 
            // gradientPanelMenu
            // 
            this.gradientPanelMenu.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.gradientPanelMenu.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.gradientPanelMenu.Controls.Add(this.iconButtonOptions);
            this.gradientPanelMenu.Controls.Add(this.iconButtonHelp);
            this.gradientPanelMenu.Controls.Add(this.iconButtonCalendar);
            this.gradientPanelMenu.Controls.Add(this.iconButtonMenu);
            this.gradientPanelMenu.Controls.Add(this.panelLogo);
            this.gradientPanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientPanelMenu.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelMenu.MinimumSize = new System.Drawing.Size(1, 1);
            this.gradientPanelMenu.Name = "gradientPanelMenu";
            this.gradientPanelMenu.Size = new System.Drawing.Size(220, 669);
            this.gradientPanelMenu.TabIndex = 0;
            this.gradientPanelMenu.Resize += new System.EventHandler(this.gradientPanelMenu_Resize);
            // 
            // iconButtonOptions
            // 
            this.iconButtonOptions.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonOptions.FlatAppearance.BorderSize = 0;
            this.iconButtonOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonOptions.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonOptions.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonOptions.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonOptions.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.iconButtonOptions.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonOptions.IconSize = 32;
            this.iconButtonOptions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonOptions.Location = new System.Drawing.Point(0, 280);
            this.iconButtonOptions.Name = "iconButtonOptions";
            this.iconButtonOptions.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonOptions.Rotation = 0D;
            this.iconButtonOptions.Size = new System.Drawing.Size(220, 60);
            this.iconButtonOptions.TabIndex = 4;
            this.iconButtonOptions.Text = "Options";
            this.iconButtonOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonOptions.UseVisualStyleBackColor = false;
            this.iconButtonOptions.Click += new System.EventHandler(this.iconButtonOptions_Click);
            this.iconButtonOptions.MouseEnter += new System.EventHandler(this.iconButtonOptions_MouseEnter);
            this.iconButtonOptions.MouseLeave += new System.EventHandler(this.iconButtonOptions_MouseLeave);
            // 
            // iconButtonHelp
            // 
            this.iconButtonHelp.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonHelp.FlatAppearance.BorderSize = 0;
            this.iconButtonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonHelp.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonHelp.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonHelp.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonHelp.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.iconButtonHelp.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonHelp.IconSize = 32;
            this.iconButtonHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonHelp.Location = new System.Drawing.Point(0, 220);
            this.iconButtonHelp.Name = "iconButtonHelp";
            this.iconButtonHelp.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonHelp.Rotation = 0D;
            this.iconButtonHelp.Size = new System.Drawing.Size(220, 60);
            this.iconButtonHelp.TabIndex = 3;
            this.iconButtonHelp.Text = "Help";
            this.iconButtonHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonHelp.UseVisualStyleBackColor = false;
            this.iconButtonHelp.Click += new System.EventHandler(this.iconButtonHelp_Click);
            this.iconButtonHelp.MouseEnter += new System.EventHandler(this.iconButtonHelp_MouseEnter);
            this.iconButtonHelp.MouseLeave += new System.EventHandler(this.iconButtonHelp_MouseLeave);
            // 
            // iconButtonCalendar
            // 
            this.iconButtonCalendar.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonCalendar.FlatAppearance.BorderSize = 0;
            this.iconButtonCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCalendar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonCalendar.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonCalendar.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonCalendar.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.iconButtonCalendar.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonCalendar.IconSize = 32;
            this.iconButtonCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCalendar.Location = new System.Drawing.Point(0, 160);
            this.iconButtonCalendar.Name = "iconButtonCalendar";
            this.iconButtonCalendar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonCalendar.Rotation = 0D;
            this.iconButtonCalendar.Size = new System.Drawing.Size(220, 60);
            this.iconButtonCalendar.TabIndex = 2;
            this.iconButtonCalendar.Text = "DeadLine Calendar";
            this.iconButtonCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCalendar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCalendar.UseVisualStyleBackColor = false;
            this.iconButtonCalendar.Click += new System.EventHandler(this.iconButtonCalendar_Click);
            this.iconButtonCalendar.MouseEnter += new System.EventHandler(this.iconButtonCalendar_MouseEnter);
            this.iconButtonCalendar.MouseLeave += new System.EventHandler(this.iconButtonCalendar_MouseLeave);
            // 
            // iconButtonMenu
            // 
            this.iconButtonMenu.BackColor = System.Drawing.Color.Transparent;
            this.iconButtonMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonMenu.FlatAppearance.BorderSize = 0;
            this.iconButtonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonMenu.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButtonMenu.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButtonMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonMenu.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButtonMenu.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonMenu.IconSize = 32;
            this.iconButtonMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMenu.Location = new System.Drawing.Point(0, 100);
            this.iconButtonMenu.Name = "iconButtonMenu";
            this.iconButtonMenu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButtonMenu.Rotation = 0D;
            this.iconButtonMenu.Size = new System.Drawing.Size(220, 60);
            this.iconButtonMenu.TabIndex = 1;
            this.iconButtonMenu.Text = "Main Menu";
            this.iconButtonMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonMenu.UseVisualStyleBackColor = false;
            this.iconButtonMenu.Click += new System.EventHandler(this.iconButtonMenu_Click);
            this.iconButtonMenu.MouseEnter += new System.EventHandler(this.iconButtonMenu_MouseEnter);
            this.iconButtonMenu.MouseLeave += new System.EventHandler(this.iconButtonMenu_MouseLeave);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.MinimumSize = new System.Drawing.Size(1, 1);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(95, 12);
            this.label1.MinimumSize = new System.Drawing.Size(1, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 71);
            this.label1.TabIndex = 2;
            this.label1.Text = "DeadLine Calendar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 669);
            this.Controls.Add(this.gradientPanelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.gradientPanelTitleBar);
            this.Controls.Add(this.gradientPanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1231, 708);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeadLineCalendar";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.contextMenuStripNotify.ResumeLayout(false);
            this.gradientPanelTitleBar.ResumeLayout(false);
            this.gradientPanelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrenChildForm)).EndInit();
            this.gradientPanelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconButtonMenu;
        private FontAwesome.Sharp.IconButton iconButtonOptions;
        private FontAwesome.Sharp.IconButton iconButtonHelp;
        private FontAwesome.Sharp.IconButton iconButtonCalendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconCurrenChildForm;
        private System.Windows.Forms.Label labelTitleofChildForm;
        private FontAwesome.Sharp.IconButton iconButtonExit;
        private FontAwesome.Sharp.IconButton iconButtonMinimize;
        private GradientPanel gradientPanelTitleBar;
        public System.Windows.Forms.Panel panelShadow;
        public GradientPanel gradientPanelDesktop;
        public System.Windows.Forms.NotifyIcon notifyIconDeadLine;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotify;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

