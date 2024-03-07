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
    public partial class ShoppingForm : Form
    {
        public ShoppingForm()
        {
            InitializeComponent();
            CenterToScreen();

        }

        private void ShoppingForm_Load(object sender, EventArgs e)
        {

        }

        private void HOME_btn_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
    
      
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SHOPpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void FOOB_btn_Click(object sender, EventArgs e)
        {
            FOOD Formf = new FOOD();
            Formf.Show();
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            amazon A = new amazon();
            this.Hide();
            A.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            BOOTS b = new BOOTS();
            this.Hide();
            b.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Claire_s c = new Claire_s();
            this.Hide();
            c.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EuroChange E = new EuroChange();
            this.Hide();
            E.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hBeauty h = new hBeauty();
            this.Hide();
            h.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            JOHN J = new JOHN();
            this.Hide();
            J.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MS m = new MS();
            this.Hide();
            m.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SKYcs s = new SKYcs();
            this.Hide();
            s.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Specsavers s = new Specsavers();
            this.Hide();
            s.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Superdrug s = new Superdrug();
            this.Hide();
            s.Show();
        }
    }
}
