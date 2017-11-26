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
    public partial class FormWaste : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=192.168.1.11\Towzin;Initial Catalog=Towzin;User ID=towzin;Password=123456");
        SqlCommand command;
        public FormWaste()
        {
            InitializeComponent();
        }

        private void textBoxLesionView_GotFocus(object sender, EventArgs e)
        {
            textBoxLesionTypeEdit_TextChanged(sender, e);
            textBoxLesionTypeEdit.Visible = true;
            textBoxLesionTypeEdit.Focus();

        }

        private void textBoxLesionTypeEdit_GotFocus(object sender, EventArgs e)
        {

            listBoxLesionType.Visible = true;

        }

        private void textBoxLesionTypeEdit_LostFocus(object sender, EventArgs e)
        {
            if (listBoxLesionType.Focused != true)
            {
                listBoxLesionType.Visible = false;
                textBoxLesionTypeEdit.Visible = false;
            }

        }

        private void textBoxLesionTypeEdit_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=192.168.1.11\Towzin;Initial Catalog=Towzin;User ID=towzin;Password=123456;MultipleActiveResultSets=true");
            string searchCombo = textBoxLesionTypeEdit.Text;
            string Query = "SELECT ID,LesionsName,LesionsLatinName FROM Lesion where  (LesionsName like N'%" + searchCombo + "%')";
            SqlDataAdapter DA1 = new SqlDataAdapter(Query, con);
            con.Open();
            DataTable DT1 = new DataTable();
            DA1.Fill(DT1);
            con.Close();
            if (DT1.Rows.Count == 1)
            {

                ClassWaste.LesionID = Convert.ToInt32(DT1.Rows[0]["ID"]);
                ClassWaste.LesionName = DT1.Rows[0]["LesionsName"].ToString();

                /*            }
                            else
                            {
                                ClassWaste.LesionID = 0;
                                ClassWaste.LesionName = "";*/
            }
            DataView dv1 = new DataView(DT1);
            listBoxLesionType.DisplayMember = "LesionsName";
            listBoxLesionType.ValueMember = "ID";
            listBoxLesionType.DataSource = dv1;
        }

        private void listBoxLesionType_Click(object sender, EventArgs e)
        {
            if (listBoxLesionType.SelectedValue != null)
            {
                ClassWaste.LesionID = Convert.ToInt32(listBoxLesionType.SelectedValue);
                ClassWaste.LesionName = listBoxLesionType.Text;

                textBoxLesionView.Text = listBoxLesionType.Text;
                textBoxLesionTypeEdit.Text = listBoxLesionType.SelectedValue.ToString();
                textBoxFocus.Focus();
                listBoxLesionType.Visible = false;
                textBoxLesionTypeEdit.Visible = false;
            }
        }

        private void textBoxPartWasteCodeEdit_GotFocus(object sender, EventArgs e)
        {
            listBoxPartWasteCode.Visible = true;

        }

        private void textBoxLesionView_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormWaste_Load(object sender, EventArgs e)
        {
            Size size = new Size(Screen.PrimaryScreen.WorkingArea.Size.Width, Screen.PrimaryScreen.WorkingArea.Size.Height);
            this.Height = size.Height;
            this.Width = size.Width;
            Point p = new Point(0, 0);
            this.Location = p;
            textBoxWeight.Text = ClassWaste.Weight.ToString();
            textBoxPartCode.Text = ClassWaste.PartCode;
            textBoxPartName.Text = ClassWaste.PartName;
            textBoxOrderCode.Text = ClassWaste.OrderCode.ToString();

        }

        private void textBoxPartWasteCodeView_GotFocus(object sender, EventArgs e)
        {
            textBoxPartWasteCodeEdit_TextChanged(sender, e);
            textBoxPartWasteCodeEdit.Visible = true;
            textBoxPartWasteCodeEdit.Focus();
        }

        private void textBoxPartWasteCodeEdit_LostFocus(object sender, EventArgs e)
        {
            if (listBoxPartWasteCode.Focused != true)
            {
                textBoxPartWasteCodeEdit.Visible = false;
                listBoxPartWasteCode.Visible = false;
            }
        }

        private void textBoxPartWasteCodeEdit_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=192.168.1.11\Towzin;Initial Catalog=Towzin;User ID=towzin;Password=123456;MultipleActiveResultSets=true");
            string searchCombo = textBoxPartWasteCodeEdit.Text;
            string Query = "SELECT ID,[Name],PartCode +'----'+ [Name] As PartCodeAndName,LatinName,PartCode,PartWesteID,NatureID,[State],SendData   FROM [Towzin].[dbo].[Part] where NatureID=6 and ( [Name] like N'%" + searchCombo + "%' or PartCode like '%" + searchCombo + "%')";
            SqlDataAdapter DA1 = new SqlDataAdapter(Query, con);
            con.Open();
            DataTable DT1 = new DataTable();
            DA1.Fill(DT1);
            con.Close();
            if (DT1.Rows.Count == 1)
            {

                ClassWaste.PartWasteId = Convert.ToInt32(DT1.Rows[0]["ID"]);
                ClassWaste.PartWasteName = DT1.Rows[0]["PartCodeAndName"].ToString();

                /*}
                else
                {
                    ClassWaste.PartWasteId = 0;
                    ClassWaste.PartWasteName = "";*/
            }
            DataView dv1 = new DataView(DT1);
            listBoxPartWasteCode.DisplayMember = "PartCodeAndName";
            listBoxPartWasteCode.ValueMember = "ID";
            listBoxPartWasteCode.DataSource = dv1;
        }

        private void listBoxPartWasteCode_LostFocus(object sender, EventArgs e)
        {
            if (textBoxPartWasteCodeEdit.Focused != true)
            {
                listBoxPartWasteCode.Visible = false;
                textBoxPartWasteCodeEdit.Visible = false;
            }
        }

        private void listBoxPartWasteCode_Click(object sender, EventArgs e)
        {
            if (listBoxPartWasteCode.SelectedValue != null)
            {


                ClassWaste.PartWasteId = Convert.ToInt32(listBoxPartWasteCode.SelectedValue);
                ClassWaste.PartWasteName = listBoxPartWasteCode.Text;

                textBoxPartWasteCodeView.Text = listBoxPartWasteCode.Text;
                textBoxPartWasteCodeEdit.Text = listBoxPartWasteCode.SelectedValue.ToString();
                textBoxFocus.Focus();
                listBoxPartWasteCode.Visible = false;
                textBoxPartWasteCodeEdit.Visible = false;
            }
        }

        private void listBoxPartWasteCode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonLesionClear_Click(object sender, EventArgs e)
        {

            textBoxLesionView.Text = "";
            textBoxLesionTypeEdit.Text = "";
            ClassWaste.LesionID = 0;
            ClassWaste.LesionName = "";
        }

        private void buttonPartWasteCodeClear_Click(object sender, EventArgs e)
        {

            textBoxPartWasteCodeView.Text = "";
            textBoxPartWasteCodeEdit.Text = "";
            ClassWaste.PartWasteId = 0;
            ClassWaste.PartWasteCode = "";
            ClassWaste.PartWasteName = "";

        }

        private void listBoxLesionType_GotFocus(object sender, EventArgs e)
        {
            if (textBoxPartWasteCodeEdit.Focused != true)
            {
                textBoxPartWasteCodeEdit.Visible = false;
                listBoxPartWasteCode.Visible = false;

            }
        }

        private void pictureBoxNext_Click(object sender, EventArgs e)
        {
            string Creator = "2b2f093d-19c0-4abd-b4b8-512cdacd97ab";
            string modifier = "2b2f093d-19c0-4abd-b4b8-512cdacd97ab";
            int Result;


            if (textBoxLesionView.Text.Trim() == "")
            {
                MessageBox.Show("علت ضایعات را انتخاب نمایید", "سیستم");
                textBoxLesionView.Focus();
            }
            else if (textBoxPartWasteCodeView.Text.Trim() == "")
            {
                MessageBox.Show("کد کالای ضایعاتی را انتخاب نمایید", "سیستم");

                textBoxPartWasteCodeView.Focus();
            }
            else
            {


                connection.Open();
                command = new SqlCommand("insert into ProductiveDetails (OrderCodeID,ProductionLineID,PartID,FromPartID,OperatorID,IO,Waste,LesionID,Amount,Returned,IP,State,Creator,AddDate,LastModifier,LastModificationDate) VALUES (" + ClassWaste.OrderCode + "," + ClassSetting.ProductionLineID + "," + ClassWaste.PartWasteId + "," + ClassWaste.PartID + "," + ClassOperator.OperatorID + "," + 1 + "," + 1 + "," + ClassWaste.LesionID + "," + ClassWaste.Weight + "," + 0 + ",'" + ClassSetting.IP + "'," + 1 + ",'" + Creator + "','" + DateTime.Now + "','" + modifier + "','" + DateTime.Now + "')", connection);
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
            this.Hide();
        }

        private void listBoxLesionType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
