namespace DeadLineApp_v2._0
{
    partial class FormDeadLine
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
            this.timerDeadLine = new System.Windows.Forms.Timer(this.components);
            this.gradientPanelDeadLineCalender = new DeadLineApp_v2._0.GradientPanel();
            this.labelDeadlineEdit = new System.Windows.Forms.Label();
            this.textBoxDeadlineNameEdit = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateDeadLine = new System.Windows.Forms.DateTimePicker();
            this.comboBoxMinutesEdit = new System.Windows.Forms.ComboBox();
            this.comboBoxHoursEdit = new System.Windows.Forms.ComboBox();
            this.labelTIme = new System.Windows.Forms.Label();
            this.buttonEdit = new FontAwesome.Sharp.IconButton();
            this.buttonDelete = new FontAwesome.Sharp.IconButton();
            this.labelTimeEdit = new System.Windows.Forms.Label();
            this.labelDateEdit = new System.Windows.Forms.Label();
            this.labelNameEdit = new System.Windows.Forms.Label();
            this.labelEd = new System.Windows.Forms.Label();
            this.textBoxDateEdit = new System.Windows.Forms.TextBox();
            this.labelInfoStep = new System.Windows.Forms.Label();
            this.textBoxNameEdit = new System.Windows.Forms.TextBox();
            this.buttonWindowAdd = new FontAwesome.Sharp.IconButton();
            this.labelInfo = new System.Windows.Forms.Label();
            this.listBoxDeadLine = new System.Windows.Forms.ListBox();
            this.monthCalendarDeadLine = new System.Windows.Forms.MonthCalendar();
            this.timerProtect = new System.Windows.Forms.Timer(this.components);
            this.gradientPanelDeadLineCalender.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerDeadLine
            // 
            this.timerDeadLine.Tick += new System.EventHandler(this.timerDeadLine_Tick);
            // 
            // gradientPanelDeadLineCalender
            // 
            this.gradientPanelDeadLineCalender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientPanelDeadLineCalender.BackColor = System.Drawing.SystemColors.Control;
            this.gradientPanelDeadLineCalender.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.gradientPanelDeadLineCalender.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.gradientPanelDeadLineCalender.Controls.Add(this.labelDeadlineEdit);
            this.gradientPanelDeadLineCalender.Controls.Add(this.textBoxDeadlineNameEdit);
            this.gradientPanelDeadLineCalender.Controls.Add(this.dateTimePickerDateDeadLine);
            this.gradientPanelDeadLineCalender.Controls.Add(this.comboBoxMinutesEdit);
            this.gradientPanelDeadLineCalender.Controls.Add(this.comboBoxHoursEdit);
            this.gradientPanelDeadLineCalender.Controls.Add(this.labelTIme);
            this.gradientPanelDeadLineCalender.Controls.Add(this.buttonEdit);
            this.gradientPanelDeadLineCalender.Controls.Add(this.buttonDelete);
            this.gradientPanelDeadLineCalender.Controls.Add(this.labelTimeEdit);
            this.gradientPanelDeadLineCalender.Controls.Add(this.labelDateEdit);
            this.gradientPanelDeadLineCalender.Controls.Add(this.labelNameEdit);
            this.gradientPanelDeadLineCalender.Controls.Add(this.labelEd);
            this.gradientPanelDeadLineCalender.Controls.Add(this.textBoxDateEdit);
            this.gradientPanelDeadLineCalender.Controls.Add(this.labelInfoStep);
            this.gradientPanelDeadLineCalender.Controls.Add(this.textBoxNameEdit);
            this.gradientPanelDeadLineCalender.Controls.Add(this.buttonWindowAdd);
            this.gradientPanelDeadLineCalender.Controls.Add(this.labelInfo);
            this.gradientPanelDeadLineCalender.Controls.Add(this.listBoxDeadLine);
            this.gradientPanelDeadLineCalender.Controls.Add(this.monthCalendarDeadLine);
            this.gradientPanelDeadLineCalender.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelDeadLineCalender.Name = "gradientPanelDeadLineCalender";
            this.gradientPanelDeadLineCalender.Size = new System.Drawing.Size(979, 546);
            this.gradientPanelDeadLineCalender.TabIndex = 0;
            // 
            // labelDeadlineEdit
            // 
            this.labelDeadlineEdit.BackColor = System.Drawing.Color.Transparent;
            this.labelDeadlineEdit.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeadlineEdit.ForeColor = System.Drawing.Color.Snow;
            this.labelDeadlineEdit.Location = new System.Drawing.Point(729, 269);
            this.labelDeadlineEdit.Name = "labelDeadlineEdit";
            this.labelDeadlineEdit.Size = new System.Drawing.Size(228, 26);
            this.labelDeadlineEdit.TabIndex = 38;
            this.labelDeadlineEdit.Text = "ДЕДЛАЙН.";
            this.labelDeadlineEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxDeadlineNameEdit
            // 
            this.textBoxDeadlineNameEdit.Location = new System.Drawing.Point(734, 298);
            this.textBoxDeadlineNameEdit.Multiline = true;
            this.textBoxDeadlineNameEdit.Name = "textBoxDeadlineNameEdit";
            this.textBoxDeadlineNameEdit.ReadOnly = true;
            this.textBoxDeadlineNameEdit.Size = new System.Drawing.Size(222, 25);
            this.textBoxDeadlineNameEdit.TabIndex = 37;
            // 
            // dateTimePickerDateDeadLine
            // 
            this.dateTimePickerDateDeadLine.Location = new System.Drawing.Point(935, 399);
            this.dateTimePickerDateDeadLine.Name = "dateTimePickerDateDeadLine";
            this.dateTimePickerDateDeadLine.Size = new System.Drawing.Size(21, 22);
            this.dateTimePickerDateDeadLine.TabIndex = 18;
            this.dateTimePickerDateDeadLine.ValueChanged += new System.EventHandler(this.dateTimePickerDateDeadLine_ValueChanged);
            // 
            // comboBoxMinutesEdit
            // 
            this.comboBoxMinutesEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMinutesEdit.FormattingEnabled = true;
            this.comboBoxMinutesEdit.Location = new System.Drawing.Point(916, 433);
            this.comboBoxMinutesEdit.Name = "comboBoxMinutesEdit";
            this.comboBoxMinutesEdit.Size = new System.Drawing.Size(40, 21);
            this.comboBoxMinutesEdit.TabIndex = 36;
            // 
            // comboBoxHoursEdit
            // 
            this.comboBoxHoursEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHoursEdit.FormattingEnabled = true;
            this.comboBoxHoursEdit.Location = new System.Drawing.Point(849, 433);
            this.comboBoxHoursEdit.Name = "comboBoxHoursEdit";
            this.comboBoxHoursEdit.Size = new System.Drawing.Size(40, 21);
            this.comboBoxHoursEdit.TabIndex = 35;
            // 
            // labelTIme
            // 
            this.labelTIme.AutoSize = true;
            this.labelTIme.BackColor = System.Drawing.Color.Transparent;
            this.labelTIme.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTIme.ForeColor = System.Drawing.Color.Snow;
            this.labelTIme.Location = new System.Drawing.Point(3, 502);
            this.labelTIme.Name = "labelTIme";
            this.labelTIme.Size = new System.Drawing.Size(0, 28);
            this.labelTIme.TabIndex = 33;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Transparent;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.ForeColor = System.Drawing.Color.Red;
            this.buttonEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.buttonEdit.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonEdit.IconSize = 28;
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.Location = new System.Drawing.Point(734, 464);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonEdit.Rotation = 0D;
            this.buttonEdit.Size = new System.Drawing.Size(222, 32);
            this.buttonEdit.TabIndex = 32;
            this.buttonEdit.Text = "РЕДАКТИРОВАТЬ";
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click_1);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Transparent;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.Color.Red;
            this.buttonDelete.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.buttonDelete.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonDelete.IconSize = 40;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.Location = new System.Drawing.Point(734, 502);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonDelete.Rotation = 0D;
            this.buttonDelete.Size = new System.Drawing.Size(222, 40);
            this.buttonDelete.TabIndex = 31;
            this.buttonDelete.Text = "Удалить Этап";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click_1);
            // 
            // labelTimeEdit
            // 
            this.labelTimeEdit.BackColor = System.Drawing.Color.Transparent;
            this.labelTimeEdit.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTimeEdit.ForeColor = System.Drawing.Color.Snow;
            this.labelTimeEdit.Location = new System.Drawing.Point(766, 432);
            this.labelTimeEdit.Name = "labelTimeEdit";
            this.labelTimeEdit.Size = new System.Drawing.Size(77, 26);
            this.labelTimeEdit.TabIndex = 29;
            this.labelTimeEdit.Text = "ВРЕМЯ:";
            // 
            // labelDateEdit
            // 
            this.labelDateEdit.BackColor = System.Drawing.Color.Transparent;
            this.labelDateEdit.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateEdit.ForeColor = System.Drawing.Color.Snow;
            this.labelDateEdit.Location = new System.Drawing.Point(780, 402);
            this.labelDateEdit.Name = "labelDateEdit";
            this.labelDateEdit.Size = new System.Drawing.Size(63, 24);
            this.labelDateEdit.TabIndex = 28;
            this.labelDateEdit.Text = "ДАТА:";
            // 
            // labelNameEdit
            // 
            this.labelNameEdit.BackColor = System.Drawing.Color.Transparent;
            this.labelNameEdit.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameEdit.ForeColor = System.Drawing.Color.Snow;
            this.labelNameEdit.Location = new System.Drawing.Point(734, 326);
            this.labelNameEdit.Name = "labelNameEdit";
            this.labelNameEdit.Size = new System.Drawing.Size(228, 26);
            this.labelNameEdit.TabIndex = 27;
            this.labelNameEdit.Text = "НАЗВАНИЕ ЭТАПА.";
            // 
            // labelEd
            // 
            this.labelEd.AutoSize = true;
            this.labelEd.BackColor = System.Drawing.Color.Transparent;
            this.labelEd.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEd.ForeColor = System.Drawing.Color.Snow;
            this.labelEd.Location = new System.Drawing.Point(895, 429);
            this.labelEd.Name = "labelEd";
            this.labelEd.Size = new System.Drawing.Size(18, 26);
            this.labelEd.TabIndex = 26;
            this.labelEd.Text = ":";
            // 
            // textBoxDateEdit
            // 
            this.textBoxDateEdit.Location = new System.Drawing.Point(849, 399);
            this.textBoxDateEdit.Multiline = true;
            this.textBoxDateEdit.Name = "textBoxDateEdit";
            this.textBoxDateEdit.ReadOnly = true;
            this.textBoxDateEdit.Size = new System.Drawing.Size(80, 22);
            this.textBoxDateEdit.TabIndex = 23;
            // 
            // labelInfoStep
            // 
            this.labelInfoStep.BackColor = System.Drawing.Color.Transparent;
            this.labelInfoStep.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfoStep.ForeColor = System.Drawing.Color.Snow;
            this.labelInfoStep.Location = new System.Drawing.Point(729, 241);
            this.labelInfoStep.Name = "labelInfoStep";
            this.labelInfoStep.Size = new System.Drawing.Size(264, 28);
            this.labelInfoStep.TabIndex = 22;
            this.labelInfoStep.Text = "Информация об Этапе.";
            // 
            // textBoxNameEdit
            // 
            this.textBoxNameEdit.Location = new System.Drawing.Point(734, 355);
            this.textBoxNameEdit.Multiline = true;
            this.textBoxNameEdit.Name = "textBoxNameEdit";
            this.textBoxNameEdit.ReadOnly = true;
            this.textBoxNameEdit.Size = new System.Drawing.Size(222, 38);
            this.textBoxNameEdit.TabIndex = 20;
            // 
            // buttonWindowAdd
            // 
            this.buttonWindowAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonWindowAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWindowAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonWindowAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonWindowAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonWindowAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.buttonWindowAdd.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonWindowAdd.IconSize = 40;
            this.buttonWindowAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonWindowAdd.Location = new System.Drawing.Point(526, 483);
            this.buttonWindowAdd.Name = "buttonWindowAdd";
            this.buttonWindowAdd.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonWindowAdd.Rotation = 0D;
            this.buttonWindowAdd.Size = new System.Drawing.Size(202, 60);
            this.buttonWindowAdd.TabIndex = 7;
            this.buttonWindowAdd.Text = "Открыть Окно Добавления Этапа";
            this.buttonWindowAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonWindowAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonWindowAdd.UseVisualStyleBackColor = false;
            this.buttonWindowAdd.Click += new System.EventHandler(this.buttonWindowAdd_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelInfo.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.ForeColor = System.Drawing.Color.Snow;
            this.labelInfo.Location = new System.Drawing.Point(528, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(195, 29);
            this.labelInfo.TabIndex = 6;
            this.labelInfo.Text = "Этапы дедлайна.";
            // 
            // listBoxDeadLine
            // 
            this.listBoxDeadLine.BackColor = System.Drawing.Color.Snow;
            this.listBoxDeadLine.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxDeadLine.FormattingEnabled = true;
            this.listBoxDeadLine.ItemHeight = 23;
            this.listBoxDeadLine.Location = new System.Drawing.Point(526, 37);
            this.listBoxDeadLine.Name = "listBoxDeadLine";
            this.listBoxDeadLine.Size = new System.Drawing.Size(202, 441);
            this.listBoxDeadLine.TabIndex = 5;
            this.listBoxDeadLine.SelectedIndexChanged += new System.EventHandler(this.listBoxDeadLine_SelectedIndexChanged);
            // 
            // monthCalendarDeadLine
            // 
            this.monthCalendarDeadLine.BackColor = System.Drawing.Color.Snow;
            this.monthCalendarDeadLine.CalendarDimensions = new System.Drawing.Size(3, 3);
            this.monthCalendarDeadLine.Location = new System.Drawing.Point(0, 18);
            this.monthCalendarDeadLine.Name = "monthCalendarDeadLine";
            this.monthCalendarDeadLine.TabIndex = 0;
            // 
            // timerProtect
            // 
            this.timerProtect.Interval = 300000;
            this.timerProtect.Tick += new System.EventHandler(this.timerAlert_Tick);
            // 
            // FormDeadLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 546);
            this.Controls.Add(this.gradientPanelDeadLineCalender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormDeadLine";
            this.Text = "FormDeadLineCalender";
            this.Load += new System.EventHandler(this.FormDeadLine_Load);
            this.gradientPanelDeadLineCalender.ResumeLayout(false);
            this.gradientPanelDeadLineCalender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanelDeadLineCalender;
        private System.Windows.Forms.Label labelInfo;
        public System.Windows.Forms.ListBox listBoxDeadLine;
        private System.Windows.Forms.Label labelTimeEdit;
        private System.Windows.Forms.Label labelDateEdit;
        private System.Windows.Forms.Label labelNameEdit;
        private System.Windows.Forms.Label labelEd;
        private System.Windows.Forms.TextBox textBoxDateEdit;
        private System.Windows.Forms.Label labelInfoStep;
        private System.Windows.Forms.TextBox textBoxNameEdit;
        private FontAwesome.Sharp.IconButton buttonDelete;
        private FontAwesome.Sharp.IconButton buttonEdit;
        private System.Windows.Forms.Timer timerDeadLine;
        public System.Windows.Forms.MonthCalendar monthCalendarDeadLine;
        public FontAwesome.Sharp.IconButton buttonWindowAdd;
        public System.Windows.Forms.ComboBox comboBoxMinutesEdit;
        public System.Windows.Forms.ComboBox comboBoxHoursEdit;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateDeadLine;
        private System.Windows.Forms.Timer timerProtect;
        public System.Windows.Forms.Label labelTIme;
        private System.Windows.Forms.Label labelDeadlineEdit;
        private System.Windows.Forms.TextBox textBoxDeadlineNameEdit;
    }
}