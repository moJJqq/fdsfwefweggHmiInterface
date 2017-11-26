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

    public partial class FormReturned : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=192.168.1.11\Towzin;Initial Catalog=Towzin;User ID=towzin;Password=123456");
        SqlCommand command;
        public FormReturned()
        {
            InitializeComponent();
        }

        private void textBoxPartCodeReturnedView_GotFocus(object sender, EventArgs e)
        {
            textBoxPartCodeReturnedEdit.Visible = true;
            textBoxPartCodeReturnedEdit.Focus();
            listBoxPartCodeReturned.Visible = true;
        }

        private void textBoxPartCodeReturnedEdit_LostFocus(object sender, EventArgs e)
        {
            if(listBoxPartCodeReturned.Focused!=true)
            {
                listBoxPartCodeReturned.Visible = false;
                textBoxPartCodeReturnedEdit.Visible = false;
            }



        }

        private void listBoxtextBoxPartCodeReturned_LostFocus(object sender, EventArgs e)
        {
            listBoxPartCodeReturned.Visible = false;
            textBoxPartCodeReturnedEdit.Visible = false;
        }

        private void listBoxtextBoxPartCodeReturned_Click(object sender, EventArgs e)
        {
            if (listBoxPartCodeReturned.SelectedValue != null)
            {
                ClassReturned.PartID= Convert.ToInt64( listBoxPartCodeReturned.SelectedValue);
                textBoxPartCodeReturnedView.Text = listBoxPartCodeReturned.Text;
                textBoxFocus.Focus();
                listBoxPartCodeReturned.Visible = false;
                textBoxPartCodeReturnedEdit.Visible = false;
            }
        }

        private void textBoxPartCodeReturnedEdit_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=192.168.1.11\Towzin;Initial Catalog=Towzin;User ID=towzin;Password=123456;MultipleActiveResultSets=true");
            string searchCombo = textBoxPartCodeReturnedEdit.Text;
            string Query = "SELECT DISTINCT dbo.ProductiveDetails.OrderCodeID, dbo.Part.Name, dbo.Part.PartCode, dbo.Part.ID FROM dbo.ProductiveDetails LEFT OUTER JOIN dbo.Part ON dbo.ProductiveDetails.PartID = dbo.Part.ID WHERE (dbo.ProductiveDetails.IO = 0 and ordercodeID="+ClassReturned.OrderCode+ ")and(dbo.Part.Name like N'%"+ textBoxPartCodeReturnedEdit.Text +"%' or PartCode like N'%"+textBoxPartCodeReturnedEdit.Text+"%')";
            SqlDataAdapter DA1 = new SqlDataAdapter(Query, con);

            con.Open();
            DataTable DT1 = new DataTable();
            DA1.Fill(DT1);
            con.Close();
            if (DT1.Rows.Count == 1)
            {
                ClassReturned.PartID = Convert.ToInt32(DT1.Rows[0]["ID"]);
                

            }
            else
            {
                ClassReturned.PartID=0;
                
            }
            DataView dv1 = new DataView(DT1);
            listBoxPartCodeReturned.DisplayMember = "Name";
            listBoxPartCodeReturned.ValueMember = "ID";
            listBoxPartCodeReturned.DataSource = dv1;
        }

        private void FormReturned_Load(object sender, EventArgs e)
        {
            Size size = new Size(Screen.PrimaryScreen.WorkingArea.Size.Width, Screen.PrimaryScreen.WorkingArea.Size.Height);
            this.Height = size.Height;
            this.Width = size.Width;
            Point p = new Point(0, 0);
            this.Location = p;

            textBoxOrderCode.Text = ClassReturned.OrderCode.ToString();
            textBoxWeight.Text = ClassReturned.Weight.ToString();
            textBoxNumberOFBatch.Text = ClassReturned.Amount1.ToString();
            textBoxPartCodeReturnedEdit_TextChanged(sender, e);
        }

        private void pictureBoxNext_Click(object sender, EventArgs e)
        {
            string Creator = "2b2f093d-19c0-4abd-b4b8-512cdacd97ab";
            string modifier = "2b2f093d-19c0-4abd-b4b8-512cdacd97ab";
            int Result;


            if (textBoxPartCodeReturnedView.Text.Trim() == "")
            {
                MessageBox.Show("کالای برگشتی را انتخاب نمایید", "سیستم");
                textBoxPartCodeReturnedView.Focus();
            }
            else
            {
                
                connection.Open();
                command = new SqlCommand("insert into ProductiveDetails (OrderCodeID,ProductionLineID,PartID,OperatorID,IO,Amount,Amount1,Returned,Waste,IP,State,Creator,AddDate,LastModifier,LastModificationDate) VALUES (" + ClassReturned.OrderCode + "," + ClassSetting.ProductionLineID + "," + ClassReturned.PartID + "," + ClassOperator.OperatorID + "," + 1 + "," + ClassReturned.Weight+","+ClassReturned.Amount1 +","+ 1 +","+0 + ",'" + ClassSetting.IP + "'," + 1 + ",'" + Creator + "','" + DateTime.Now + "','" + modifier + "','" + DateTime.Now + "')", connection);
                Result = command.ExecuteNonQuery();


                if (Result == 1)
                {
                    MessageBox.Show("با موفقیت ثبت شد", "سیستم");
                }
                connection.Close();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxPartCodeReturned_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPartCodeReturnedView_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
