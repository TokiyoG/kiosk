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
    public partial class FOOD : Form
    {
        public FOOD()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void FOOD_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShoppingForm F1 = new ShoppingForm();
            F1.Show();
            this.Hide();
        }
    }
}
