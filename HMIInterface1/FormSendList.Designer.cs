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
            this.productionLineIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operatorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iODataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fromOrderCodeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromPartIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toOrderCodeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toPartIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formoulaNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wasteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lesionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amount1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productiveRowDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productiveDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.towzinDataSet = new HMIInterface1.TowzinDataSet();
            this.productiveDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.localDBTowzinDataSet = new HMIInterface1.LocalDBTowzinDataSet();
            this.productiveDetailsTableAdapter = new HMIInterface1.LocalDBTowzinDataSetTableAdapters.ProductiveDetailsTableAdapter();
            this.productiveDetailsTableAdapter1 = new HMIInterface1.TowzinDataSetTableAdapters.ProductiveDetailsTableAdapter();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productiveDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.towzinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productiveDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDBTowzinDataSet)).BeginInit();
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
            this.productionLineIDDataGridViewTextBoxColumn,
            this.partIDDataGridViewTextBoxColumn,
            this.operatorIDDataGridViewTextBoxColumn,
            this.iODataGridViewCheckBoxColumn,
            this.fromOrderCodeIDDataGridViewTextBoxColumn,
            this.fromPartIDDataGridViewTextBoxColumn,
            this.toOrderCodeIDDataGridViewTextBoxColumn,
            this.toPartIDDataGridViewTextBoxColumn,
            this.batchNumberDataGridViewTextBoxColumn,
            this.formoulaNumberDataGridViewTextBoxColumn,
            this.wasteDataGridViewCheckBoxColumn,
            this.lesionIDDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.amount1DataGridViewTextBoxColumn,
            this.productiveRowDetailsDataGridViewTextBoxColumn,
            this.iPDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productiveDetailsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(1280, 740);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // orderCodeIDDataGridViewTextBoxColumn
            // 
            this.orderCodeIDDataGridViewTextBoxColumn.DataPropertyName = "OrderCodeID";
            this.orderCodeIDDataGridViewTextBoxColumn.HeaderText = "OrderCodeID";
            this.orderCodeIDDataGridViewTextBoxColumn.Name = "orderCodeIDDataGridViewTextBoxColumn";
            this.orderCodeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productionLineIDDataGridViewTextBoxColumn
            // 
            this.productionLineIDDataGridViewTextBoxColumn.DataPropertyName = "ProductionLineID";
            this.productionLineIDDataGridViewTextBoxColumn.HeaderText = "ProductionLineID";
            this.productionLineIDDataGridViewTextBoxColumn.Name = "productionLineIDDataGridViewTextBoxColumn";
            this.productionLineIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partIDDataGridViewTextBoxColumn
            // 
            this.partIDDataGridViewTextBoxColumn.DataPropertyName = "PartID";
            this.partIDDataGridViewTextBoxColumn.HeaderText = "PartID";
            this.partIDDataGridViewTextBoxColumn.Name = "partIDDataGridViewTextBoxColumn";
            this.partIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // operatorIDDataGridViewTextBoxColumn
            // 
            this.operatorIDDataGridViewTextBoxColumn.DataPropertyName = "OperatorID";
            this.operatorIDDataGridViewTextBoxColumn.HeaderText = "OperatorID";
            this.operatorIDDataGridViewTextBoxColumn.Name = "operatorIDDataGridViewTextBoxColumn";
            this.operatorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iODataGridViewCheckBoxColumn
            // 
            this.iODataGridViewCheckBoxColumn.DataPropertyName = "IO";
            this.iODataGridViewCheckBoxColumn.HeaderText = "IO";
            this.iODataGridViewCheckBoxColumn.Name = "iODataGridViewCheckBoxColumn";
            this.iODataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // fromOrderCodeIDDataGridViewTextBoxColumn
            // 
            this.fromOrderCodeIDDataGridViewTextBoxColumn.DataPropertyName = "FromOrderCodeID";
            this.fromOrderCodeIDDataGridViewTextBoxColumn.HeaderText = "FromOrderCodeID";
            this.fromOrderCodeIDDataGridViewTextBoxColumn.Name = "fromOrderCodeIDDataGridViewTextBoxColumn";
            this.fromOrderCodeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fromPartIDDataGridViewTextBoxColumn
            // 
            this.fromPartIDDataGridViewTextBoxColumn.DataPropertyName = "FromPartID";
            this.fromPartIDDataGridViewTextBoxColumn.HeaderText = "FromPartID";
            this.fromPartIDDataGridViewTextBoxColumn.Name = "fromPartIDDataGridViewTextBoxColumn";
            this.fromPartIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toOrderCodeIDDataGridViewTextBoxColumn
            // 
            this.toOrderCodeIDDataGridViewTextBoxColumn.DataPropertyName = "ToOrderCodeID";
            this.toOrderCodeIDDataGridViewTextBoxColumn.HeaderText = "ToOrderCodeID";
            this.toOrderCodeIDDataGridViewTextBoxColumn.Name = "toOrderCodeIDDataGridViewTextBoxColumn";
            this.toOrderCodeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toPartIDDataGridViewTextBoxColumn
            // 
            this.toPartIDDataGridViewTextBoxColumn.DataPropertyName = "ToPartID";
            this.toPartIDDataGridViewTextBoxColumn.HeaderText = "ToPartID";
            this.toPartIDDataGridViewTextBoxColumn.Name = "toPartIDDataGridViewTextBoxColumn";
            this.toPartIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // batchNumberDataGridViewTextBoxColumn
            // 
            this.batchNumberDataGridViewTextBoxColumn.DataPropertyName = "BatchNumber";
            this.batchNumberDataGridViewTextBoxColumn.HeaderText = "BatchNumber";
            this.batchNumberDataGridViewTextBoxColumn.Name = "batchNumberDataGridViewTextBoxColumn";
            this.batchNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formoulaNumberDataGridViewTextBoxColumn
            // 
            this.formoulaNumberDataGridViewTextBoxColumn.DataPropertyName = "FormoulaNumber";
            this.formoulaNumberDataGridViewTextBoxColumn.HeaderText = "FormoulaNumber";
            this.formoulaNumberDataGridViewTextBoxColumn.Name = "formoulaNumberDataGridViewTextBoxColumn";
            this.formoulaNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wasteDataGridViewCheckBoxColumn
            // 
            this.wasteDataGridViewCheckBoxColumn.DataPropertyName = "Waste";
            this.wasteDataGridViewCheckBoxColumn.HeaderText = "Waste";
            this.wasteDataGridViewCheckBoxColumn.Name = "wasteDataGridViewCheckBoxColumn";
            this.wasteDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // lesionIDDataGridViewTextBoxColumn
            // 
            this.lesionIDDataGridViewTextBoxColumn.DataPropertyName = "LesionID";
            this.lesionIDDataGridViewTextBoxColumn.HeaderText = "LesionID";
            this.lesionIDDataGridViewTextBoxColumn.Name = "lesionIDDataGridViewTextBoxColumn";
            this.lesionIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amount1DataGridViewTextBoxColumn
            // 
            this.amount1DataGridViewTextBoxColumn.DataPropertyName = "Amount1";
            this.amount1DataGridViewTextBoxColumn.HeaderText = "Amount1";
            this.amount1DataGridViewTextBoxColumn.Name = "amount1DataGridViewTextBoxColumn";
            this.amount1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productiveRowDetailsDataGridViewTextBoxColumn
            // 
            this.productiveRowDetailsDataGridViewTextBoxColumn.DataPropertyName = "ProductiveRowDetails";
            this.productiveRowDetailsDataGridViewTextBoxColumn.HeaderText = "ProductiveRowDetails";
            this.productiveRowDetailsDataGridViewTextBoxColumn.Name = "productiveRowDetailsDataGridViewTextBoxColumn";
            this.productiveRowDetailsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iPDataGridViewTextBoxColumn
            // 
            this.iPDataGridViewTextBoxColumn.DataPropertyName = "IP";
            this.iPDataGridViewTextBoxColumn.HeaderText = "IP";
            this.iPDataGridViewTextBoxColumn.Name = "iPDataGridViewTextBoxColumn";
            this.iPDataGridViewTextBoxColumn.ReadOnly = true;
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
            // productiveDetailsTableAdapter
            // 
            this.productiveDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // productiveDetailsTableAdapter1
            // 
            this.productiveDetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Yellow;
            this.buttonBack.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonBack.Location = new System.Drawing.Point(49, 654);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 33);
            this.buttonBack.TabIndex = 72;
            this.buttonBack.Text = "برگشت";
            this.buttonBack.UseVisualStyleBackColor = false;
            // 
            // FormSendList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 745);
            this.ControlBox = false;
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSendList";
            this.Load += new System.EventHandler(this.FormSendList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productiveDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.towzinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productiveDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localDBTowzinDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private LocalDBTowzinDataSet localDBTowzinDataSet;
        private System.Windows.Forms.BindingSource productiveDetailsBindingSource;
        private LocalDBTowzinDataSetTableAdapters.ProductiveDetailsTableAdapter productiveDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderCodeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionLineIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operatorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn iODataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromOrderCodeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromPartIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toOrderCodeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toPartIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formoulaNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn wasteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lesionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productiveRowDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPDataGridViewTextBoxColumn;
        private TowzinDataSet towzinDataSet;
        private System.Windows.Forms.BindingSource productiveDetailsBindingSource1;
        private TowzinDataSetTableAdapters.ProductiveDetailsTableAdapter productiveDetailsTableAdapter1;
        private System.Windows.Forms.Button buttonBack;
    }
}