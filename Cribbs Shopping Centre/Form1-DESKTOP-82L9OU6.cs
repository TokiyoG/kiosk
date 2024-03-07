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
    public partial class Form1 : Form
    {
        void searchFunction(object sender, KeyEventArgs e)
        {
            string error = richTextBox1.Text;
            if (e.KeyValue == Convert.ToInt32(Keys.Enter))
            {


                string searchBarText = richTextBox1.Text;
                string checker = "";
                string[] list = { "shopping", "grocery", "map","maps" ,"fire exits", "fire", "gregg", "kfc", "dining","Food", "amazon", "Boots", "claires", "Eurochange", "money", "hbeauty", "John Lewis", "Marks spencer", "MS", "SKy", "specsavers", "glasses","superdrug", };

                for (int j = 0; j < list.Length; j++)
                {
                    checker = "";
                    char[] character = list[j].ToCharArray();
                    foreach (char a in character)
                    {
                        foreach (char b in searchBarText)
                        {
                            if (a.ToString().ToLower() == b.ToString().ToLower())
                            {
                                checker += b;
                                break;
                            }
                        }
                    }
                    if (list[j].ToLower() == checker.ToLower())
                    {
                        errortext.Text = "";

                        if (j == 0  || j == 1)
                        {

                            ShoppingForm sff = new ShoppingForm();
                            this.Hide();
                            sff.Show();
                        }
                        else if (j == 2 ||j==3 )
                        {
                            MAPForm M = new MAPForm();
                            this.Hide();
                            M.Show();

                        }
                        else if (j == 4|| j==5)
                        {
                            FireFrom F = new FireFrom();
                            this.Hide();
                            F.Show();

                        }
                        else if (j == 6|| j==7|| j==8|| j==9)
                        {
                            FOOD F = new FOOD();
                            this.Hide();
                            F.Show();

                        }
                        else if (j == 10)
                        {
                            amazon A = new amazon();
                            this.Hide();
                            A.Show();

                        }
                        else if (j==11)
                        {
                            BOOTS b = new BOOTS();
                            this.Hide();
                            b.Show();

                        }
                        else if (j == 12)
                        {
                            Claire_s C = new Claire_s();
                            this.Hide();
                            C.Show();

                        }
                        else if (j == 13|| j==14)
                        {
                            EuroChange E = new EuroChange();
                            this.Hide();
                            E.Show();

                        }
                        else if (j == 15)
                        {
                            hBeauty h = new hBeauty();
                            this.Hide();
                            h.Show();

                        }
                        else if (j == 16)
                        {
                            JOHN J = new JOHN();
                            this.Hide();
                            J.Show();
                            
                        }
                        else if (j == 17|| j==18)
                        {
                            MS m = new MS();
                            this.Hide();
                            m.Show();

                        }
                        else if (j == 19)
                        {
                            SKYcs s = new SKYcs();
                            this.Hide();
                            s.Show();

                        }
                        else if (j == 20||j==21)
                        {
                            Specsavers s = new Specsavers();
                            this.Hide();
                            s.Show();

                        }
                        else if (j == 22)
                        {
                            Superdrug s = new Superdrug();
                            this.Hide();
                            s.Show();
                        }
                        else
                        break;
                    }
                    errortext.Text = ("No Results found for the word: " + error);

                }

            }
        }


        public Form1()
        {
            InitializeComponent();
            CenterToScreen();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchFunction);
        }

        private void ShoppinCart_btn_Click(object sender, EventArgs e)
        {
            ShoppingForm s = new ShoppingForm();
                s.Show();
            this.Hide();
        }

        private void Sales_btn_Click(object sender, EventArgs e)
        {
            DiscountForm D = new DiscountForm();
            D.Show();
            this.Hide();
        }

        private void Disable_btn_Click(object sender, EventArgs e)
        {
            AcssesForm A = new AcssesForm();
           A.Show();
            this.Hide();
        }

        private void Parkin_btn_Click(object sender, EventArgs e)
        {
            ParkingForm P = new ParkingForm();
            P.Show();
            this.Hide();
        }

        private void Info_btn_Click(object sender, EventArgs e)
        {
           InfoForm I = new InfoForm();
            I.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Size prop = new Size(41, 34);

            if (Info_btn.Size == prop) //Make it bigger -- add dimensions
            {
                Info_btn.Size = new Size(55, 46);
                Disable_btn.Size = new Size(54, 46);
                Sales_btn.Size = new Size(54, 46);
                Parkin_btn.Size = new Size(54, 46);
                ShoppinCart_btn.Size = new Size(54,46);
               
               
            }
            else //Make it smaller
            {
                Info_btn.Size = new Size(41, 34);
                Disable_btn.Size = new Size(41, 33);
                Sales_btn.Size = new Size(41, 31);
                Parkin_btn.Size = new Size(41, 31);
                ShoppinCart_btn.Size = new Size(41, 31);
            
            }
 

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Btncontroll_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                lblForm.Font = fontDialog1.Font;
                lblForm.ForeColor = fontDialog1.Color;
            }
        }

        private void lblForm_Click(object sender, EventArgs e)
        {
            
        }

        private void errortext_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
