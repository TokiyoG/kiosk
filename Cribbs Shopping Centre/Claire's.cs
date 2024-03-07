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
    public partial class Claire_s : Form
    {
        public Claire_s()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btn_backToHelp_Click(object sender, EventArgs e)
        {
            ShoppingForm S = new ShoppingForm();
            this.Hide();
            S.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            this.Hide();
            F.Show();
        }

        private void Btncontroll_Click(object sender, EventArgs e)
        {


            fontDialog1.ShowColor = true;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                LBL1.Font = fontDialog1.Font;
                LBL1.ForeColor = fontDialog1.Color;
                label1.Font = fontDialog1.Font;
                label1.ForeColor = fontDialog1.Color;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
