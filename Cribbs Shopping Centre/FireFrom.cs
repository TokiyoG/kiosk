using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cribbs_Shopping_Centre
{
    public partial class FireFrom : Form
    {
        public FireFrom()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Home_btn_Click(object sender, EventArgs e)
        {
            Form1 F54 = new Form1();
           
            this.Hide();
        }

        private void btn_backToHelp_Click(object sender, EventArgs e)
        {
            InfoForm F = new InfoForm();
            F.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
   

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}

