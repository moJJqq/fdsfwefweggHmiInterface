using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMIInterface1
{
    public partial class FormStoppages : Form
    {
        public FormStoppages()
        {
            InitializeComponent();
        }

        private void FormStoppages_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'towzinDataSet3.Stoppages' table. You can move, or remove it, as needed.
            this.stoppagesTableAdapter.Fill(this.towzinDataSet3.Stoppages);
            Size size = new Size(Screen.PrimaryScreen.WorkingArea.Size.Width, Screen.PrimaryScreen.WorkingArea.Size.Height);
            this.Height = size.Height;
            this.Width = size.Width;
            Point p = new Point(0, 0);
            this.Location = p;
            textBoxOrderCode.Text = ClassStoppages.OrderCode.ToString();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxStoppagesCode.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBoxStoppagesName.Text= dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            ClassStoppages.StoppagesID =Convert.ToInt32( dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxNext_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Creator = "2b2f093d-19c0-4abd-b4b8-512cdacd97ab";
            string modifier = "2b2f093d-19c0-4abd-b4b8-512cdacd97ab";
            int Result;


            if (textBoxOrderCode.Text.Trim() == "")
            {
                MessageBox.Show("کد سفارش انتخاب نشده است", "سیستم");
                dataGridView1.Focus();
            }
            else if (textBoxStoppagesCode.Text.Trim()=="")
            {
                MessageBox.Show("کد توقف انتخاب نشده است", "سیستم");
                dataGridView1.Focus();
            }
            else
            {

                ClassDatabase.ConnectionServer.Open();
                SqlCommand command = new SqlCommand("INSERT INTO[dbo].[ProductiveStoppages]([StoppagesID],[OrderCodeID],[OperatorID],[StartTime],[IP],[ProductionLineID],PartID,[State],[Creator],[AddDate],[LastModifier],[LastModificationDate]) VALUES(" + ClassStoppages.StoppagesID + ", " + ClassStoppages.OrderCode + ", " + ClassOperator.OperatorID + ", '" + DateTime.Now + "', '"  + ClassSetting.IP + "',"+ ClassSetting.ProductionLineID+","+ClassStoppages.PartID+ "," + 1 + ", '" + Creator + "', '" + DateTime.Now + "', '" + modifier + "', '" + DateTime.Now + "')", ClassDatabase.ConnectionServer);
                Result = command.ExecuteNonQuery();


                if (Result == 1)
                {
                    MessageBox.Show("با موفقیت ثبت شد", "سیستم");
                }
                ClassDatabase.ConnectionServer.Close();
                this.Close();
            }
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            DialogResult Resualt=MessageBox.Show("آیا از ثبت پایان سفارش مطمئن هستید", "مدیر سیستم", MessageBoxButtons.OKCancel);
            if (Resualt == DialogResult.OK)
            {
                string Creator = "2b2f093d-19c0-4abd-b4b8-512cdacd97ab";
                string modifier = "2b2f093d-19c0-4abd-b4b8-512cdacd97ab";
                int Result;


                if (textBoxOrderCode.Text.Trim() == "")
                {
                    MessageBox.Show("کد سفارش انتخاب نشده است", "سیستم");
                    dataGridView1.Focus();
                }
                else if (textBoxStoppagesCode.Text.Trim() == "")
                {
                    MessageBox.Show("کد توقف انتخاب نشده است", "سیستم");
                    dataGridView1.Focus();
                }
                else
                {

                    ClassDatabase.ConnectionServer.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO[dbo].[ProductiveStoppages]([StoppagesID],[OrderCodeID],[OperatorID],[EndTime],[IP],[ProductionLineID],PartID,[State],[Creator],[AddDate],[LastModifier],[LastModificationDate]) VALUES(" + ClassStoppages.StoppagesID + ", " + ClassStoppages.OrderCode + ", " + ClassOperator.OperatorID + ", '" + DateTime.Now + "', '" + ClassSetting.IP + "'," + ClassSetting.ProductionLineID + "," + ClassStoppages.PartID + "," + 1 + ", '" + Creator + "', '" + DateTime.Now + "', '" + modifier + "', '" + DateTime.Now + "')", ClassDatabase.ConnectionServer);
                    Result = command.ExecuteNonQuery();


                    if (Result == 1)
                    {
                        MessageBox.Show("با موفقیت ثبت شد", "سیستم");
                    }
                    ClassDatabase.ConnectionServer.Close();
                    this.Close();
                }
            }
        }
    }
}
