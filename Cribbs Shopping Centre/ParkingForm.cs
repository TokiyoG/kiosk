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
    public partial class ParkingForm : Form
    {
        public ParkingForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void HOME_btn_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Btncontroll_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                LBL1.Font = fontDialog1.Font;
                LBL1.ForeColor = fontDialog1.Color;

            }
        }
    }
}
