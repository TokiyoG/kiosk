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
    public partial class InfoForm : Form
    {
        public InfoForm()
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

        private void btn_opening_Click(object sender, EventArgs e)
        {
           OpeningForm O = new OpeningForm();
           O.Show();
            this.Hide();
        }

        private void btn_maps_Click(object sender, EventArgs e)
        {
            MAPForm M = new MAPForm();
            M.Show();
            this.Hide();
        }

        private void btn_fireExits_Click(object sender, EventArgs e)
        {
            FireFrom F = new FireFrom();
            F.Show();
            this.Hide();
        }
    }
}
