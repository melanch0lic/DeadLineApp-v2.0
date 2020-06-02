namespace DeadLineApp_v2._0
{
    partial class FormOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOptions));
            this.gradientPanel1 = new DeadLineApp_v2._0.GradientPanel();
            this.comboBoxAlert = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.radioButtonTurnOff = new System.Windows.Forms.RadioButton();
            this.radioButtonTurnOn = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(59)))), ((int)(((byte)(85)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.gradientPanel1.Controls.Add(this.comboBoxAlert);
            this.gradientPanel1.Controls.Add(this.button1);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.labelInfo);
            this.gradientPanel1.Controls.Add(this.radioButtonTurnOff);
            this.gradientPanel1.Controls.Add(this.radioButtonTurnOn);
            this.gradientPanel1.Controls.Add(this.pictureBox1);
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(979, 546);
            this.gradientPanel1.TabIndex = 0;
            // 
            // comboBoxAlert
            // 
            this.comboBoxAlert.BackColor = System.Drawing.Color.Snow;
            this.comboBoxAlert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAlert.FormattingEnabled = true;
            this.comboBoxAlert.Location = new System.Drawing.Point(62, 210);
            this.comboBoxAlert.Name = "comboBoxAlert";
            this.comboBoxAlert.Size = new System.Drawing.Size(136, 21);
            this.comboBoxAlert.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(62, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Потвердить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(57, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Напоминание об Дедлайне.";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelInfo.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.ForeColor = System.Drawing.Color.Snow;
            this.labelInfo.Location = new System.Drawing.Point(78, 41);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(165, 29);
            this.labelInfo.TabIndex = 14;
            this.labelInfo.Text = "Уведомления.";
            // 
            // radioButtonTurnOff
            // 
            this.radioButtonTurnOff.AutoSize = true;
            this.radioButtonTurnOff.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonTurnOff.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonTurnOff.ForeColor = System.Drawing.Color.Snow;
            this.radioButtonTurnOff.Location = new System.Drawing.Point(62, 108);
            this.radioButtonTurnOff.Name = "radioButtonTurnOff";
            this.radioButtonTurnOff.Size = new System.Drawing.Size(393, 29);
            this.radioButtonTurnOff.TabIndex = 13;
            this.radioButtonTurnOff.TabStop = true;
            this.radioButtonTurnOff.Text = "Выключить звуковые уведомления";
            this.radioButtonTurnOff.UseVisualStyleBackColor = false;
            this.radioButtonTurnOff.Click += new System.EventHandler(this.radioButtonTurnOff_Click);
            // 
            // radioButtonTurnOn
            // 
            this.radioButtonTurnOn.AutoSize = true;
            this.radioButtonTurnOn.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonTurnOn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonTurnOn.ForeColor = System.Drawing.Color.Snow;
            this.radioButtonTurnOn.Location = new System.Drawing.Point(62, 73);
            this.radioButtonTurnOn.Name = "radioButtonTurnOn";
            this.radioButtonTurnOn.Size = new System.Drawing.Size(377, 29);
            this.radioButtonTurnOn.TabIndex = 12;
            this.radioButtonTurnOn.TabStop = true;
            this.radioButtonTurnOn.Text = "Включить звуковые уведомления";
            this.radioButtonTurnOn.UseVisualStyleBackColor = false;
            this.radioButtonTurnOn.Click += new System.EventHandler(this.radioButtonTurnOn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(176, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(979, 546);
            this.Controls.Add(this.gradientPanel1);
            this.Name = "FormOptions";
            this.Text = "FormOptions";
            this.Load += new System.EventHandler(this.FormOptions_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.RadioButton radioButtonTurnOff;
        private System.Windows.Forms.RadioButton radioButtonTurnOn;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ComboBox comboBoxAlert;
    }
}