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
    public partial class OpeningForm : Form
    {
        public OpeningForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void HOME_btn_Click(object sender, EventArgs e)
        {
           Form1 i = new Form1();
            i.Show();
            this.Hide();

        }

        private void btn_backToHelp_Click(object sender, EventArgs e)
        {
           InfoForm F = new InfoForm();
            F.Show();
            this.Hide();
        }

        private void OpeningForm_Load(object sender, EventArgs e)
        {

        }
    }
}
