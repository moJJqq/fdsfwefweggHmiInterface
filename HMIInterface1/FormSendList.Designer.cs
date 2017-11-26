namespace HMIInterface1
{
    partial class FormSendList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderCodeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddDateShamsi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Times = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formoulaNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IOo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fromOrderCodeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toOrderCodeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vWProductiveDetailsIndexBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.towzinDataSet2 = new HMIInterface1.TowzinDataSet2();
            this.productiveDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.towzinDataSet = new HMIInterface1.TowzinDataSet();
            this.productiveDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localDBTowzinDataSet = new HMIInterface1.LocalDBTowzinDataSet();
            this.buttonBack = new System.Windows.Forms.Button();
            this.towzinDataSet1 = new HMIInterface1.TowzinDataSet1();
            this.vWProductiveDetailsIndexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vW_ProductiveDetails_IndexTableAdapter = new HMIInterface1.TowzinDataSet1TableAdapters.VW_ProductiveDetails_IndexTableAdapter();
            this.vW_ProductiveDetails_IndexTableAdapter1 = new HMIInterface1.TowzinDataSet2TableAdapters.VW_ProductiveDetails_IndexTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWProductiveDetailsIndexBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.towzinDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productiveDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.towzinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productiveDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDBTowzinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.towzinDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWProductiveDetailsIndexBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.orderCodeIDDataGridViewTextBoxColumn,
            this.AddDateShamsi,
            this.Times,
            this.PartCode,
            this.Name,
            this.formoulaNumberDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.amount1DataGridViewTextBoxColumn,
            this.IOo,
            this.fromOrderCodeIDDataGridViewTextBoxColumn,
            this.toOrderCodeIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vWProductiveDetailsIndexBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1232, 642);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 50F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ردیف";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // orderCodeIDDataGridViewTextBoxColumn
            // 
            this.orderCodeIDDataGridViewTextBoxColumn.DataPropertyName = "OrderCodeID";
            this.orderCodeIDDataGridViewTextBoxColumn.HeaderText = "شماره سفارش";
            this.orderCodeIDDataGridViewTextBoxColumn.Name = "orderCodeIDDataGridViewTextBoxColumn";
            this.orderCodeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AddDateShamsi
            // 
            this.AddDateShamsi.DataPropertyName = "AddDateShamsi";
            this.AddDateShamsi.HeaderText = "تاریخ";
            this.AddDateShamsi.Name = "AddDateShamsi";
            this.AddDateShamsi.ReadOnly = true;
            // 
            // Times
            // 
            this.Times.DataPropertyName = "Times";
            this.Times.HeaderText = "ساعت";
            this.Times.Name = "Times";
            this.Times.ReadOnly = true;
            // 
            // PartCode
            // 
            this.PartCode.DataPropertyName = "PartCode";
            this.PartCode.HeaderText = "کد کالا";
            this.PartCode.Name = "PartCode";
            this.PartCode.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "نام کالا";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // formoulaNumberDataGridViewTextBoxColumn
            // 
            this.formoulaNumberDataGridViewTextBoxColumn.DataPropertyName = "FormoulaNumber";
            this.formoulaNumberDataGridViewTextBoxColumn.HeaderText = "فرمول";
            this.formoulaNumberDataGridViewTextBoxColumn.Name = "formoulaNumberDataGridViewTextBoxColumn";
            this.formoulaNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "کیلوگرم";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amount1DataGridViewTextBoxColumn
            // 
            this.amount1DataGridViewTextBoxColumn.DataPropertyName = "Amount1";
            this.amount1DataGridViewTextBoxColumn.HeaderText = "تعداد";
            this.amount1DataGridViewTextBoxColumn.Name = "amount1DataGridViewTextBoxColumn";
            this.amount1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // IOo
            // 
            this.IOo.DataPropertyName = "IOo";
            this.IOo.HeaderText = "ورودی/خروجی";
            this.IOo.Name = "IOo";
            this.IOo.ReadOnly = true;
            // 
            // fromOrderCodeIDDataGridViewTextBoxColumn
            // 
            this.fromOrderCodeIDDataGridViewTextBoxColumn.DataPropertyName = "FromOrderCodeID";
            this.fromOrderCodeIDDataGridViewTextBoxColumn.HeaderText = "از شماره سفارش";
            this.fromOrderCodeIDDataGridViewTextBoxColumn.Name = "fromOrderCodeIDDataGridViewTextBoxColumn";
            this.fromOrderCodeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toOrderCodeIDDataGridViewTextBoxColumn
            // 
            this.toOrderCodeIDDataGridViewTextBoxColumn.DataPropertyName = "ToOrderCodeID";
            this.toOrderCodeIDDataGridViewTextBoxColumn.HeaderText = "به شماره سفارش";
            this.toOrderCodeIDDataGridViewTextBoxColumn.Name = "toOrderCodeIDDataGridViewTextBoxColumn";
            this.toOrderCodeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vWProductiveDetailsIndexBindingSource1
            // 
            this.vWProductiveDetailsIndexBindingSource1.DataMember = "VW_ProductiveDetails_Index";
            this.vWProductiveDetailsIndexBindingSource1.DataSource = this.towzinDataSet2;
            // 
            // towzinDataSet2
            // 
            this.towzinDataSet2.DataSetName = "TowzinDataSet2";
            this.towzinDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productiveDetailsBindingSource1
            // 
            this.productiveDetailsBindingSource1.DataMember = "ProductiveDetails";
            this.productiveDetailsBindingSource1.DataSource = this.towzinDataSet;
            // 
            // towzinDataSet
            // 
            this.towzinDataSet.DataSetName = "TowzinDataSet";
            this.towzinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productiveDetailsBindingSource
            // 
            this.productiveDetailsBindingSource.DataMember = "ProductiveDetails";
            this.productiveDetailsBindingSource.DataSource = this.localDBTowzinDataSet;
            // 
            // localDBTowzinDataSet
            // 
            this.localDBTowzinDataSet.DataSetName = "LocalDBTowzinDataSet";
            this.localDBTowzinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Yellow;
            this.buttonBack.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonBack.Location = new System.Drawing.Point(35, 654);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(89, 53);
            this.buttonBack.TabIndex = 72;
            this.buttonBack.Text = "برگشت";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // towzinDataSet1
            // 
            this.towzinDataSet1.DataSetName = "TowzinDataSet1";
            this.towzinDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vWProductiveDetailsIndexBindingSource
            // 
            this.vWProductiveDetailsIndexBindingSource.DataMember = "VW_ProductiveDetails_Index";
            this.vWProductiveDetailsIndexBindingSource.DataSource = this.towzinDataSet1;
            // 
            // vW_ProductiveDetails_IndexTableAdapter
            // 
            this.vW_ProductiveDetails_IndexTableAdapter.ClearBeforeFill = true;
            // 
            // vW_ProductiveDetails_IndexTableAdapter1
            // 
            this.vW_ProductiveDetails_IndexTableAdapter1.ClearBeforeFill = true;
            // 
            // FormSendList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 745);
            this.ControlBox = false;
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
           
            this.Load += new System.EventHandler(this.FormSendList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWProductiveDetailsIndexBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.towzinDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productiveDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.towzinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productiveDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDBTowzinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.towzinDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vWProductiveDetailsIndexBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private LocalDBTowzinDataSet localDBTowzinDataSet;
        private System.Windows.Forms.BindingSource productiveDetailsBindingSource;
        private TowzinDataSet towzinDataSet;
        private System.Windows.Forms.BindingSource productiveDetailsBindingSource1;
        private System.Windows.Forms.Button buttonBack;
        private TowzinDataSet1 towzinDataSet1;
        private System.Windows.Forms.BindingSource vWProductiveDetailsIndexBindingSource;
        private TowzinDataSet1TableAdapters.VW_ProductiveDetails_IndexTableAdapter vW_ProductiveDetails_IndexTableAdapter;
        private TowzinDataSet2 towzinDataSet2;
        private System.Windows.Forms.BindingSource vWProductiveDetailsIndexBindingSource1;
        private TowzinDataSet2TableAdapters.VW_ProductiveDetails_IndexTableAdapter vW_ProductiveDetails_IndexTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderCodeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddDateShamsi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Times;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn formoulaNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IOo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromOrderCodeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toOrderCodeIDDataGridViewTextBoxColumn;
    }
}