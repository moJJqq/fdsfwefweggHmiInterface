namespace HMIInterface1
{
    partial class FormWaste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWaste));
            this.textBoxLesionTypeEdit = new System.Windows.Forms.TextBox();
            this.textBoxPartWasteCodeEdit = new System.Windows.Forms.TextBox();
            this.textBoxPartWasteCodeView = new System.Windows.Forms.TextBox();
            this.textBoxLesionView = new System.Windows.Forms.TextBox();
            this.listBoxLesionType = new System.Windows.Forms.ListBox();
            this.listBoxPartWasteCode = new System.Windows.Forms.ListBox();
            this.textBoxFocus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPartName = new System.Windows.Forms.TextBox();
            this.textBoxOrderCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPartCode = new System.Windows.Forms.TextBox();
            this.buttonLesionClear = new System.Windows.Forms.Button();
            this.buttonPartWasteCodeClear = new System.Windows.Forms.Button();
            this.pictureBoxNext = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLesionTypeEdit
            // 
            this.textBoxLesionTypeEdit.Font = new System.Drawing.Font("B Nazanin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxLesionTypeEdit.Location = new System.Drawing.Point(528, 277);
            this.textBoxLesionTypeEdit.Name = "textBoxLesionTypeEdit";
            this.textBoxLesionTypeEdit.Size = new System.Drawing.Size(515, 48);
            this.textBoxLesionTypeEdit.TabIndex = 0;
            this.textBoxLesionTypeEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxLesionTypeEdit.Visible = false;
            this.textBoxLesionTypeEdit.TextChanged += new System.EventHandler(this.textBoxLesionTypeEdit_TextChanged);
            this.textBoxLesionTypeEdit.GotFocus += new System.EventHandler(this.textBoxLesionTypeEdit_GotFocus);
            this.textBoxLesionTypeEdit.LostFocus += new System.EventHandler(this.textBoxLesionTypeEdit_LostFocus);
            // 
            // textBoxPartWasteCodeEdit
            // 
            this.textBoxPartWasteCodeEdit.Font = new System.Drawing.Font("B Nazanin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxPartWasteCodeEdit.Location = new System.Drawing.Point(528, 334);
            this.textBoxPartWasteCodeEdit.Name = "textBoxPartWasteCodeEdit";
            this.textBoxPartWasteCodeEdit.Size = new System.Drawing.Size(515, 48);
            this.textBoxPartWasteCodeEdit.TabIndex = 1;
            this.textBoxPartWasteCodeEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxPartWasteCodeEdit.Visible = false;
            this.textBoxPartWasteCodeEdit.TextChanged += new System.EventHandler(this.textBoxPartWasteCodeEdit_TextChanged);
            this.textBoxPartWasteCodeEdit.GotFocus += new System.EventHandler(this.textBoxPartWasteCodeEdit_GotFocus);
            this.textBoxPartWasteCodeEdit.LostFocus += new System.EventHandler(this.textBoxPartWasteCodeEdit_LostFocus);
            // 
            // textBoxPartWasteCodeView
            // 
            this.textBoxPartWasteCodeView.Font = new System.Drawing.Font("B Nazanin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxPartWasteCodeView.Location = new System.Drawing.Point(528, 334);
            this.textBoxPartWasteCodeView.Name = "textBoxPartWasteCodeView";
            this.textBoxPartWasteCodeView.ReadOnly = true;
            this.textBoxPartWasteCodeView.Size = new System.Drawing.Size(515, 48);
            this.textBoxPartWasteCodeView.TabIndex = 3;
            this.textBoxPartWasteCodeView.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxPartWasteCodeView.GotFocus += new System.EventHandler(this.textBoxPartWasteCodeView_GotFocus);
            // 
            // textBoxLesionView
            // 
            this.textBoxLesionView.Font = new System.Drawing.Font("B Nazanin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxLesionView.Location = new System.Drawing.Point(528, 276);
            this.textBoxLesionView.Name = "textBoxLesionView";
            this.textBoxLesionView.ReadOnly = true;
            this.textBoxLesionView.Size = new System.Drawing.Size(515, 48);
            this.textBoxLesionView.TabIndex = 2;
            this.textBoxLesionView.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxLesionView.TextChanged += new System.EventHandler(this.textBoxLesionView_TextChanged);
            this.textBoxLesionView.GotFocus += new System.EventHandler(this.textBoxLesionView_GotFocus);
            // 
            // listBoxLesionType
            // 
            this.listBoxLesionType.Font = new System.Drawing.Font("B Nazanin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.listBoxLesionType.FormattingEnabled = true;
            this.listBoxLesionType.ItemHeight = 40;
            this.listBoxLesionType.Location = new System.Drawing.Point(528, 328);
            this.listBoxLesionType.Name = "listBoxLesionType";
            this.listBoxLesionType.Size = new System.Drawing.Size(515, 124);
            this.listBoxLesionType.TabIndex = 4;
            this.listBoxLesionType.Visible = false;
            this.listBoxLesionType.Click += new System.EventHandler(this.listBoxLesionType_Click);
            this.listBoxLesionType.SelectedIndexChanged += new System.EventHandler(this.listBoxLesionType_SelectedIndexChanged);
            this.listBoxLesionType.GotFocus += new System.EventHandler(this.listBoxLesionType_GotFocus);
            // 
            // listBoxPartWasteCode
            // 
            this.listBoxPartWasteCode.Font = new System.Drawing.Font("B Nazanin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.listBoxPartWasteCode.FormattingEnabled = true;
            this.listBoxPartWasteCode.ItemHeight = 40;
            this.listBoxPartWasteCode.Location = new System.Drawing.Point(528, 384);
            this.listBoxPartWasteCode.Name = "listBoxPartWasteCode";
            this.listBoxPartWasteCode.Size = new System.Drawing.Size(515, 124);
            this.listBoxPartWasteCode.TabIndex = 5;
            this.listBoxPartWasteCode.Visible = false;
            this.listBoxPartWasteCode.Click += new System.EventHandler(this.listBoxPartWasteCode_Click);
            this.listBoxPartWasteCode.SelectedIndexChanged += new System.EventHandler(this.listBoxPartWasteCode_SelectedIndexChanged);
            this.listBoxPartWasteCode.LostFocus += new System.EventHandler(this.listBoxPartWasteCode_LostFocus);
            // 
            // textBoxFocus
            // 
            this.textBoxFocus.Location = new System.Drawing.Point(12, 18);
            this.textBoxFocus.Name = "textBoxFocus";
            this.textBoxFocus.Size = new System.Drawing.Size(10, 20);
            this.textBoxFocus.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(1057, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "دلیل ضایعات";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(1057, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 40);
            this.label2.TabIndex = 7;
            this.label2.Text = "کد کالای ضایعات";
            // 
            // textBoxPartName
            // 
            this.textBoxPartName.Font = new System.Drawing.Font("B Nazanin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxPartName.Location = new System.Drawing.Point(528, 222);
            this.textBoxPartName.Name = "textBoxPartName";
            this.textBoxPartName.ReadOnly = true;
            this.textBoxPartName.Size = new System.Drawing.Size(515, 48);
            this.textBoxPartName.TabIndex = 8;
            this.textBoxPartName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxOrderCode
            // 
            this.textBoxOrderCode.Font = new System.Drawing.Font("B Nazanin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxOrderCode.Location = new System.Drawing.Point(790, 104);
            this.textBoxOrderCode.Name = "textBoxOrderCode";
            this.textBoxOrderCode.ReadOnly = true;
            this.textBoxOrderCode.Size = new System.Drawing.Size(152, 48);
            this.textBoxOrderCode.TabIndex = 9;
            this.textBoxOrderCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(1053, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 40);
            this.label3.TabIndex = 10;
            this.label3.Text = "ردیف کالای ارسالی";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(952, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 40);
            this.label4.TabIndex = 11;
            this.label4.Text = "شماره سفارش";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(612, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 40);
            this.label5.TabIndex = 13;
            this.label5.Text = "کد کالای ارسالی";
            // 
            // textBoxPartCode
            // 
            this.textBoxPartCode.Font = new System.Drawing.Font("B Nazanin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxPartCode.Location = new System.Drawing.Point(449, 101);
            this.textBoxPartCode.Name = "textBoxPartCode";
            this.textBoxPartCode.ReadOnly = true;
            this.textBoxPartCode.Size = new System.Drawing.Size(157, 48);
            this.textBoxPartCode.TabIndex = 12;
            this.textBoxPartCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonLesionClear
            // 
            this.buttonLesionClear.Font = new System.Drawing.Font("B Nazanin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonLesionClear.Location = new System.Drawing.Point(476, 279);
            this.buttonLesionClear.Name = "buttonLesionClear";
            this.buttonLesionClear.Size = new System.Drawing.Size(46, 44);
            this.buttonLesionClear.TabIndex = 65;
            this.buttonLesionClear.Text = "C";
            this.buttonLesionClear.UseVisualStyleBackColor = true;
            this.buttonLesionClear.Click += new System.EventHandler(this.buttonLesionClear_Click);
            // 
            // buttonPartWasteCodeClear
            // 
            this.buttonPartWasteCodeClear.Font = new System.Drawing.Font("B Nazanin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonPartWasteCodeClear.Location = new System.Drawing.Point(477, 332);
            this.buttonPartWasteCodeClear.Name = "buttonPartWasteCodeClear";
            this.buttonPartWasteCodeClear.Size = new System.Drawing.Size(46, 44);
            this.buttonPartWasteCodeClear.TabIndex = 66;
            this.buttonPartWasteCodeClear.Text = "C";
            this.buttonPartWasteCodeClear.UseVisualStyleBackColor = true;
            this.buttonPartWasteCodeClear.Click += new System.EventHandler(this.buttonPartWasteCodeClear_Click);
            // 
            // pictureBoxNext
            // 
            this.pictureBoxNext.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNext.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNext.Image")));
            this.pictureBoxNext.Location = new System.Drawing.Point(891, 514);
            this.pictureBoxNext.Name = "pictureBoxNext";
            this.pictureBoxNext.Size = new System.Drawing.Size(142, 139);
            this.pictureBoxNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNext.TabIndex = 67;
            this.pictureBoxNext.TabStop = false;
            this.pictureBoxNext.Click += new System.EventHandler(this.pictureBoxNext_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("B Nazanin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(317, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 40);
            this.label6.TabIndex = 69;
            this.label6.Text = "وزن ضایعات";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Font = new System.Drawing.Font("B Nazanin", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxWeight.Location = new System.Drawing.Point(165, 100);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.ReadOnly = true;
            this.textBoxWeight.Size = new System.Drawing.Size(148, 48);
            this.textBoxWeight.TabIndex = 68;
            this.textBoxWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Yellow;
            this.buttonBack.Location = new System.Drawing.Point(12, 10);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(96, 40);
            this.buttonBack.TabIndex = 74;
            this.buttonBack.Text = "برگشت";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(557, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 38);
            this.label7.TabIndex = 73;
            this.label7.Text = "ثبت ضایعات";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(-3, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1283, 10);
            this.label8.TabIndex = 72;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(156, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(943, 10);
            this.label9.TabIndex = 75;
            // 
            // FormWaste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 740);
            this.ControlBox = false;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.pictureBoxNext);
            this.Controls.Add(this.buttonPartWasteCodeClear);
            this.Controls.Add(this.buttonLesionClear);
            this.Controls.Add(this.listBoxLesionType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxPartCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxOrderCode);
            this.Controls.Add(this.textBoxPartName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFocus);
            this.Controls.Add(this.listBoxPartWasteCode);
            this.Controls.Add(this.textBoxPartWasteCodeEdit);
            this.Controls.Add(this.textBoxLesionTypeEdit);
            this.Controls.Add(this.textBoxLesionView);
            this.Controls.Add(this.textBoxPartWasteCodeView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormWaste";
            this.Text = "FormWaste";
            this.Load += new System.EventHandler(this.FormWaste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLesionTypeEdit;
        private System.Windows.Forms.TextBox textBoxPartWasteCodeEdit;
        private System.Windows.Forms.TextBox textBoxPartWasteCodeView;
        private System.Windows.Forms.TextBox textBoxLesionView;
        private System.Windows.Forms.ListBox listBoxLesionType;
        private System.Windows.Forms.ListBox listBoxPartWasteCode;
        private System.Windows.Forms.TextBox textBoxFocus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPartName;
        private System.Windows.Forms.TextBox textBoxOrderCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPartCode;
        private System.Windows.Forms.Button buttonLesionClear;
        private System.Windows.Forms.Button buttonPartWasteCodeClear;
        private System.Windows.Forms.PictureBox pictureBoxNext;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}