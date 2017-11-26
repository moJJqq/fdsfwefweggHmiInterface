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
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            InitializeComponent();
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            Size size = new Size(Screen.PrimaryScreen.WorkingArea.Size.Width, Screen.PrimaryScreen.WorkingArea.Size.Height);
            this.Height = size.Height;
            this.Width = size.Width;
            Point p = new Point(0, 0);
            this.Location = p;

            textBoxIP.Text = ClassSetting.IP;
            textBoxProductionLine.Text = ClassSetting.ProductionLineID.ToString();
            textBoxComPort.Text = ClassSetting.ComPort;
            checkBoxShowContainer.Checked = ClassSetting.ShowContainer;
            checkBoxShowDestinationOrderCode.Checked = ClassSetting.ShowOrderDestination;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\LocalDBTowzin.mdf;Integrated Security=True");
            SqlCommand command;
            
            int Result;

            int ShowContainer =Convert.ToInt32( checkBoxShowContainer.Checked);
            int ShowOrderDestination =Convert.ToInt32( checkBoxShowDestinationOrderCode.Checked);

            if (textBoxIP.Text.Trim() == "")
            {
                MessageBox.Show("IP نباید خالی باشد", "سیستم");
                textBoxIP.Focus();
            }
            else if (textBoxProductionLine.Text.Trim() == "")
            {
                MessageBox.Show("شماره خط تولید نمی تواند خالی باشد", "سیستم");
                textBoxProductionLine.Focus();
            }
            else if (textBoxComPort.Text.Trim() == "")
            {
                MessageBox.Show("شماره پورت نمی تواند خالی باشد", "سیستم");
                textBoxComPort.Focus();
            }
            else
            {
                connection.Open();
                command = new SqlCommand("update Setting set IP='" + textBoxIP.Text + "',ProductionLineID=" + textBoxProductionLine.Text + ",ComPort='" + textBoxComPort.Text + "',ShowContainer=" + ShowContainer + ",ShowOrderDestination=" + ShowOrderDestination , connection);
                Result = command.ExecuteNonQuery();


                if (Result == 1)
                {
                    MessageBox.Show("با موفقیت ثبت شد", "سیستم");
                    ClassSetting.IP = textBoxIP.Text;
                    ClassSetting.ProductionLineID =Convert.ToInt32( textBoxProductionLine.Text);
                    ClassSetting.ComPort = textBoxComPort.Text;
                    ClassSetting.ShowContainer = checkBoxShowContainer.Checked;
                    ClassSetting.ShowOrderDestination = checkBoxShowDestinationOrderCode.Checked;
                }
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
