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
    public partial class FormSendProduct : Form
    {

        
        public FormSendProduct()
        {
            InitializeComponent();
        }


        private void FormSendProduct_Load(object sender, EventArgs e)
        {
            Size size = new Size(Screen.PrimaryScreen.WorkingArea.Size.Width, Screen.PrimaryScreen.WorkingArea.Size.Height);
            this.Height = size.Height;
            this.Width = size.Width;
            Point p = new Point(0, 0);
            this.Location = p;
            textBoxOrderDestinationEdit_TextChanged_1(sender, e);



            if (ClassSetting.ShowContainer != true)
            {
                panelContainer.Visible = false;
            }
            if (ClassSetting.ShowOrderDestination != true)
            {
                panelOrderDestination.Visible = false;
            }
            textBoxFormula.Text = ClassProduct.Formula;
            textBoxOrderNumber.Text = ClassProduct.OrderCode.ToString();
            textBoxProductName.Text = ClassProduct.PartName;
            textBoxProduct.Text = ClassProduct.PartCode;
            textBoxWeight.Text = ClassProduct.Weight.ToString();
            textBoxNumberOFBatch.Text = ClassProduct.NumberOfBatch.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxOrderDestinationView_GotFocus(object sender, EventArgs e)
        {
            textBoxOrderDestinationEdit.Visible = true;
            textBoxOrderDestinationEdit.Focus();
        }

        private void textBoxOrderDestinationEdit_GotFocus(object sender, EventArgs e)
        {
            listBoxOrderDestination.Visible = true;

        }
        private void textBoxOrderDestinationEdit_LostFocus(object sender, EventArgs e)
        {
            if (listBoxOrderDestination.Focused != true)
            {
                textBoxOrderDestinationEdit.Visible = false;
                listBoxOrderDestination.Visible = false;
            }
        }



        private void listBoxOrderDestination_LostFocus(object sender, EventArgs e)
        {
            listBoxOrderDestination.Visible = false;
        }

        private void listBoxOrderDestination_Click(object sender, EventArgs e)
        {
            if (listBoxOrderDestination.SelectedValue != null)
            {
                textBoxOrderDestinationEdit.Text = listBoxOrderDestination.SelectedValue.ToString();
                textBoxOrderDestinationView.Text = listBoxOrderDestination.SelectedValue.ToString();
                textBoxProductName.Focus();
                listBoxOrderDestination.Visible = false;
                textBoxOrderDestinationEdit.Visible = false;
            }
        }

        private void listBoxCart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxShowNext_Click(object sender, EventArgs e)
        {
            try
            {
                string Creator = "2b2f093d-19c0-4abd-b4b8-512cdacd97ab";
                string modifier = "2b2f093d-19c0-4abd-b4b8-512cdacd97ab";
                int Result;
                int Result1;
                ClassDatabase.ConnectionServer.Open();
                SqlCommand command;
                //command = new SqlCommand("insert into ProductiveDetails (OrderCodeID,ProductionLineID,PartID,OperatorID,IO,Waste,Amount,Amount1,ToOrderCodeID,ToPartID,State,Creator,AddDate,LastModifier,LastModificationDate) VALUES (" + sourceOrderCode + "," + ProductionLineID + "," + sourcePartID + "," + ClassOperator.OperatorID + "," + 1 + "," + 0 + "," + amount + "," + amount1 + "," + destinationOrderCode + "," + destinationPartID + "," + 1 + ",'" + Creator + "','" + dateTime + "','" + modifier + "','" + dateTime + "')", connection);
                if (textBoxOrderDestinationView.Text.Trim() == "")
                {

                    command = new SqlCommand("insert into ProductiveDetails (OrderCodeID,ProductionLineID,PartID,OperatorID,IO,Waste,Amount,Amount1,FormoulaNumber,Returned,IP,State,Creator,AddDate,LastModifier,LastModificationDate) VALUES (" + ClassProduct.OrderCode + "," + ClassSetting.ProductionLineID + "," + ClassProduct.PartID + "," + ClassOperator.OperatorID + "," + 1 + "," + 0 + "," + (ClassProduct.Weight - ClassProduct.WeightContainer) + "," + ClassProduct.NumberOfBatch + ",'" + ClassProduct.Formula + "'," + 0 + ",'" + ClassSetting.IP + "'," + 1 + ",'" + Creator + "','" + DateTime.Now + "','" + modifier + "','" + DateTime.Now + "')", ClassDatabase.ConnectionServer);
                    Result = command.ExecuteNonQuery();

                }
                else
                {

                    command = new SqlCommand("insert into ProductiveDetails (OrderCodeID,ProductionLineID,PartID,OperatorID,IO,Waste,Amount,Amount1,FormoulaNumber,Returned,IP,ToOrderCodeID,State,Creator,AddDate,LastModifier,LastModificationDate) VALUES (" + ClassProduct.OrderCode + "," + ClassSetting.ProductionLineID + "," + ClassProduct.PartID + "," + ClassOperator.OperatorID + "," + 1 + "," + 0 + "," + (ClassProduct.Weight - ClassProduct.WeightContainer) + "," + ClassProduct.NumberOfBatch + ",'" + ClassProduct.Formula + "'," + 0 + ",'" + ClassSetting.IP + "'," + textBoxOrderDestinationView.Text + "," + 1 + ",'" + Creator + "','" + DateTime.Now + "','" + modifier + "','" + DateTime.Now + "')", ClassDatabase.ConnectionServer);
                    Result = command.ExecuteNonQuery();
                    command = new SqlCommand("insert into ProductiveDetails (OrderCodeID,ProductionLineID,PartID,OperatorID,IO,Waste,Amount,Amount1,FormoulaNumber,Returned,IP,FromOrderCodeID,FromPartID,State,Creator,AddDate,LastModifier,LastModificationDate) VALUES (" + textBoxOrderDestinationView.Text + "," + ClassProduct.ProductionLineIDOrderDestination + "," + ClassProduct.PartID + "," + ClassOperator.OperatorID + "," + 0 + "," + 0 + "," + (ClassProduct.Weight - ClassProduct.WeightContainer) + "," + ClassProduct.NumberOfBatch + ",'" + ClassProduct.Formula + "'," + 0 + ",'" + ClassSetting.IP + "'," + ClassProduct.OrderCode + "," + ClassProduct.PartID + "," + 1 + ",'" + Creator + "','" + DateTime.Now + "','" + modifier + "','" + DateTime.Now + "')", ClassDatabase.ConnectionServer);
                    Result1 = command.ExecuteNonQuery();

                }
                if (Result == 1)
                {
                    MessageBox.Show("محصول با موفقیت ثبت شد", "مدیر سیستم");
                    this.Hide();
                }


                ClassDatabase.ConnectionServer.Close();
            }
            catch
            {
                MessageBox.Show("امکان برقراری ارتباط با سرور وجود ندارد لطفا با واحد فنی تماس بگیرید", "مدیر سیستم");
            }
        }

        private void textBoxOrderDestinationEdit_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                string searchCombo = textBoxOrderDestinationEdit.Text;
                string Query = "SELECT IP,OrderCode,OrderStatusID,Region,ID,str([OrderCode])+' --- '+[ProductionLineName] AS ProductioneLineNameOrderCode FROM vwDeviceOrders where (CONVERT(varchar(10), OrderCode) like '%" + searchCombo + "%') OR (ProductionLineName like '%" + searchCombo + "%')";
                SqlDataAdapter DA1 = new SqlDataAdapter(Query, ClassDatabase.ConnectionServer);

                ClassDatabase.ConnectionServer.Open();
                DataTable DT1 = new DataTable();
                DA1.Fill(DT1);
                ClassDatabase.ConnectionServer.Close();
                if (DT1.Rows.Count == 1)
                {
                    ClassProduct.ProductionLineIDOrderDestination = Convert.ToInt32(DT1.Rows[0]["ID"]);
                    ClassProduct.OrderCodeDestination = Convert.ToInt32(DT1.Rows[0]["OrderCode"]);

                }
                else
                {
                    ClassProduct.ProductionLineIDOrderDestination = 0;
                    ClassProduct.OrderCodeDestination = 0;
                }
                DataView dv1 = new DataView(DT1);
                listBoxOrderDestination.DisplayMember = "ProductioneLineNameOrderCode";
                listBoxOrderDestination.ValueMember = "OrderCode";
                listBoxOrderDestination.DataSource = dv1;
            }
            catch
            {
                MessageBox.Show("امکان برقراری ارتباط با سرور وجود ندارد لطفا با واحد فنی تماس بگیرید", "مدیر سیستم");
            }
        }

        private void textBoxOrderDestinationView_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxOrderDestination_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void listBoxOrderDestination_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBoxContainerView_GotFocus(object sender, EventArgs e)
        {
            textBoxContainerEdit.Visible = true;
            textBoxContainerEdit.Focus();
            textBoxContainerEdit_TextChanged(sender, e);
            listBoxContainer.Visible = true;
        }

        private void textBoxContainerEdit_LostFocus(object sender, EventArgs e)
        {
            if (listBoxContainer.Focused != true)
            {
                textBoxContainerEdit.Visible = false;
                listBoxContainer.Visible = false;
            }
        }

        private void textBoxContainerEdit_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchCombo = textBoxContainerEdit.Text;
                string Query = "SELECT ContainerCode,NetWeight FROM Container where ContainerCode like '%" + searchCombo + "%'";
                SqlDataAdapter DA1 = new SqlDataAdapter(Query, ClassDatabase.ConnectionServer);

                ClassDatabase.ConnectionServer.Open();
                DataTable DT1 = new DataTable();
                DA1.Fill(DT1);
                ClassDatabase.ConnectionServer.Close();

                DataView dv1 = new DataView(DT1);
                listBoxContainer.DisplayMember = "ContainerCode";
                listBoxContainer.ValueMember = "NetWeight";
                listBoxContainer.DataSource = dv1;
            }
            catch
            {
                MessageBox.Show("امکان برقراری ارتباط با سرور وجود ندارد لطفا با واحد فنی تماس بگیرید", "مدیر سیستم");
            }
        }

        private void listBoxContainer_Click(object sender, EventArgs e)
        {
            if (listBoxContainer.SelectedValue != null)
            {
                textBoxContainerView.Text = listBoxContainer.Text;
                textBoxWeightContainer.Text = listBoxContainer.SelectedValue.ToString();

                textBoxContainerEdit.Text = "";
                listBoxContainer.Visible = false;
                textBoxFormula.Focus();
                textBoxContainerEdit.Visible = false;
            }
        }

        private void textBoxContainerView_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxWightContainer_TextChanged(object sender, EventArgs e)
        {

            ClassProduct.WeightContainer = Convert.ToSingle(textBoxWeight.Text);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
