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
using System.Management;
using EasyModbus;

namespace HMIInterface1
{

    public partial class FormHome : Form
    {
        ModbusClient svimaster = new ModbusClient("com3");


        public FormHome()
        {

            InitializeComponent();


        }

        private void textBoxOrderEdit_GotFocus(object sender, EventArgs e)
        {
            listBoxOrder.Visible = true;
        }

        private void textBoxOrderEdit_LostFocus(object sender, EventArgs e)
        {
            if (listBoxOrder.Focused == false)
            {
                listBoxOrder.Visible = false;
                textBoxOrderEdit.Visible = false;
            }
        }

        private void textBoxOrderEdit_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=192.168.1.11\Towzin;Initial Catalog=Towzin;User ID=towzin;Password=123456;MultipleActiveResultSets=true");
            string searchCombo = textBoxOrderEdit.Text;
            string Query = "SELECT IP,OrderCode,OrderStatusID,Region FROM vwDeviceOrders where CONVERT(varchar(10), OrderCode) like '%" + searchCombo + "%'";
            SqlDataAdapter DA1 = new SqlDataAdapter(Query, con);
            con.Open();
            DataTable DT1 = new DataTable();
            DA1.Fill(DT1);
            con.Close();
            DataView dv1 = new DataView(DT1);
            listBoxOrder.DisplayMember = "OrderCode";
            listBoxOrder.ValueMember = "OrderCode";
            listBoxOrder.DataSource = dv1;
        }

        private void listBoxOrder_LostFocus(object sender, EventArgs e)
        {
            listBoxOrder.Visible = false;
            textBoxOrderEdit.Visible = false;
        }

        private void listBoxOrder_Click(object sender, EventArgs e)
        {
            if (listBoxOrder.SelectedValue != null)
            {
                textBoxOrderEdit.Text = listBoxOrder.SelectedValue.ToString();
                textBoxOrderView.Text = listBoxOrder.SelectedValue.ToString();
                textBoxFocus.Focus();
                listBoxOrder.Visible = false;
                textBoxOrderEdit.Visible = false;
                textBoxProductEdit_TextChanged(sender, e);
            }
        }

        private void textBoxOrderView_GotFocus(object sender, EventArgs e)
        {
            textBoxOrderEdit.Visible = true;
            textBoxOrderEdit.Focus();
        }
        /// for product Combo box
        private void textBoxProductEdit_GotFocus(object sender, EventArgs e)
        {
            listBoxProduct.Visible = true;
        }

        private void textBoxProductEdit_LostFocus(object sender, EventArgs e)
        {
            if (listBoxProduct.Focused == false)
            {
                listBoxProduct.Visible = false;
                textBoxProductEdit.Visible = false;
            }
        }

        private void textBoxProductEdit_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=192.168.1.11\Towzin;Initial Catalog=Towzin;User ID=towzin;Password=123456;MultipleActiveResultSets=true");
            string searchCombo = textBoxProductEdit.Text;
            string QueryCompany =
            string.Format(
            "SELECT [OrderCode],[PartCode],[ID],[PartCode]+ ' '+[Name] as PartCodeName,[Name]  FROM vwOrderParts where (PartCode like N'%" + searchCombo + "%' or [Name] like N'%" + searchCombo + "%') and OrderCode=" + textBoxOrderView.Text);
            SqlDataAdapter DA1 = new SqlDataAdapter(QueryCompany, con);
            con.Open();
            DataTable DT1 = new DataTable();
            DA1.Fill(DT1);
            if (DT1.Rows.Count == 1)
            {
                ClassWaste.PartID = Convert.ToInt32(DT1.Rows[0]["ID"]);
                ClassWaste.PartName = DT1.Rows[0]["Name"].ToString();
                ClassWaste.PartCode = DT1.Rows[0]["PartCode"].ToString();
                ClassProduct.PartID = Convert.ToInt32(DT1.Rows[0]["ID"]);
            }
            else
            {
                ClassWaste.PartID = 0;
                ClassWaste.PartName = "";
                ClassWaste.PartCode = "";
                ClassProduct.PartID = 0;
            }

            con.Close();

            DataView dv1 = new DataView(DT1);
            listBoxProduct.DisplayMember = "Name";
            listBoxProduct.ValueMember = "PartCode";
            listBoxProduct.DataSource = dv1;
        }

        private void listBoxProduct_LostFocus(object sender, EventArgs e)
        {
            listBoxProduct.Visible = false;
            textBoxProductEdit.Visible = false;
        }

        private void listBoxProduct_Click(object sender, EventArgs e)
        {
            if (listBoxProduct.SelectedValue != null)
            {


                textBoxProductEdit.Text = listBoxProduct.SelectedValue.ToString();
                textBoxProductView.Text = listBoxProduct.SelectedValue.ToString() + " --- " + listBoxProduct.GetItemText(listBoxProduct.SelectedItem);
                textBoxFocus.Focus();
                listBoxProduct.Visible = false;
                textBoxProductEdit.Visible = false;
            }
        }










        private void textBoxProductView_GotFocus(object sender, EventArgs e)
        {
            if (textBoxOrderView.Text != "")
            {
                textBoxProductEdit.Visible = true;
                textBoxProductEdit.Focus();
            }
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            Size size = new Size(Screen.PrimaryScreen.WorkingArea.Size.Width, Screen.PrimaryScreen.WorkingArea.Size.Height);
            this.Height = size.Height;
            this.Width = size.Width;
            Point p = new Point(0, 0);
            this.Location = p;

            labelUserName.Text = labelUserName.Text + ClassOperator.OperatorName;
            SqlConnection con = new SqlConnection(@"Data Source=192.168.1.11\Towzin;Initial Catalog=Towzin;User ID=towzin;Password=123456;MultipleActiveResultSets=true");
            string searchCombo = textBoxOrderEdit.Text;
            string QueryCompany =
            string.Format(
            "SELECT IP,OrderCode,OrderStatusID,Region FROM vwDeviceOrders ");
            SqlDataAdapter DA1 = new SqlDataAdapter(QueryCompany, con);
            con.Open();
            DataTable DT1 = new DataTable();
            DA1.Fill(DT1);
            con.Close();

            DataView dv1 = new DataView(DT1);

            listBoxOrder.DisplayMember = "OrderCode";
            listBoxOrder.ValueMember = "OrderCode";
            listBoxOrder.DataSource = dv1;

            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\LocalDBTowzin.mdf;Integrated Security=True");

            string Query = "SELECT * FROM Setting";
            DA1 = new SqlDataAdapter(Query, con);
            con.Open();
            DT1 = new DataTable();
            DA1.Fill(DT1);
            con.Close();
            ClassSetting.ShowContainer = Convert.ToBoolean(DT1.Rows[0][0]);
            ClassSetting.ShowOrderDestination = Convert.ToBoolean(DT1.Rows[0][1]);
            ClassSetting.IP = DT1.Rows[0]["IP"].ToString();
            ClassSetting.ProductionLineID = Convert.ToInt32(DT1.Rows[0][3]);
            ClassSetting.ComPort = DT1.Rows[0]["ComPort"].ToString();

        }

        private void buttonPareSang_Click(object sender, EventArgs e)
        {
            textBoxNumberOfPareSnag.Text = textBoxWeight.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxShowNext_Click(object sender, EventArgs e)
        {
            pictureBoxShowNext.Visible = false;
            pictureBoxNext.Visible = true;
            pictureBoxNext.Focus();
        }

        private void pictureBoxNext_LostFocus(object sender, EventArgs e)
        {
            pictureBoxNext.Visible = false;
            pictureBoxShowNext.Visible = true;
        }

        private void pictureBoxNext_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBoxNext_MouseDown(object sender, MouseEventArgs e)
        {
            if (textBoxWeight.Value == 99999999 || checkBoxManualWeight.Checked == false)
            {
                MessageBox.Show(" ارتباط با لودسل ها دچار مشکل شده لطفا با تیم فنی هماهنگ کنید ", "سیستم");
            }
            else
            {

                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\LocalDBTowzin.mdf;Integrated Security=True");

                string Query = "SELECT * FROM Setting";
                SqlDataAdapter DA1 = new SqlDataAdapter(Query, con);
                con.Open();
                DataTable DT1 = new DataTable();
                DA1.Fill(DT1);
                con.Close();
                textBoxFocus.Text = e.X.ToString() + " " + e.Y.ToString();

                ///bargashti
                if (e.X > 1 && e.X < 127)
                {
                    if (textBoxOrderView.Text.Trim() == "")
                    {

                        MessageBox.Show("شماره سفارش وارد نشده است");
                        textBoxOrderView.Focus();
                    }
                    else
                    {
                        ClassReturned.OrderCode = Convert.ToInt64(textBoxOrderView.Text);
                        ClassReturned.Weight = Convert.ToSingle(textBoxWeight.Text);
                        ClassReturned.Amount1 = Convert.ToSingle(textBoxNumberOfBatch.Text);
                        FormReturned formReturned = new FormReturned();
                        formReturned.Show();
                    }


                }
                //ersal mavad
                else if (e.X > 128 && e.X < 231)
                {
                    FormGetMaterials formGetMaterials = new FormGetMaterials();
                    formGetMaterials.Show();

                }
                //Tavaghfat
                else if (e.X > 232 && e.X < 332)
                {

                }
                //zaye'at
                else if (e.X > 333 && e.X < 428)
                {
                    DialogResult dialogResult = new DialogResult();
                    if (textBoxOrderView.Text.Trim() == "")
                    {
                        MessageBox.Show("شماره سفارش وارد نشده است");
                        textBoxOrderView.Focus();
                    }

                    else
                    {
                        if (textBoxProductView.Text.Trim() == "")
                        {
                            dialogResult = MessageBox.Show("کد کالا وارد نشده آیا مطمئن هستید که ضایعات به کل سفارش ارسال شود", "سیستم", MessageBoxButtons.YesNo);
                        }


                        if (dialogResult == DialogResult.Yes || textBoxProductView.Text != "")
                        {
                            ClassWaste.OrderCode = Convert.ToInt64(textBoxOrderView.Text);
                            ClassWaste.Formula = textBoxFormula.Text;
                            ClassWaste.Weight = Convert.ToSingle(textBoxWeight.Text);
                            FormWaste formWaste = new FormWaste();
                            formWaste.Show();

                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            textBoxProductView.Focus();
                        }
                    }

                }
                //mahsol
                else if (e.X > 429 && e.X < 520)
                {



                    if (textBoxOrderView.Text.Trim() == "")
                    {

                        MessageBox.Show("شماره سفارش وارد نشده است");
                        textBoxOrderView.Focus();

                    }
                    else if (textBoxProductView.Text.Trim() == "")
                    {
                        MessageBox.Show("کد کالا وارد نشده است");
                        textBoxProductView.Focus();
                    }
                    ///show ProductiveDetails
                    else
                    {
                        textBoxFocus.Text = ClassSetting.IP;
                        ClassProduct.OrderCode = Convert.ToInt64(textBoxOrderView.Text);
                        ClassProduct.PartCode = textBoxProductEdit.Text;
                        ClassProduct.PartName = textBoxProductView.Text;
                        ClassProduct.Formula = textBoxFormula.Text;

                        ClassProduct.Weight = Convert.ToSingle(textBoxWeight.Value);
                        ClassProduct.NumberOfBatch = Convert.ToSingle(textBoxNumberOfBatch.Value);
                        FormSendProduct formSendProduct = new FormSendProduct();
                        formSendProduct.Show();


                    }



                }
                pictureBoxNext.Visible = false;
                pictureBoxShowNext.Visible = true;
            }


        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void timerSyncLocalDB_Tick(object sender, EventArgs e)
        {



        }

        private void buttonSendList_Click(object sender, EventArgs e)
        {
            FormSendList formSendList = new FormSendList();


            formSendList.Show();

        }

        private void textBoxOrderView_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonProductClear_Click(object sender, EventArgs e)
        {

            textBoxProductView.Text = "";
            textBoxProductEdit.Text = "";
        }

        private void buttonOrderClear_Click(object sender, EventArgs e)
        {
            textBoxProductEdit.Text = "";
            textBoxProductView.Text = "";

            textBoxOrderView.Text = "";
            textBoxOrderEdit.Text = "";


        }

        private void button1_Click(object sender, EventArgs e)
        {

            string serialNumber = string.Empty;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_Processor");
            foreach (var o in searcher.Get())
            {
                var query = (ManagementObject)o;

                serialNumber = serialNumber + query["ProcessorId"];
            }
            MessageBox.Show(string.Format("Processor Serial Number :{0}", serialNumber), "Serial Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (svimaster.Connected == false)
                {
                    svimaster.UnitIdentifier = 1;// Not necessary since default slaveID = 1;
                    svimaster.Baudrate = 9600;  // Not necessary since default baudrate = 9600
                    svimaster.Parity = System.IO.Ports.Parity.Even;
                    svimaster.StopBits = System.IO.Ports.StopBits.One;
                    svimaster.ConnectionTimeout = 1000;
                    svimaster.Connect();
                    label1.BackColor = Color.YellowGreen;
                    label1.Text = "Connect";
                }


                if (svimaster.Connected == true)
                {
                    int[] Weight;
                    float NetWeight;
                    Weight = svimaster.ReadInputRegisters(25, 2);
                    NetWeight = ModbusClient.ConvertRegistersToFloat(Weight);
                    textBoxWeight.Text = Convert.ToString(Convert.ToUInt64(NetWeight.ToString()) - Convert.ToUInt64(textBoxNumberOfPareSnag.Text));
                }
            }

            catch
            {
                svimaster.Disconnect();
                try
                {
                    svimaster.Connect();
                }
                catch
                {
                    textBoxWeight.Text = "99999999";
                }

            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Home formLogin = new Home();
            formLogin.Show();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            FormSetting formSetting = new FormSetting();
            formSetting.Show();
        }

        private void checkBoxManualWeight_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxManualWeight.Checked == true)
            {
                timerUpdateWeight.Enabled = !checkBoxManualWeight.Checked;
                textBoxWeight.Value = 0;
            }
            else
            {
                timerUpdateWeight.Enabled = !checkBoxManualWeight.Checked;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("در نظر داشته باشید طول پسورد باید بیشتر از پنج کاراکتر باشد", "مدیر سیستم");
            string BeforePass = "";
            BeforePass = Microsoft.VisualBasic.Interaction.InputBox("پسورد قبلی را وارد کنید", "تغییر پسورد", "", -1, -1);
            string NewPass = "";
            NewPass = Microsoft.VisualBasic.Interaction.InputBox("پسورد جدید را وارد کنید", "تغییر پسورد", "", -1, -1);
            string ConfirmNewPass = "";
            ConfirmNewPass = Microsoft.VisualBasic.Interaction.InputBox("پسورد جدید را دوباره وارد کنید", "تغییر پسورد", "", -1, -1);

            if (BeforePass.Trim() != ClassOperator.Password)
            {
                MessageBox.Show("پسورد قبلی اشتباه است", "مدیر سیستم");
            }
            else if (NewPass != ConfirmNewPass)
            {
                MessageBox.Show("پسورد جدید با تاییدیه مطابقت ندارد", "مدیر سیستم");
            }
            else
            {
                SqlConnection connection = new SqlConnection(@"Data Source=192.168.1.11\Towzin;Initial Catalog=Towzin;User ID=towzin;Password=123456;MultipleActiveResultSets=true");
                SqlCommand command;


                connection.Open();
                command = new SqlCommand("update Operator set Password='" + NewPass + "' where OperatorID=" + ClassOperator.OperatorID, connection);
                int Result = command.ExecuteNonQuery();


                if (Result == 1)
                {
                    MessageBox.Show("با موفقیت ثبت شد", "سیستم");
                    ClassOperator.Password = NewPass;
                }
                connection.Close();
            }
        }



    }
}

