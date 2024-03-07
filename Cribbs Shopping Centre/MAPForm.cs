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
    public partial class MAPForm : Form
    {
        public MAPForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_backToHelp_Click(object sender, EventArgs e)
        {
            InfoForm F = new InfoForm();
            F.Show();
            this.Hide();
        }

        private void HOME_btn_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }
    }
}
