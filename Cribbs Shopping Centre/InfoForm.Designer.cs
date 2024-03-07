namespace Cribbs_Shopping_Centre
{
    partial class InfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.HOME_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_opening = new System.Windows.Forms.Button();
            this.btn_maps = new System.Windows.Forms.Button();
            this.btn_fireExits = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(-21, 0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(944, 53);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 9;
            this.pictureBox8.TabStop = false;
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.Location = new System.Drawing.Point(607, 0);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(193, 53);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogo.TabIndex = 10;
            this.picBoxLogo.TabStop = false;
            // 
            // HOME_btn
            // 
            this.HOME_btn.AutoSize = true;
            this.HOME_btn.Image = ((System.Drawing.Image)(resources.GetObject("HOME_btn.Image")));
            this.HOME_btn.Location = new System.Drawing.Point(12, 12);
            this.HOME_btn.Name = "HOME_btn";
            this.HOME_btn.Size = new System.Drawing.Size(30, 30);
            this.HOME_btn.TabIndex = 13;
            this.HOME_btn.UseVisualStyleBackColor = true;
            this.HOME_btn.Click += new System.EventHandler(this.HOME_btn_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(317, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "HERE TO HELP";
            // 
            // btn_opening
            // 
            this.btn_opening.Location = new System.Drawing.Point(12, 341);
            this.btn_opening.Name = "btn_opening";
            this.btn_opening.Size = new System.Drawing.Size(144, 79);
            this.btn_opening.TabIndex = 15;
            this.btn_opening.Text = "Opening times";
            this.btn_opening.UseVisualStyleBackColor = true;
            this.btn_opening.Click += new System.EventHandler(this.btn_opening_Click);
            // 
            // btn_maps
            // 
            this.btn_maps.Location = new System.Drawing.Point(249, 341);
            this.btn_maps.Name = "btn_maps";
            this.btn_maps.Size = new System.Drawing.Size(144, 79);
            this.btn_maps.TabIndex = 18;
            this.btn_maps.Text = "Maps";
            this.btn_maps.UseVisualStyleBackColor = true;
            this.btn_maps.Click += new System.EventHandler(this.btn_maps_Click);
            // 
            // btn_fireExits
            // 
            this.btn_fireExits.Location = new System.Drawing.Point(523, 341);
            this.btn_fireExits.Name = "btn_fireExits";
            this.btn_fireExits.Size = new System.Drawing.Size(144, 79);
            this.btn_fireExits.TabIndex = 20;
            this.btn_fireExits.Text = "Fire Exits";
            this.btn_fireExits.UseVisualStyleBackColor = true;
            this.btn_fireExits.Click += new System.EventHandler(this.btn_fireExits_Click);
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_fireExits);
            this.Controls.Add(this.btn_maps);
            this.Controls.Add(this.btn_opening);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HOME_btn);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.pictureBox8);
            this.Name = "InfoForm";
            this.Text = "InfoForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Button HOME_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_opening;
        private System.Windows.Forms.Button btn_maps;
        private System.Windows.Forms.Button btn_fireExits;
    }
}