namespace HMIInterface1
{
    partial class FormGetMaterials
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGetMaterials));
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFocus = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.listBoxSerial = new System.Windows.Forms.ListBox();
            this.textBoxSerialEdit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSerialView = new System.Windows.Forms.TextBox();
            this.pictureBoxNext = new System.Windows.Forms.PictureBox();
            this.textBoxDestinationOrdeCodeView = new System.Windows.Forms.TextBox();
            this.listBoxDestinationOrdeCode = new System.Windows.Forms.ListBox();
            this.textBoDestinationOrderCodeEdit = new System.Windows.Forms.TextBox();
            this.panelManual = new System.Windows.Forms.Panel();
            this.listBoxPartCode = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPartName = new System.Windows.Forms.TextBox();
            this.textBoxFromOrder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxPartCodeEdit = new System.Windows.Forms.TextBox();
            this.textBoxAmount1 = new System.Windows.Forms.TextBox();
            this.labelPartCode = new System.Windows.Forms.Label();
            this.LableWeight = new System.Windows.Forms.Label();
            this.labelAmount1 = new System.Windows.Forms.Label();
            this.textBoxPartCodeView = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxManual = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).BeginInit();
            this.panelManual.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(483, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 32);
            this.label7.TabIndex = 83;
            this.label7.Text = "ثبت/ ورود مواد اولیه یا کامپاند";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(1, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1281, 11);
            this.label3.TabIndex = 82;
            // 
            // textBoxFocus
            // 
            this.textBoxFocus.Location = new System.Drawing.Point(24, 22);
            this.textBoxFocus.Name = "textBoxFocus";
            this.textBoxFocus.Size = new System.Drawing.Size(10, 20);
            this.textBoxFocus.TabIndex = 81;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Yellow;
            this.buttonBack.Location = new System.Drawing.Point(12, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(81, 29);
            this.buttonBack.TabIndex = 84;
            this.buttonBack.Text = "برگشت";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // listBoxSerial
            // 
            this.listBoxSerial.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSerial.FormattingEnabled = true;
            this.listBoxSerial.ItemHeight = 18;
            this.listBoxSerial.Location = new System.Drawing.Point(49, 157);
            this.listBoxSerial.Name = "listBoxSerial";
            this.listBoxSerial.Size = new System.Drawing.Size(176, 148);
            this.listBoxSerial.TabIndex = 86;
            this.listBoxSerial.Visible = false;
            this.listBoxSerial.Click += new System.EventHandler(this.listBoxSerial_Click);
            this.listBoxSerial.SelectedIndexChanged += new System.EventHandler(this.listBoxSerial_SelectedIndexChanged);
            this.listBoxSerial.LostFocus += new System.EventHandler(this.listBoxSerial_LostFocus);
            // 
            // textBoxSerialEdit
            // 
            this.textBoxSerialEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxSerialEdit.Location = new System.Drawing.Point(49, 125);
            this.textBoxSerialEdit.MaxLength = 6;
            this.textBoxSerialEdit.Name = "textBoxSerialEdit";
            this.textBoxSerialEdit.Size = new System.Drawing.Size(176, 30);
            this.textBoxSerialEdit.TabIndex = 85;
            this.textBoxSerialEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSerialEdit.Visible = false;
            this.textBoxSerialEdit.TextChanged += new System.EventHandler(this.textBoxSerialEdit_TextChanged);
            this.textBoxSerialEdit.LostFocus += new System.EventHandler(this.textBoxSerialEdit_LostFocus);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(104, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 26);
            this.label8.TabIndex = 87;
            this.label8.Text = "سریال";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBoxSerialView
            // 
            this.textBoxSerialView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxSerialView.Location = new System.Drawing.Point(49, 125);
            this.textBoxSerialView.Name = "textBoxSerialView";
            this.textBoxSerialView.ReadOnly = true;
            this.textBoxSerialView.Size = new System.Drawing.Size(176, 30);
            this.textBoxSerialView.TabIndex = 88;
            this.textBoxSerialView.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSerialView.TextChanged += new System.EventHandler(this.textBoxSerialView_TextChanged);
            this.textBoxSerialView.GotFocus += new System.EventHandler(this.textBoxSerialView_GotFocus);
            // 
            // pictureBoxNext
            // 
            this.pictureBoxNext.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNext.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNext.Image")));
            this.pictureBoxNext.Location = new System.Drawing.Point(886, 384);
            this.pictureBoxNext.Name = "pictureBoxNext";
            this.pictureBoxNext.Size = new System.Drawing.Size(178, 136);
            this.pictureBoxNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNext.TabIndex = 90;
            this.pictureBoxNext.TabStop = false;
            this.pictureBoxNext.Click += new System.EventHandler(this.pictureBoxNext_Click);
            // 
            // textBoxDestinationOrdeCodeView
            // 
            this.textBoxDestinationOrdeCodeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxDestinationOrdeCodeView.Location = new System.Drawing.Point(259, 126);
            this.textBoxDestinationOrdeCodeView.Name = "textBoxDestinationOrdeCodeView";
            this.textBoxDestinationOrdeCodeView.ReadOnly = true;
            this.textBoxDestinationOrdeCodeView.Size = new System.Drawing.Size(213, 30);
            this.textBoxDestinationOrdeCodeView.TabIndex = 97;
            this.textBoxDestinationOrdeCodeView.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDestinationOrdeCodeView.GotFocus += new System.EventHandler(this.textBoxDestinationOrdeCodeView_GotFocus);
            // 
            // listBoxDestinationOrdeCode
            // 
            this.listBoxDestinationOrdeCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.listBoxDestinationOrdeCode.FormattingEnabled = true;
            this.listBoxDestinationOrdeCode.ItemHeight = 20;
            this.listBoxDestinationOrdeCode.Location = new System.Drawing.Point(259, 160);
            this.listBoxDestinationOrdeCode.Name = "listBoxDestinationOrdeCode";
            this.listBoxDestinationOrdeCode.Size = new System.Drawing.Size(213, 144);
            this.listBoxDestinationOrdeCode.TabIndex = 100;
            this.listBoxDestinationOrdeCode.Visible = false;
            this.listBoxDestinationOrdeCode.Click += new System.EventHandler(this.listBoxDestinationOrdeCode_Click);
            this.listBoxDestinationOrdeCode.SelectedIndexChanged += new System.EventHandler(this.listBoxDestinationOrdeCode_SelectedIndexChanged);
            this.listBoxDestinationOrdeCode.LostFocus += new System.EventHandler(this.listBoxDestinationOrdeCode_LostFocus);
            // 
            // textBoDestinationOrderCodeEdit
            // 
            this.textBoDestinationOrderCodeEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoDestinationOrderCodeEdit.Location = new System.Drawing.Point(260, 126);
            this.textBoDestinationOrderCodeEdit.Name = "textBoDestinationOrderCodeEdit";
            this.textBoDestinationOrderCodeEdit.Size = new System.Drawing.Size(212, 30);
            this.textBoDestinationOrderCodeEdit.TabIndex = 101;
            this.textBoDestinationOrderCodeEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoDestinationOrderCodeEdit.Visible = false;
            this.textBoDestinationOrderCodeEdit.TextChanged += new System.EventHandler(this.textBoDestinationOrderCodeEdit_TextChanged);
            this.textBoDestinationOrderCodeEdit.LostFocus += new System.EventHandler(this.textBoDestinationOrderCodeEdit_LostFocus);
            // 
            // panelManual
            // 
            this.panelManual.BackColor = System.Drawing.Color.Transparent;
            this.panelManual.Controls.Add(this.listBoxPartCode);
            this.panelManual.Controls.Add(this.label5);
            this.panelManual.Controls.Add(this.textBoxPartName);
            this.panelManual.Controls.Add(this.textBoxFromOrder);
            this.panelManual.Controls.Add(this.label1);
            this.panelManual.Controls.Add(this.textBoxWeight);
            this.panelManual.Controls.Add(this.textBoxPartCodeEdit);
            this.panelManual.Controls.Add(this.textBoxAmount1);
            this.panelManual.Controls.Add(this.labelPartCode);
            this.panelManual.Controls.Add(this.LableWeight);
            this.panelManual.Controls.Add(this.labelAmount1);
            this.panelManual.Controls.Add(this.textBoxPartCodeView);
            this.panelManual.Location = new System.Drawing.Point(642, 120);
            this.panelManual.Name = "panelManual";
            this.panelManual.Size = new System.Drawing.Size(436, 227);
            this.panelManual.TabIndex = 105;
            // 
            // listBoxPartCode
            // 
            this.listBoxPartCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.listBoxPartCode.FormattingEnabled = true;
            this.listBoxPartCode.ItemHeight = 20;
            this.listBoxPartCode.Location = new System.Drawing.Point(14, 109);
            this.listBoxPartCode.Name = "listBoxPartCode";
            this.listBoxPartCode.Size = new System.Drawing.Size(287, 104);
            this.listBoxPartCode.TabIndex = 113;
            this.listBoxPartCode.Visible = false;
            this.listBoxPartCode.Click += new System.EventHandler(this.listBoxPartCode_Click);
            this.listBoxPartCode.LostFocus += new System.EventHandler(this.listBoxPartCode_LostFocus);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(334, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 24);
            this.label5.TabIndex = 114;
            this.label5.Text = "نام کالا";
            // 
            // textBoxPartName
            // 
            this.textBoxPartName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxPartName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxPartName.Location = new System.Drawing.Point(14, 76);
            this.textBoxPartName.Name = "textBoxPartName";
            this.textBoxPartName.ReadOnly = true;
            this.textBoxPartName.Size = new System.Drawing.Size(287, 30);
            this.textBoxPartName.TabIndex = 116;
            this.textBoxPartName.TextChanged += new System.EventHandler(this.textBoxPartName_TextChanged);
            // 
            // textBoxFromOrder
            // 
            this.textBoxFromOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxFromOrder.Location = new System.Drawing.Point(14, 6);
            this.textBoxFromOrder.Name = "textBoxFromOrder";
            this.textBoxFromOrder.ReadOnly = true;
            this.textBoxFromOrder.Size = new System.Drawing.Size(287, 30);
            this.textBoxFromOrder.TabIndex = 111;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(334, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 110;
            this.label1.Text = "از سفارش";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxWeight.Location = new System.Drawing.Point(14, 111);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.ReadOnly = true;
            this.textBoxWeight.Size = new System.Drawing.Size(287, 30);
            this.textBoxWeight.TabIndex = 107;
            // 
            // textBoxPartCodeEdit
            // 
            this.textBoxPartCodeEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxPartCodeEdit.Location = new System.Drawing.Point(14, 42);
            this.textBoxPartCodeEdit.Name = "textBoxPartCodeEdit";
            this.textBoxPartCodeEdit.ReadOnly = true;
            this.textBoxPartCodeEdit.Size = new System.Drawing.Size(287, 30);
            this.textBoxPartCodeEdit.TabIndex = 108;
            this.textBoxPartCodeEdit.Visible = false;
            this.textBoxPartCodeEdit.TextChanged += new System.EventHandler(this.textBoxPartCodeEdit_TextChanged);
            this.textBoxPartCodeEdit.LostFocus += new System.EventHandler(this.textBoxPartCodeEdit_LostFocus);
            // 
            // textBoxAmount1
            // 
            this.textBoxAmount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxAmount1.Location = new System.Drawing.Point(14, 147);
            this.textBoxAmount1.Name = "textBoxAmount1";
            this.textBoxAmount1.ReadOnly = true;
            this.textBoxAmount1.Size = new System.Drawing.Size(287, 30);
            this.textBoxAmount1.TabIndex = 109;
            // 
            // labelPartCode
            // 
            this.labelPartCode.AutoSize = true;
            this.labelPartCode.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelPartCode.Location = new System.Drawing.Point(334, 48);
            this.labelPartCode.Name = "labelPartCode";
            this.labelPartCode.Size = new System.Drawing.Size(45, 24);
            this.labelPartCode.TabIndex = 106;
            this.labelPartCode.Text = "کد کالا";
            // 
            // LableWeight
            // 
            this.LableWeight.AutoSize = true;
            this.LableWeight.Font = new System.Drawing.Font("B Nazanin", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LableWeight.Location = new System.Drawing.Point(334, 112);
            this.LableWeight.Name = "LableWeight";
            this.LableWeight.Size = new System.Drawing.Size(31, 24);
            this.LableWeight.TabIndex = 105;
            this.LableWeight.Text = "وزن";
            // 
            // labelAmount1
            // 
            this.labelAmount1.AutoSize = true;
            this.labelAmount1.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelAmount1.Location = new System.Drawing.Point(325, 145);
            this.labelAmount1.Name = "labelAmount1";
            this.labelAmount1.Size = new System.Drawing.Size(97, 23);
            this.labelAmount1.TabIndex = 104;
            this.labelAmount1.Text = "مقدار به واحد دوم";
            // 
            // textBoxPartCodeView
            // 
            this.textBoxPartCodeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxPartCodeView.Location = new System.Drawing.Point(14, 42);
            this.textBoxPartCodeView.Name = "textBoxPartCodeView";
            this.textBoxPartCodeView.ReadOnly = true;
            this.textBoxPartCodeView.Size = new System.Drawing.Size(287, 30);
            this.textBoxPartCodeView.TabIndex = 112;
            this.textBoxPartCodeView.GotFocus += new System.EventHandler(this.textBoxPartCodeView_GotFocus);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(302, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 26);
            this.label2.TabIndex = 106;
            this.label2.Text = "شماره سفارش مقصد";
            // 
            // checkBoxManual
            // 
            this.checkBoxManual.AutoSize = true;
            this.checkBoxManual.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxManual.Font = new System.Drawing.Font("B Nazanin", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.checkBoxManual.Location = new System.Drawing.Point(873, 84);
            this.checkBoxManual.Name = "checkBoxManual";
            this.checkBoxManual.Size = new System.Drawing.Size(214, 33);
            this.checkBoxManual.TabIndex = 108;
            this.checkBoxManual.Text = "ثبت اطلاعات به صورت دستی";
            this.checkBoxManual.UseVisualStyleBackColor = false;
            this.checkBoxManual.CheckedChanged += new System.EventHandler(this.checkBoxManual_CheckedChanged);
            // 
            // FormGetMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 740);
            this.Controls.Add(this.textBoDestinationOrderCodeEdit);
            this.Controls.Add(this.textBoxSerialEdit);
            this.Controls.Add(this.checkBoxManual);
            this.Controls.Add(this.textBoxDestinationOrdeCodeView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelManual);
            this.Controls.Add(this.listBoxDestinationOrdeCode);
            this.Controls.Add(this.pictureBoxNext);
            this.Controls.Add(this.listBoxSerial);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxSerialView);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFocus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGetMaterials";
            this.Text = "FormGetMaterials";
            this.Load += new System.EventHandler(this.FormGetMaterials_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).EndInit();
            this.panelManual.ResumeLayout(false);
            this.panelManual.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFocus;
        private System.Windows.Forms.ListBox listBoxSerial;
        private System.Windows.Forms.TextBox textBoxSerialEdit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSerialView;
        private System.Windows.Forms.PictureBox pictureBoxNext;
        private System.Windows.Forms.TextBox textBoxDestinationOrdeCodeView;
        private System.Windows.Forms.ListBox listBoxDestinationOrdeCode;
        private System.Windows.Forms.TextBox textBoDestinationOrderCodeEdit;
        private System.Windows.Forms.Panel panelManual;
        private System.Windows.Forms.TextBox textBoxFromOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxPartCodeEdit;
        private System.Windows.Forms.TextBox textBoxAmount1;
        private System.Windows.Forms.Label labelPartCode;
        private System.Windows.Forms.Label LableWeight;
        private System.Windows.Forms.Label labelAmount1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxManual;
        private System.Windows.Forms.TextBox textBoxPartCodeView;
        private System.Windows.Forms.ListBox listBoxPartCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPartName;
    }
}