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
    public partial class FormGetMaterials : Form
    {
        public FormGetMaterials()
        {
            InitializeComponent();
        }

        private void FormGetMaterials_Load(object sender, EventArgs e)
        {
            Size size = new Size(Screen.PrimaryScreen.WorkingArea.Size.Width, Screen.PrimaryScreen.WorkingArea.Size.Height);
            this.Height = size.Height;
            this.Width = size.Width;
            Point p = new Point(0, 0);
            this.Location = p;

            textBoxSerialEdit_TextChanged(sender, e);
            textBoxPartCodeEdit_TextChanged(sender, e);
            textBoDestinationOrderCodeEdit_TextChanged(sender, e);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSerialView_GotFocus(object sender, EventArgs e)
        {


            listBoxSerial.Visible = true;
            textBoxSerialEdit.Visible = true;


        }

        private void textBoxSerialEdit_LostFocus(object sender, EventArgs e)
        {
            if (listBoxSerial.Focused != true)
            {
                textBoxSerialEdit.Visible = false;
                listBoxSerial.Visible = false;
                textBoxFocus.Focus();
            }

        }

        private void listBoxSerial_LostFocus(object sender, EventArgs e)
        {
            if (textBoxSerialEdit.Focused != true)
            {
                textBoxSerialEdit.Visible = false;
                listBoxSerial.Visible = false;
                textBoxFocus.Focus();
            }
        }

        private void textBoxSerialEdit_TextChanged(object sender, EventArgs e)
        {
            try
            {
               
                string searchCombo = textBoxSerialEdit.Text;
                string Query = "SELECT dbo.ProductiveDetails.OrderCodeID, dbo.Part.Name, dbo.ProductiveDetails.PartID, dbo.Part.PartCode, dbo.ProductiveDetails.Amount, dbo.ProductiveDetails.Amount1, dbo.ProductiveDetails.Serial FROM  dbo.ProductiveDetails INNER JOIN  dbo.Part ON dbo.ProductiveDetails.PartID = dbo.Part.ID where serial like '%" + textBoxSerialEdit.Text + "%'";
                SqlDataAdapter DA1 = new SqlDataAdapter(Query, ClassDatabase.ConnectionServer);

                ClassDatabase.ConnectionServer.Open();
                DataTable DT1 = new DataTable();
                DA1.Fill(DT1);
                ClassDatabase.ConnectionServer.Close();

                DataView dv1 = new DataView(DT1);
                listBoxSerial.DisplayMember = "serial";
                listBoxSerial.ValueMember = "serial";
                listBoxSerial.DataSource = dv1;
            }
            catch
            {
                MessageBox.Show("امکان برقراری ارتباط با سرور وجود ندارد لطفا با واحد فنی تماس بگیرید", "مدیر سیستم");
            }
        }

        private void textBox1_GotFocus(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBoxSerial_Click(object sender, EventArgs e)
        {
            try
            {

                if (listBoxSerial.SelectedValue != null)
                {
                    textBoxSerialView.Text = listBoxSerial.SelectedValue.ToString();
                   
                    string searchCombo = textBoxSerialEdit.Text;
                    string Query = "SELECT dbo.ProductiveDetails.OrderCodeID, dbo.Part.Name, dbo.ProductiveDetails.PartID, dbo.Part.PartCode, dbo.ProductiveDetails.Amount, dbo.ProductiveDetails.Amount1, dbo.ProductiveDetails.Serial FROM  dbo.ProductiveDetails INNER JOIN  dbo.Part ON dbo.ProductiveDetails.PartID = dbo.Part.ID where serial like '%" + textBoxSerialView.Text + "%'";
                    SqlDataAdapter DA1 = new SqlDataAdapter(Query, ClassDatabase.ConnectionServer);

                    ClassDatabase.ConnectionServer.Open();
                    DataTable DT1 = new DataTable();
                    DA1.Fill(DT1);
                    ClassDatabase.ConnectionServer.Close();
                    textBoxFromOrder.Text = DT1.Rows[0]["OrderCodeID"].ToString();
                    textBoxPartCodeView.Text = DT1.Rows[0]["PartCode"].ToString();
                    textBoxWeight.Text = DT1.Rows[0]["Amount"].ToString();
                    textBoxAmount1.Text = DT1.Rows[0]["Amount1"].ToString();
                    textBoxPartName.Text = DT1.Rows[0]["Name"].ToString();

                    DataView dv1 = new DataView(DT1);
                    listBoxSerial.Visible = false;
                    textBoxSerialEdit.Visible = false;
                }
            }
            catch
            {
                MessageBox.Show("امکان برقراری ارتباط با سرور وجود ندارد لطفا با واحد فنی تماس بگیرید", "مدیر سیستم");
            }
        }

        private void listBoxSerial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxManual_CheckedChanged(object sender, EventArgs e)
        {

            textBoxFromOrder.ReadOnly = !checkBoxManual.Checked;
            textBoxPartCodeEdit.ReadOnly = !checkBoxManual.Checked;
            textBoxPartCodeView.ReadOnly = !checkBoxManual.Checked;
            textBoxPartName.ReadOnly = !checkBoxManual.Checked;
            textBoxWeight.ReadOnly = !checkBoxManual.Checked;
            textBoxAmount1.ReadOnly = !checkBoxManual.Checked;

        }

        private void textBoxSerialView_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDestinationOrdeCodeView_GotFocus(object sender, EventArgs e)
        {
            textBoDestinationOrderCodeEdit.Visible = true;
            listBoxDestinationOrdeCode.Visible = true;
            textBoDestinationOrderCodeEdit.Focus();
        }

        private void textBoDestinationOrderCodeEdit_LostFocus(object sender, EventArgs e)
        {
            if (listBoxDestinationOrdeCode.Focused != true)
            {
                textBoDestinationOrderCodeEdit.Visible = true;
                listBoxDestinationOrdeCode.Visible = true;
                textBoxFocus.Focus();
            }
        }

        private void textBoDestinationOrderCodeEdit_TextChanged(object sender, EventArgs e)
        {
            try
            {
              
                string searchCombo = textBoxSerialEdit.Text;

                ///string Query = "SELECT  [IP],[OrderCode],str([OrderCode])+ '---'+[ProductionLineName] AS OrderLine,[OrderStatusID],[ID],[ProductionLineName],[SendOrderCode],[ProductionLineLatinName],[Region],[SendGari] FROM [Towzin].[dbo].[vwDeviceOrders] where ip='" + ClassSetting.IP+"'";
                string Query = "SELECT  [IP],[OrderCode],str([OrderCode])+ '---'+[ProductionLineName] AS OrderLine,[OrderStatusID],[ID],[ProductionLineName],[SendOrderCode],[ProductionLineLatinName],[Region],[SendGari] FROM [Towzin].[dbo].[vwDeviceOrders]";
                SqlDataAdapter DA1 = new SqlDataAdapter(Query, ClassDatabase.ConnectionServer);

                ClassDatabase.ConnectionServer.Open();
                DataTable DT1 = new DataTable();
                DA1.Fill(DT1);
                ClassDatabase.ConnectionServer.Close();

                DataView dv1 = new DataView(DT1);
                listBoxDestinationOrdeCode.DisplayMember = "OrderLine";
                listBoxDestinationOrdeCode.ValueMember = "ID";
                listBoxDestinationOrdeCode.DataSource = dv1;
            }
            catch
            {
                MessageBox.Show("امکان برقراری ارتباط با سرور وجود ندارد لطفا با واحد فنی تماس بگیرید", "مدیر سیستم");
            }
        }

        private void listBoxDestinationOrdeCode_LostFocus(object sender, EventArgs e)
        {
            textBoDestinationOrderCodeEdit_LostFocus(sender, e);
        }

        private void listBoxDestinationOrdeCode_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxDestinationOrdeCode.SelectedValue != null)
                {
                    textBoxDestinationOrdeCodeView.Text = listBoxDestinationOrdeCode.Text.ToString();
                    
                    string searchCombo = textBoxDestinationOrdeCodeView.Text;
                    string Query = "SELECT  [IP],[OrderCode],[OrderStatusID],[ID],[ProductionLineName],[SendOrderCode],[ProductionLineLatinName],[Region],[SendGari] FROM [Towzin].[dbo].[vwDeviceOrders] where str(ID)=" + listBoxDestinationOrdeCode.SelectedValue.ToString();
                    SqlDataAdapter DA1 = new SqlDataAdapter(Query, ClassDatabase.ConnectionServer);
                    ClassDatabase.ConnectionServer.Open();
                    DataTable DT1 = new DataTable();
                    DA1.Fill(DT1);
                    ClassDatabase.ConnectionServer.Close();
                    ClassGetMaterial.DestinationProductionLineID = Convert.ToUInt32(listBoxDestinationOrdeCode.SelectedValue.ToString());
                    ClassGetMaterial.DestinationOrderCode = Convert.ToInt32(DT1.Rows[0]["OrderCode"]);
                    ClassGetMaterial.IP = DT1.Rows[0]["IP"].ToString();

                    DataView dv1 = new DataView(DT1);
                    listBoxDestinationOrdeCode.Visible = false;
                    textBoDestinationOrderCodeEdit.Visible = false;
                }
            }
            catch
            {
                MessageBox.Show("امکان برقراری ارتباط با سرور وجود ندارد لطفا با واحد فنی تماس بگیرید", "مدیر سیستم");
            }
        }

        private void listBoxDestinationOrdeCode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxNext_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPartCodeView_GotFocus(object sender, EventArgs e)
        {
            listBoxPartCode.Visible = true;
            textBoxPartCodeEdit.Visible = true;

        }

        private void textBoxPartCodeEdit_LostFocus(object sender, EventArgs e)
        {

            if (listBoxPartCode.Focused != true)
            {

                textBoxPartCodeEdit.Visible = false;
                listBoxPartCode.Visible = false;
                textBoxFocus.Focus();
            }

        }

        private void listBoxPartCode_LostFocus(object sender, EventArgs e)
        {
            if (textBoxPartCodeEdit.Focused != true)
            {

                textBoxPartCodeEdit.Visible = false;
                listBoxPartCode.Visible = false;
                textBoxFocus.Focus();
            }
        }

        private void textBoxPartCodeEdit_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBoxFromOrder.Text.Trim() == "")
                {
                    
                    string searchCombo = textBoxPartCodeEdit.Text;
                    string Query = "SELECT [Name],[PartCode],[Name]+' - '+[PartCode] as NamePartCode,[ID] FROM [Towzin].[dbo].[VW_Part_Index] where Name Like N'%" + searchCombo + "%' or PartCode Like N'%" + searchCombo + "%'";
                    SqlDataAdapter DA1 = new SqlDataAdapter(Query, ClassDatabase.ConnectionServer);
                    ClassDatabase.ConnectionServer.Open();
                    DataTable DT1 = new DataTable();
                    DA1.Fill(DT1);
                    ClassDatabase.ConnectionServer.Close();

                    DataView dv1 = new DataView(DT1);
                    listBoxPartCode.DisplayMember = "NamePartCode";
                    listBoxPartCode.ValueMember = "PartCode";
                    listBoxPartCode.DataSource = dv1;
                }
                else
                {
                    
                    string searchCombo = textBoxPartCodeEdit.Text;
                    string Query = "SELECT [OrderCodeID],[Name],[PartCode],[Name]+' - '+[PartCode] as NamePartCode,[PartID] FROM [Towzin].[dbo].[VW_OrderPart_Index] where str(OrderCodeID) like '%" + textBoxFromOrder.Text + "%' and (Name like N'%" + searchCombo + "%' or PartCode like N'%" + searchCombo + "%')";
                    SqlDataAdapter DA1 = new SqlDataAdapter(Query, ClassDatabase.ConnectionServer);
                    ClassDatabase.ConnectionServer.Open();
                    DataTable DT1 = new DataTable();
                    DA1.Fill(DT1);
                    ClassDatabase.ConnectionServer.Close();

                    DataView dv1 = new DataView(DT1);
                    listBoxPartCode.DisplayMember = "NamePartCode";
                    listBoxPartCode.ValueMember = "PartCode";
                    listBoxPartCode.DataSource = dv1;

                }
            }
            catch
            {
                MessageBox.Show("امکان برقراری ارتباط با سرور وجود ندارد لطفا با واحد فنی تماس بگیرید", "مدیر سیستم");
            }
        }

        private void listBoxPartCode_Click(object sender, EventArgs e)
        {
            try {
            if (listBoxPartCode.SelectedValue != null)
            {
                textBoxPartCodeView.Text = listBoxPartCode.SelectedValue.ToString();
               
                string searchCombo = textBoxDestinationOrdeCodeView.Text;
                string Query = "SELECT [Name],[PartCode],[Name]+' - '+[PartCode] as NamePartCode,[ID] FROM [Towzin].[dbo].[VW_Part_Index] where PartCode='" + listBoxPartCode.SelectedValue.ToString() + "'";
                SqlDataAdapter DA1 = new SqlDataAdapter(Query, ClassDatabase.ConnectionServer);
                ClassDatabase.ConnectionServer.Open();
                DataTable DT1 = new DataTable();
                DA1.Fill(DT1);
                ClassDatabase.ConnectionServer.Close();
                ClassGetMaterial.PartID = Convert.ToInt64(DT1.Rows[0]["ID"]);
                textBoxPartName.Text = DT1.Rows[0]["Name"].ToString();
                listBoxPartCode.Visible = false;
                textBoxPartCodeEdit.Visible = false;
            }
            }
            catch
            {
                MessageBox.Show("امکان برقراری ارتباط با سرور وجود ندارد لطفا با واحد فنی تماس بگیرید", "مدیر سیستم");
            }
        }

        private void textBoxPartName_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
