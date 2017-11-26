namespace HMIInterface1
{
    partial class FormSetting
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
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.textBoxProductionLine = new System.Windows.Forms.TextBox();
            this.textBoxComPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxShowDestinationOrderCode = new System.Windows.Forms.CheckBox();
            this.checkBoxShowContainer = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(685, 173);
            this.textBoxIP.Multiline = true;
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(165, 44);
            this.textBoxIP.TabIndex = 2;
            // 
            // textBoxProductionLine
            // 
            this.textBoxProductionLine.Location = new System.Drawing.Point(685, 223);
            this.textBoxProductionLine.Multiline = true;
            this.textBoxProductionLine.Name = "textBoxProductionLine";
            this.textBoxProductionLine.Size = new System.Drawing.Size(165, 44);
            this.textBoxProductionLine.TabIndex = 3;
            // 
            // textBoxComPort
            // 
            this.textBoxComPort.Location = new System.Drawing.Point(685, 273);
            this.textBoxComPort.Multiline = true;
            this.textBoxComPort.Name = "textBoxComPort";
            this.textBoxComPort.Size = new System.Drawing.Size(165, 44);
            this.textBoxComPort.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(854, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = ": IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(854, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = ": کد خط";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(855, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = ": Com Port";
            // 
            // checkBoxShowDestinationOrderCode
            // 
            this.checkBoxShowDestinationOrderCode.AutoSize = true;
            this.checkBoxShowDestinationOrderCode.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxShowDestinationOrderCode.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.checkBoxShowDestinationOrderCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxShowDestinationOrderCode.Location = new System.Drawing.Point(425, 230);
            this.checkBoxShowDestinationOrderCode.Name = "checkBoxShowDestinationOrderCode";
            this.checkBoxShowDestinationOrderCode.Size = new System.Drawing.Size(202, 33);
            this.checkBoxShowDestinationOrderCode.TabIndex = 8;
            this.checkBoxShowDestinationOrderCode.Text = "نمایش شماره سفارش مقصد";
            this.checkBoxShowDestinationOrderCode.UseVisualStyleBackColor = false;
            // 
            // checkBoxShowContainer
            // 
            this.checkBoxShowContainer.AutoSize = true;
            this.checkBoxShowContainer.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxShowContainer.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.checkBoxShowContainer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxShowContainer.Location = new System.Drawing.Point(425, 175);
            this.checkBoxShowContainer.Name = "checkBoxShowContainer";
            this.checkBoxShowContainer.Size = new System.Drawing.Size(108, 33);
            this.checkBoxShowContainer.TabIndex = 9;
            this.checkBoxShowContainer.Text = "نمایش گاری";
            this.checkBoxShowContainer.UseVisualStyleBackColor = false;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.buttonSave.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonSave.Location = new System.Drawing.Point(858, 427);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(131, 67);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "ذخیره";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.Location = new System.Drawing.Point(298, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 67);
            this.button1.TabIndex = 11;
            this.button1.Text = "برگشت";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 740);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.checkBoxShowContainer);
            this.Controls.Add(this.checkBoxShowDestinationOrderCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxComPort);
            this.Controls.Add(this.textBoxProductionLine);
            this.Controls.Add(this.textBoxIP);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSetting";
            this.Text = "FormSetting";
            this.Load += new System.EventHandler(this.FormSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.TextBox textBoxProductionLine;
        private System.Windows.Forms.TextBox textBoxComPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxShowDestinationOrderCode;
        private System.Windows.Forms.CheckBox checkBoxShowContainer;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button button1;
    }
}