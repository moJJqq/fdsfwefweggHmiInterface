using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMIInterface1
{
    public partial class FormSendList : Form
    {
        public FormSendList()
        {
            InitializeComponent();
        }

        private void FormSendList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'towzinDataSet2.VW_ProductiveDetails_Index' table. You can move, or remove it, as needed.
            
            
            this.vW_ProductiveDetails_IndexTableAdapter1.Fill(this.towzinDataSet2.VW_ProductiveDetails_Index);
            
            Size size = new Size(Screen.PrimaryScreen.WorkingArea.Size.Width, Screen.PrimaryScreen.WorkingArea.Size.Height);
            this.Height = size.Height;
            this.Width = size.Width;
            Point p = new Point(0, 0);
            this.Location = p;


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
