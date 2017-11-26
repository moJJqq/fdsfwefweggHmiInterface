using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace HMIInterface1
{
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();

        }




        private void Form1_Load(object sender, EventArgs e)
        {
            Size size = new Size(Screen.PrimaryScreen.WorkingArea.Size.Width, Screen.PrimaryScreen.WorkingArea.Size.Height);
            this.Height = size.Height;
            this.Width = size.Width;
            Point p = new Point(0, 0);
            this.Location = p;
            panel1.Size = size;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text.Trim() == "")
            {
                textBoxUserName.Focus();
            }
            else if (textBoxPassword.Text.Trim() == "")
            {
                textBoxPassword.Focus();
            }
            else
            {

                try
                {
                    string QueryCompany = "SELECT * FROM Operator where OperatorID=" + textBoxUserName.Text + " and Password='" + textBoxPassword.Text + "'";
                    SqlDataAdapter DA1 = new SqlDataAdapter(QueryCompany, ClassDatabase.ConnectionServer);


                    ClassDatabase.ConnectionServer.Open();


                    DataTable DT1 = new DataTable();
                    DA1.Fill(DT1);
                    ClassDatabase.ConnectionServer.Close();
                    if (DT1.Rows.Count > 0)
                    {
                        Home form1 = new Home();
                        FormHome formHome = new FormHome();
                        ClassOperator.OperatorID = Convert.ToInt64(textBoxUserName.Text);
                        ClassOperator.OperatorName = DT1.Rows[0]["OperatorName"].ToString();
                        ClassOperator.Password = textBoxPassword.Text;
                        formHome.Show();

                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("نام کاربری یا کلمه عبور اشتباه است", "سیستم");
                        textBoxUserName.Focus();
                    }
                }
                catch
                {
                    MessageBox.Show("امکان برقراری ارتباط با سرور وجود ندارد لطفا با واحد فنی تماس بگیرید", "مدیر سیستم");
                }
            }

        }

        private void textBoxUserName_GotFocus(object sender, EventArgs e)
        {
            // System.Diagnostics.Process.Start("tabtip.exe");

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
