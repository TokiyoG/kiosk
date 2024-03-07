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
    public partial class DiscountForm : Form
    {
        public DiscountForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void DiscountForm_Load(object sender, EventArgs e)
        {

        }

        private void HOME_btn_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }
    }
}
