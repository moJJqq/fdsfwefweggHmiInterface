namespace HMIInterface1
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxOrder = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxNext = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxManualWeight = new System.Windows.Forms.CheckBox();
            this.textBoxNumberOfPareSnag = new System.Windows.Forms.NumericUpDown();
            this.textBoxWeight = new System.Windows.Forms.NumericUpDown();
            this.textBoxNumberOfBatch = new System.Windows.Forms.NumericUpDown();
            this.buttonPareSang = new System.Windows.Forms.Button();
            this.textBoxFormula = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonSendList = new System.Windows.Forms.Button();
            this.buttonOrderStatus = new System.Windows.Forms.Button();
            this.textBoxFocus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOrderEdit = new System.Windows.Forms.TextBox();
            this.textBoxOrderView = new System.Windows.Forms.TextBox();
            this.textBoxProductEdit = new System.Windows.Forms.TextBox();
            this.textBoxProductView = new System.Windows.Forms.TextBox();
            this.listBoxProduct = new System.Windows.Forms.ListBox();
            this.timerSyncLocalDB = new System.Windows.Forms.Timer(this.components);
            this.buttonProductClear = new System.Windows.Forms.Button();
            this.buttonOrderClear = new System.Windows.Forms.Button();
            this.timerUpdateWeight = new System.Windows.Forms.Timer(this.components);
            this.btn_Exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxShowNext = new System.Windows.Forms.PictureBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxNumberOfPareSnag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxNumberOfBatch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowNext)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(831, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 26);
            this.label7.TabIndex = 47;
            this.label7.Text = "تعداد";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(835, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 26);
            this.label6.TabIndex = 46;
            this.label6.Text = "وزن";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(1014, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 393);
            this.label5.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(117, 537);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1042, 10);
            this.label4.TabIndex = 44;
            // 
            // listBoxOrder
            // 
            this.listBoxOrder.Font = new System.Drawing.Font("B Nazanin", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.listBoxOrder.FormattingEnabled = true;
            this.listBoxOrder.ItemHeight = 40;
            this.listBoxOrder.Location = new System.Drawing.Point(901, 141);
            this.listBoxOrder.Name = "listBoxOrder";
            this.listBoxOrder.Size = new System.Drawing.Size(171, 124);
            this.listBoxOrder.TabIndex = 31;
            this.listBoxOrder.Visible = false;
            this.listBoxOrder.Click += new System.EventHandler(this.listBoxOrder_Click);
            this.listBoxOrder.SelectedIndexChanged += new System.EventHandler(this.listBoxOrder_SelectedIndexChanged);
            this.listBoxOrder.LostFocus += new System.EventHandler(this.listBoxOrder_LostFocus);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(119, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1049, 10);
            this.label3.TabIndex = 43;
            // 
            // pictureBoxNext
            // 
            this.pictureBoxNext.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxNext.BackgroundImage")));
            this.pictureBoxNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxNext.Location = new System.Drawing.Point(365, 550);
            this.pictureBoxNext.Name = "pictureBoxNext";
            this.pictureBoxNext.Size = new System.Drawing.Size(591, 157);
            this.pictureBoxNext.TabIndex = 0;
            this.pictureBoxNext.TabStop = false;
            this.pictureBoxNext.Visible = false;
            this.pictureBoxNext.Click += new System.EventHandler(this.pictureBoxNext_Click);
            this.pictureBoxNext.LostFocus += new System.EventHandler(this.pictureBoxNext_LostFocus);
            this.pictureBoxNext.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxNext_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.checkBoxManualWeight);
            this.panel1.Controls.Add(this.textBoxNumberOfPareSnag);
            this.panel1.Controls.Add(this.textBoxWeight);
            this.panel1.Controls.Add(this.textBoxNumberOfBatch);
            this.panel1.Controls.Add(this.buttonPareSang);
            this.panel1.Controls.Add(this.textBoxFormula);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(133, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 354);
            this.panel1.TabIndex = 40;
            // 
            // checkBoxManualWeight
            // 
            this.checkBoxManualWeight.AutoSize = true;
            this.checkBoxManualWeight.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.checkBoxManualWeight.Location = new System.Drawing.Point(126, 3);
            this.checkBoxManualWeight.Name = "checkBoxManualWeight";
            this.checkBoxManualWeight.Size = new System.Drawing.Size(68, 33);
            this.checkBoxManualWeight.TabIndex = 54;
            this.checkBoxManualWeight.Text = "دستی";
            this.checkBoxManualWeight.UseVisualStyleBackColor = true;
            this.checkBoxManualWeight.CheckedChanged += new System.EventHandler(this.checkBoxManualWeight_CheckedChanged);
            // 
            // textBoxNumberOfPareSnag
            // 
            this.textBoxNumberOfPareSnag.DecimalPlaces = 4;
            this.textBoxNumberOfPareSnag.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxNumberOfPareSnag.Location = new System.Drawing.Point(14, 140);
            this.textBoxNumberOfPareSnag.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.textBoxNumberOfPareSnag.Name = "textBoxNumberOfPareSnag";
            this.textBoxNumberOfPareSnag.ReadOnly = true;
            this.textBoxNumberOfPareSnag.Size = new System.Drawing.Size(106, 37);
            this.textBoxNumberOfPareSnag.TabIndex = 52;
            this.textBoxNumberOfPareSnag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNumberOfPareSnag.ThousandsSeparator = true;
            this.textBoxNumberOfPareSnag.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.DecimalPlaces = 4;
            this.textBoxWeight.Font = new System.Drawing.Font("B Nazanin", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxWeight.Location = new System.Drawing.Point(126, 42);
            this.textBoxWeight.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(701, 87);
            this.textBoxWeight.TabIndex = 51;
            this.textBoxWeight.Tag = "99999999";
            this.textBoxWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxWeight.ThousandsSeparator = true;
            // 
            // textBoxNumberOfBatch
            // 
            this.textBoxNumberOfBatch.Font = new System.Drawing.Font("B Nazanin", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxNumberOfBatch.Location = new System.Drawing.Point(126, 140);
            this.textBoxNumberOfBatch.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.textBoxNumberOfBatch.Name = "textBoxNumberOfBatch";
            this.textBoxNumberOfBatch.Size = new System.Drawing.Size(701, 57);
            this.textBoxNumberOfBatch.TabIndex = 50;
            this.textBoxNumberOfBatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNumberOfBatch.ThousandsSeparator = true;
            // 
            // buttonPareSang
            // 
            this.buttonPareSang.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonPareSang.Location = new System.Drawing.Point(14, 43);
            this.buttonPareSang.Name = "buttonPareSang";
            this.buttonPareSang.Size = new System.Drawing.Size(109, 86);
            this.buttonPareSang.TabIndex = 22;
            this.buttonPareSang.Text = "پاره سنگ";
            this.buttonPareSang.UseVisualStyleBackColor = false;
            this.buttonPareSang.Click += new System.EventHandler(this.buttonPareSang_Click);
            // 
            // textBoxFormula
            // 
            this.textBoxFormula.Font = new System.Drawing.Font("B Nazanin", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxFormula.Location = new System.Drawing.Point(126, 213);
            this.textBoxFormula.Multiline = true;
            this.textBoxFormula.Name = "textBoxFormula";
            this.textBoxFormula.Size = new System.Drawing.Size(701, 45);
            this.textBoxFormula.TabIndex = 49;
            this.textBoxFormula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(828, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 26);
            this.label8.TabIndex = 53;
            this.label8.Text = "فرمول";
            // 
            // buttonSendList
            // 
            this.buttonSendList.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonSendList.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonSendList.Location = new System.Drawing.Point(1030, 242);
            this.buttonSendList.Name = "buttonSendList";
            this.buttonSendList.Size = new System.Drawing.Size(120, 82);
            this.buttonSendList.TabIndex = 39;
            this.buttonSendList.Text = "مشاهده لیست ارسال";
            this.buttonSendList.UseVisualStyleBackColor = false;
            this.buttonSendList.Click += new System.EventHandler(this.buttonSendList_Click);
            // 
            // buttonOrderStatus
            // 
            this.buttonOrderStatus.BackColor = System.Drawing.Color.MediumAquamarine;
            this.buttonOrderStatus.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonOrderStatus.Location = new System.Drawing.Point(1030, 160);
            this.buttonOrderStatus.Name = "buttonOrderStatus";
            this.buttonOrderStatus.Size = new System.Drawing.Size(120, 76);
            this.buttonOrderStatus.TabIndex = 38;
            this.buttonOrderStatus.Text = "وضعیت سفارش";
            this.buttonOrderStatus.UseVisualStyleBackColor = false;
            // 
            // textBoxFocus
            // 
            this.textBoxFocus.Location = new System.Drawing.Point(12, 12);
            this.textBoxFocus.Name = "textBoxFocus";
            this.textBoxFocus.Size = new System.Drawing.Size(20, 20);
            this.textBoxFocus.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(435, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 30);
            this.label2.TabIndex = 36;
            this.label2.Text = "کد کالا/ نام کالا";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(933, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 26);
            this.label1.TabIndex = 32;
            this.label1.Text = "شماره سفارش";
            // 
            // textBoxOrderEdit
            // 
            this.textBoxOrderEdit.Font = new System.Drawing.Font("B Nazanin", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxOrderEdit.Location = new System.Drawing.Point(901, 106);
            this.textBoxOrderEdit.MaxLength = 6;
            this.textBoxOrderEdit.Multiline = true;
            this.textBoxOrderEdit.Name = "textBoxOrderEdit";
            this.textBoxOrderEdit.Size = new System.Drawing.Size(171, 34);
            this.textBoxOrderEdit.TabIndex = 30;
            this.textBoxOrderEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxOrderEdit.Visible = false;
            this.textBoxOrderEdit.TextChanged += new System.EventHandler(this.textBoxOrderEdit_TextChanged);
            this.textBoxOrderEdit.GotFocus += new System.EventHandler(this.textBoxOrderEdit_GotFocus);
            this.textBoxOrderEdit.LostFocus += new System.EventHandler(this.textBoxOrderEdit_LostFocus);
            // 
            // textBoxOrderView
            // 
            this.textBoxOrderView.Font = new System.Drawing.Font("B Nazanin", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxOrderView.Location = new System.Drawing.Point(901, 107);
            this.textBoxOrderView.Multiline = true;
            this.textBoxOrderView.Name = "textBoxOrderView";
            this.textBoxOrderView.ReadOnly = true;
            this.textBoxOrderView.Size = new System.Drawing.Size(171, 34);
            this.textBoxOrderView.TabIndex = 33;
            this.textBoxOrderView.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxOrderView.TextChanged += new System.EventHandler(this.textBoxOrderView_TextChanged);
            this.textBoxOrderView.GotFocus += new System.EventHandler(this.textBoxOrderView_GotFocus);
            // 
            // textBoxProductEdit
            // 
            this.textBoxProductEdit.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxProductEdit.Location = new System.Drawing.Point(254, 107);
            this.textBoxProductEdit.Multiline = true;
            this.textBoxProductEdit.Name = "textBoxProductEdit";
            this.textBoxProductEdit.Size = new System.Drawing.Size(562, 34);
            this.textBoxProductEdit.TabIndex = 34;
            this.textBoxProductEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxProductEdit.Visible = false;
            this.textBoxProductEdit.TextChanged += new System.EventHandler(this.textBoxProductEdit_TextChanged);
            this.textBoxProductEdit.GotFocus += new System.EventHandler(this.textBoxProductEdit_GotFocus);
            this.textBoxProductEdit.LostFocus += new System.EventHandler(this.textBoxProductEdit_LostFocus);
            // 
            // textBoxProductView
            // 
            this.textBoxProductView.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxProductView.Location = new System.Drawing.Point(252, 107);
            this.textBoxProductView.Multiline = true;
            this.textBoxProductView.Name = "textBoxProductView";
            this.textBoxProductView.ReadOnly = true;
            this.textBoxProductView.Size = new System.Drawing.Size(562, 35);
            this.textBoxProductView.TabIndex = 37;
            this.textBoxProductView.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxProductView.GotFocus += new System.EventHandler(this.textBoxProductView_GotFocus);
            // 
            // listBoxProduct
            // 
            this.listBoxProduct.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.listBoxProduct.FormattingEnabled = true;
            this.listBoxProduct.ItemHeight = 29;
            this.listBoxProduct.Location = new System.Drawing.Point(253, 142);
            this.listBoxProduct.Name = "listBoxProduct";
            this.listBoxProduct.Size = new System.Drawing.Size(562, 120);
            this.listBoxProduct.TabIndex = 35;
            this.listBoxProduct.Visible = false;
            this.listBoxProduct.Click += new System.EventHandler(this.listBoxProduct_Click);
            this.listBoxProduct.LostFocus += new System.EventHandler(this.listBoxProduct_LostFocus);
            // 
            // timerSyncLocalDB
            // 
            this.timerSyncLocalDB.Tick += new System.EventHandler(this.timerSyncLocalDB_Tick);
            // 
            // buttonProductClear
            // 
            this.buttonProductClear.BackColor = System.Drawing.Color.Transparent;
            this.buttonProductClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonProductClear.Location = new System.Drawing.Point(217, 107);
            this.buttonProductClear.Name = "buttonProductClear";
            this.buttonProductClear.Size = new System.Drawing.Size(33, 33);
            this.buttonProductClear.TabIndex = 50;
            this.buttonProductClear.Text = "C";
            this.buttonProductClear.UseVisualStyleBackColor = false;
            this.buttonProductClear.Click += new System.EventHandler(this.buttonProductClear_Click);
            // 
            // buttonOrderClear
            // 
            this.buttonOrderClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonOrderClear.Location = new System.Drawing.Point(867, 107);
            this.buttonOrderClear.Name = "buttonOrderClear";
            this.buttonOrderClear.Size = new System.Drawing.Size(33, 33);
            this.buttonOrderClear.TabIndex = 51;
            this.buttonOrderClear.Text = "C";
            this.buttonOrderClear.UseVisualStyleBackColor = true;
            this.buttonOrderClear.Click += new System.EventHandler(this.buttonOrderClear_Click);
            // 
            // timerUpdateWeight
            // 
            this.timerUpdateWeight.Enabled = true;
            this.timerUpdateWeight.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Yellow;
            this.btn_Exit.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Exit.Location = new System.Drawing.Point(8, 8);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(81, 39);
            this.btn_Exit.TabIndex = 52;
            this.btn_Exit.Text = "خروج";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 564);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // pictureBoxShowNext
            // 
            this.pictureBoxShowNext.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxShowNext.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxShowNext.Image")));
            this.pictureBoxShowNext.Location = new System.Drawing.Point(938, 550);
            this.pictureBoxShowNext.Name = "pictureBoxShowNext";
            this.pictureBoxShowNext.Size = new System.Drawing.Size(212, 157);
            this.pictureBoxShowNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxShowNext.TabIndex = 42;
            this.pictureBoxShowNext.TabStop = false;
            this.pictureBoxShowNext.Click += new System.EventHandler(this.pictureBoxShowNext_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.Transparent;
            this.labelUserName.Font = new System.Drawing.Font("B Nazanin", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelUserName.Location = new System.Drawing.Point(1022, 6);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(120, 43);
            this.labelUserName.TabIndex = 54;
            this.labelUserName.Text = "نام کاربری ";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(1, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1277, 10);
            this.label9.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(933, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 26);
            this.label10.TabIndex = 56;
            this.label10.Text = "تغییر رمز عبور";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 740);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listBoxOrder);
            this.Controls.Add(this.buttonSendList);
            this.Controls.Add(this.buttonOrderStatus);
            this.Controls.Add(this.pictureBoxNext);
            this.Controls.Add(this.listBoxProduct);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.buttonOrderClear);
            this.Controls.Add(this.buttonProductClear);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFocus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxShowNext);
            this.Controls.Add(this.textBoxProductEdit);
            this.Controls.Add(this.textBoxProductView);
            this.Controls.Add(this.textBoxOrderEdit);
            this.Controls.Add(this.textBoxOrderView);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormHome";
            this.Load += new System.EventHandler(this.FormHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxNumberOfPareSnag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxNumberOfBatch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowNext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxNext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPareSang;
        private System.Windows.Forms.Button buttonSendList;
        private System.Windows.Forms.Button buttonOrderStatus;
        private System.Windows.Forms.TextBox textBoxFocus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOrderEdit;
        private System.Windows.Forms.TextBox textBoxOrderView;
        private System.Windows.Forms.TextBox textBoxProductEdit;
        private System.Windows.Forms.TextBox textBoxProductView;
        private System.Windows.Forms.PictureBox pictureBoxShowNext;
        private System.Windows.Forms.ListBox listBoxProduct;
        private System.Windows.Forms.Timer timerSyncLocalDB;
        private System.Windows.Forms.TextBox textBoxFormula;
        private System.Windows.Forms.Button buttonProductClear;
        private System.Windows.Forms.Button buttonOrderClear;
        public System.Windows.Forms.Timer timerUpdateWeight;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown textBoxNumberOfBatch;
        private System.Windows.Forms.NumericUpDown textBoxNumberOfPareSnag;
        private System.Windows.Forms.NumericUpDown textBoxWeight;
        private System.Windows.Forms.CheckBox checkBoxManualWeight;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}