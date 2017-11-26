namespace HMIInterface1
{
    partial class FormStoppages
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
            this.stoppagesNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stoppagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.towzinDataSet3 = new HMIInterface1.TowzinDataSet3();
            this.stoppagesTableAdapter = new HMIInterface1.TowzinDataSet3TableAdapters.StoppagesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxStoppagesCode = new System.Windows.Forms.TextBox();
            this.textBoxStoppagesName = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxOrderCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonFinish = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoppagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.towzinDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.stoppagesNameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stoppagesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(595, 75);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(644, 423);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "کد";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stoppagesNameDataGridViewTextBoxColumn
            // 
            this.stoppagesNameDataGridViewTextBoxColumn.DataPropertyName = "StoppagesName";
            this.stoppagesNameDataGridViewTextBoxColumn.FillWeight = 200F;
            this.stoppagesNameDataGridViewTextBoxColumn.HeaderText = "علت توقفات";
            this.stoppagesNameDataGridViewTextBoxColumn.Name = "stoppagesNameDataGridViewTextBoxColumn";
            this.stoppagesNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.stoppagesNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.FillWeight = 20F;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "توضیحات";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 250;
            // 
            // stoppagesBindingSource
            // 
            this.stoppagesBindingSource.DataMember = "Stoppages";
            this.stoppagesBindingSource.DataSource = this.towzinDataSet3;
            // 
            // towzinDataSet3
            // 
            this.towzinDataSet3.DataSetName = "TowzinDataSet3";
            this.towzinDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stoppagesTableAdapter
            // 
            this.stoppagesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(464, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "کد توقف";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(461, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 43);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام توقف";
            // 
            // textBoxStoppagesCode
            // 
            this.textBoxStoppagesCode.Font = new System.Drawing.Font("B Nazanin", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxStoppagesCode.Location = new System.Drawing.Point(251, 165);
            this.textBoxStoppagesCode.Name = "textBoxStoppagesCode";
            this.textBoxStoppagesCode.ReadOnly = true;
            this.textBoxStoppagesCode.Size = new System.Drawing.Size(207, 47);
            this.textBoxStoppagesCode.TabIndex = 3;
            // 
            // textBoxStoppagesName
            // 
            this.textBoxStoppagesName.Font = new System.Drawing.Font("B Nazanin", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxStoppagesName.Location = new System.Drawing.Point(23, 225);
            this.textBoxStoppagesName.Name = "textBoxStoppagesName";
            this.textBoxStoppagesName.ReadOnly = true;
            this.textBoxStoppagesName.Size = new System.Drawing.Size(436, 47);
            this.textBoxStoppagesName.TabIndex = 4;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Yellow;
            this.buttonBack.Location = new System.Drawing.Point(13, 8);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(96, 40);
            this.buttonBack.TabIndex = 77;
            this.buttonBack.Text = "برگشت";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("B Nazanin", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(538, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 38);
            this.label7.TabIndex = 76;
            this.label7.Text = "ثبت توقفات";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(1, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1283, 10);
            this.label8.TabIndex = 75;
            // 
            // textBoxOrderCode
            // 
            this.textBoxOrderCode.Font = new System.Drawing.Font("B Nazanin", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxOrderCode.Location = new System.Drawing.Point(251, 75);
            this.textBoxOrderCode.Name = "textBoxOrderCode";
            this.textBoxOrderCode.ReadOnly = true;
            this.textBoxOrderCode.Size = new System.Drawing.Size(204, 47);
            this.textBoxOrderCode.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(461, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 43);
            this.label3.TabIndex = 78;
            this.label3.Text = "کد سفارش";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("B Nazanin", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonSubmit.Location = new System.Drawing.Point(23, 342);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(253, 147);
            this.buttonSubmit.TabIndex = 80;
            this.buttonSubmit.Text = "ثبت شروع یا توقف خط";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonFinish
            // 
            this.buttonFinish.Font = new System.Drawing.Font("B Nazanin", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.buttonFinish.Location = new System.Drawing.Point(308, 342);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(253, 147);
            this.buttonFinish.TabIndex = 81;
            this.buttonFinish.Text = "ثبت پایان تولید";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // FormStoppages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1251, 547);
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxOrderCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxStoppagesName);
            this.Controls.Add(this.textBoxStoppagesCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStoppages";
            this.Text = "FormStoppages";
            this.Load += new System.EventHandler(this.FormStoppages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoppagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.towzinDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TowzinDataSet3 towzinDataSet3;
        private System.Windows.Forms.BindingSource stoppagesBindingSource;
        private TowzinDataSet3TableAdapters.StoppagesTableAdapter stoppagesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stoppagesNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxStoppagesCode;
        private System.Windows.Forms.TextBox textBoxStoppagesName;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxOrderCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonFinish;
    }
}