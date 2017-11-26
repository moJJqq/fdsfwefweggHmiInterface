namespace HMIInterface1
{
    partial class FormReturned
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReturned));
            this.listBoxPartCodeReturned = new System.Windows.Forms.ListBox();
            this.textBoxPartCodeReturnedEdit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPartCodeReturnedView = new System.Windows.Forms.TextBox();
            this.textBoxOrderCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxNext = new System.Windows.Forms.PictureBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFocus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNumberOFBatch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxPartCodeReturned
            // 
            this.listBoxPartCodeReturned.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.listBoxPartCodeReturned.FormattingEnabled = true;
            this.listBoxPartCodeReturned.ItemHeight = 31;
            this.listBoxPartCodeReturned.Location = new System.Drawing.Point(265, 183);
            this.listBoxPartCodeReturned.Name = "listBoxPartCodeReturned";
            this.listBoxPartCodeReturned.Size = new System.Drawing.Size(442, 128);
            this.listBoxPartCodeReturned.TabIndex = 68;
            this.listBoxPartCodeReturned.Visible = false;
            this.listBoxPartCodeReturned.Click += new System.EventHandler(this.listBoxtextBoxPartCodeReturned_Click);
            this.listBoxPartCodeReturned.SelectedIndexChanged += new System.EventHandler(this.listBoxPartCodeReturned_SelectedIndexChanged);
            this.listBoxPartCodeReturned.LostFocus += new System.EventHandler(this.listBoxtextBoxPartCodeReturned_LostFocus);
            // 
            // textBoxPartCodeReturnedEdit
            // 
            this.textBoxPartCodeReturnedEdit.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxPartCodeReturnedEdit.Location = new System.Drawing.Point(265, 141);
            this.textBoxPartCodeReturnedEdit.MaxLength = 6;
            this.textBoxPartCodeReturnedEdit.Name = "textBoxPartCodeReturnedEdit";
            this.textBoxPartCodeReturnedEdit.Size = new System.Drawing.Size(442, 39);
            this.textBoxPartCodeReturnedEdit.TabIndex = 67;
            this.textBoxPartCodeReturnedEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPartCodeReturnedEdit.Visible = false;
            this.textBoxPartCodeReturnedEdit.TextChanged += new System.EventHandler(this.textBoxPartCodeReturnedEdit_TextChanged);
            this.textBoxPartCodeReturnedEdit.LostFocus += new System.EventHandler(this.textBoxPartCodeReturnedEdit_LostFocus);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(409, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 31);
            this.label8.TabIndex = 69;
            this.label8.Text = "مواد یا کامپاند برگشتی";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBoxPartCodeReturnedView
            // 
            this.textBoxPartCodeReturnedView.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxPartCodeReturnedView.Location = new System.Drawing.Point(265, 140);
            this.textBoxPartCodeReturnedView.Name = "textBoxPartCodeReturnedView";
            this.textBoxPartCodeReturnedView.ReadOnly = true;
            this.textBoxPartCodeReturnedView.Size = new System.Drawing.Size(442, 39);
            this.textBoxPartCodeReturnedView.TabIndex = 70;
            this.textBoxPartCodeReturnedView.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPartCodeReturnedView.TextChanged += new System.EventHandler(this.textBoxPartCodeReturnedView_TextChanged);
            this.textBoxPartCodeReturnedView.GotFocus += new System.EventHandler(this.textBoxPartCodeReturnedView_GotFocus);
            // 
            // textBoxOrderCode
            // 
            this.textBoxOrderCode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxOrderCode.Font = new System.Drawing.Font("B Nazanin", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxOrderCode.Location = new System.Drawing.Point(847, 141);
            this.textBoxOrderCode.Name = "textBoxOrderCode";
            this.textBoxOrderCode.ReadOnly = true;
            this.textBoxOrderCode.Size = new System.Drawing.Size(224, 47);
            this.textBoxOrderCode.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(1077, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 31);
            this.label1.TabIndex = 73;
            this.label1.Text = "شماره سفارش";
            // 
            // pictureBoxNext
            // 
            this.pictureBoxNext.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNext.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNext.Image")));
            this.pictureBoxNext.Location = new System.Drawing.Point(1028, 408);
            this.pictureBoxNext.Name = "pictureBoxNext";
            this.pictureBoxNext.Size = new System.Drawing.Size(74, 90);
            this.pictureBoxNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNext.TabIndex = 76;
            this.pictureBoxNext.TabStop = false;
            this.pictureBoxNext.Click += new System.EventHandler(this.pictureBoxNext_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Yellow;
            this.buttonBack.Location = new System.Drawing.Point(12, 19);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 80;
            this.buttonBack.Text = "برگشت";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("B Nazanin", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(527, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 32);
            this.label7.TabIndex = 79;
            this.label7.Text = "ثبت برگشت مواد اولیه یا کامپاند";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(1, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1278, 11);
            this.label3.TabIndex = 78;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxFocus
            // 
            this.textBoxFocus.Location = new System.Drawing.Point(23, 22);
            this.textBoxFocus.Name = "textBoxFocus";
            this.textBoxFocus.Size = new System.Drawing.Size(10, 20);
            this.textBoxFocus.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(1077, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 31);
            this.label9.TabIndex = 84;
            this.label9.Text = "تعداد";
            // 
            // textBoxNumberOFBatch
            // 
            this.textBoxNumberOFBatch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxNumberOFBatch.Font = new System.Drawing.Font("B Nazanin", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxNumberOFBatch.Location = new System.Drawing.Point(847, 270);
            this.textBoxNumberOFBatch.Name = "textBoxNumberOFBatch";
            this.textBoxNumberOFBatch.ReadOnly = true;
            this.textBoxNumberOFBatch.Size = new System.Drawing.Size(224, 47);
            this.textBoxNumberOFBatch.TabIndex = 83;
            this.textBoxNumberOFBatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1077, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 31);
            this.label4.TabIndex = 82;
            this.label4.Text = "وزن";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxWeight.Font = new System.Drawing.Font("B Nazanin", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.textBoxWeight.Location = new System.Drawing.Point(847, 204);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.ReadOnly = true;
            this.textBoxWeight.Size = new System.Drawing.Size(224, 47);
            this.textBoxWeight.TabIndex = 81;
            this.textBoxWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormReturned
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HMIInterface1.Properties.Resources._1e9bb8554f534067f2e52bb2b9eaea3b_d63kxbvwedfgn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 740);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxNumberOFBatch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFocus);
            this.Controls.Add(this.pictureBoxNext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOrderCode);
            this.Controls.Add(this.listBoxPartCodeReturned);
            this.Controls.Add(this.textBoxPartCodeReturnedEdit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxPartCodeReturnedView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReturned";
            this.Text = "FormReturned";
            this.Load += new System.EventHandler(this.FormReturned_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPartCodeReturned;
        private System.Windows.Forms.TextBox textBoxPartCodeReturnedEdit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPartCodeReturnedView;
        private System.Windows.Forms.TextBox textBoxOrderCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxNext;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFocus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxNumberOFBatch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxWeight;
    }
}