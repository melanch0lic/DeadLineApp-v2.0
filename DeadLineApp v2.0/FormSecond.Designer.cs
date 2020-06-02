namespace DeadLineApp_v2._0
{
    partial class FormSecond
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSecond));
            this.gradientPanelSecond = new DeadLineApp_v2._0.GradientPanel();
            this.labelDeadline = new System.Windows.Forms.Label();
            this.textBoxDeadlineName = new System.Windows.Forms.TextBox();
            this.comboBoxMinutes = new System.Windows.Forms.ComboBox();
            this.comboBoxHours = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNameOfStep = new System.Windows.Forms.TextBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAdvice = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.gradientPanelSecond.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanelSecond
            // 
            this.gradientPanelSecond.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.gradientPanelSecond.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.gradientPanelSecond.Controls.Add(this.labelDeadline);
            this.gradientPanelSecond.Controls.Add(this.textBoxDeadlineName);
            this.gradientPanelSecond.Controls.Add(this.comboBoxMinutes);
            this.gradientPanelSecond.Controls.Add(this.comboBoxHours);
            this.gradientPanelSecond.Controls.Add(this.buttonAdd);
            this.gradientPanelSecond.Controls.Add(this.label3);
            this.gradientPanelSecond.Controls.Add(this.textBoxNameOfStep);
            this.gradientPanelSecond.Controls.Add(this.dateTimePickerDate);
            this.gradientPanelSecond.Controls.Add(this.label2);
            this.gradientPanelSecond.Controls.Add(this.label1);
            this.gradientPanelSecond.Controls.Add(this.labelAdvice);
            this.gradientPanelSecond.Controls.Add(this.textBoxDate);
            this.gradientPanelSecond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanelSecond.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelSecond.Name = "gradientPanelSecond";
            this.gradientPanelSecond.Size = new System.Drawing.Size(434, 269);
            this.gradientPanelSecond.TabIndex = 0;
            // 
            // labelDeadline
            // 
            this.labelDeadline.BackColor = System.Drawing.Color.Transparent;
            this.labelDeadline.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeadline.ForeColor = System.Drawing.Color.Snow;
            this.labelDeadline.Location = new System.Drawing.Point(99, 35);
            this.labelDeadline.Name = "labelDeadline";
            this.labelDeadline.Size = new System.Drawing.Size(112, 35);
            this.labelDeadline.TabIndex = 24;
            this.labelDeadline.Text = "Дедлайн:";
            // 
            // textBoxDeadlineName
            // 
            this.textBoxDeadlineName.Location = new System.Drawing.Point(217, 35);
            this.textBoxDeadlineName.Multiline = true;
            this.textBoxDeadlineName.Name = "textBoxDeadlineName";
            this.textBoxDeadlineName.Size = new System.Drawing.Size(120, 35);
            this.textBoxDeadlineName.TabIndex = 23;
            // 
            // comboBoxMinutes
            // 
            this.comboBoxMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMinutes.FormattingEnabled = true;
            this.comboBoxMinutes.Location = new System.Drawing.Point(285, 172);
            this.comboBoxMinutes.Name = "comboBoxMinutes";
            this.comboBoxMinutes.Size = new System.Drawing.Size(40, 21);
            this.comboBoxMinutes.TabIndex = 22;
            // 
            // comboBoxHours
            // 
            this.comboBoxHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHours.FormattingEnabled = true;
            this.comboBoxHours.Location = new System.Drawing.Point(218, 172);
            this.comboBoxHours.Name = "comboBoxHours";
            this.comboBoxHours.Size = new System.Drawing.Size(40, 21);
            this.comboBoxHours.TabIndex = 21;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonAdd.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.buttonAdd.IconColor = System.Drawing.Color.Gainsboro;
            this.buttonAdd.IconSize = 40;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(107, 206);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.buttonAdd.Rotation = 0D;
            this.buttonAdd.Size = new System.Drawing.Size(211, 51);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.Text = " Добавить Этап";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(83, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 43);
            this.label3.TabIndex = 19;
            this.label3.Text = "Название этапа Дедлайна:";
            // 
            // textBoxNameOfStep
            // 
            this.textBoxNameOfStep.Location = new System.Drawing.Point(217, 76);
            this.textBoxNameOfStep.Multiline = true;
            this.textBoxNameOfStep.Name = "textBoxNameOfStep";
            this.textBoxNameOfStep.Size = new System.Drawing.Size(120, 43);
            this.textBoxNameOfStep.TabIndex = 18;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(310, 143);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(21, 22);
            this.dateTimePickerDate.TabIndex = 17;
            this.dateTimePickerDate.ValueChanged += new System.EventHandler(this.dateTimePickerDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(264, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(92, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Время Дедлайна:";
            // 
            // labelAdvice
            // 
            this.labelAdvice.BackColor = System.Drawing.Color.Transparent;
            this.labelAdvice.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdvice.ForeColor = System.Drawing.Color.Snow;
            this.labelAdvice.Location = new System.Drawing.Point(83, 143);
            this.labelAdvice.Name = "labelAdvice";
            this.labelAdvice.Size = new System.Drawing.Size(128, 26);
            this.labelAdvice.TabIndex = 12;
            this.labelAdvice.Text = "Дата Дедлайна:";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(217, 143);
            this.textBoxDate.Multiline = true;
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.ReadOnly = true;
            this.textBoxDate.Size = new System.Drawing.Size(87, 22);
            this.textBoxDate.TabIndex = 11;
            // 
            // FormSecond
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 269);
            this.Controls.Add(this.gradientPanelSecond);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSecond";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление Этапа Дедлайна.";
            this.Load += new System.EventHandler(this.FormSecond_Load);
            this.gradientPanelSecond.ResumeLayout(false);
            this.gradientPanelSecond.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanelSecond;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxNameOfStep;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAdvice;
        public System.Windows.Forms.TextBox textBoxDate;
        public FontAwesome.Sharp.IconButton buttonAdd;
        public System.Windows.Forms.ComboBox comboBoxMinutes;
        public System.Windows.Forms.ComboBox comboBoxHours;
        private System.Windows.Forms.Label labelDeadline;
        public System.Windows.Forms.TextBox textBoxDeadlineName;
    }
}