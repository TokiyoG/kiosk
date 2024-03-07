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
    public partial class amazon : Form
    {
        public amazon()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void amazon_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            this.Hide();
            F.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_backToHelp_Click(object sender, EventArgs e)
        {
            ShoppingForm S = new ShoppingForm();
            this.Hide();
            S.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void picBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void Btncontroll_Click(object sender, EventArgs e)
        {


            fontDialog1.ShowColor = true;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                lblTex.Font = fontDialog1.Font;
                lblTex.ForeColor = fontDialog1.Color;
                label1.Font = fontDialog1.Font;
                label1.ForeColor = fontDialog1.Color;
            }

        }
    }
}
