namespace Cribbs_Shopping_Centre
{
    partial class MAPForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAPForm));
            this.label1 = new System.Windows.Forms.Label();
            this.HOME_btn = new System.Windows.Forms.Button();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.map1 = new System.Windows.Forms.PictureBox();
            this.btn_backToHelp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.map1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(455, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "HERE TO HELP";
            // 
            // HOME_btn
            // 
            this.HOME_btn.AutoSize = true;
            this.HOME_btn.Image = ((System.Drawing.Image)(resources.GetObject("HOME_btn.Image")));
            this.HOME_btn.Location = new System.Drawing.Point(18, 9);
            this.HOME_btn.Name = "HOME_btn";
            this.HOME_btn.Size = new System.Drawing.Size(30, 30);
            this.HOME_btn.TabIndex = 17;
            this.HOME_btn.UseVisualStyleBackColor = true;
            this.HOME_btn.Click += new System.EventHandler(this.HOME_btn_Click);
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.Location = new System.Drawing.Point(947, -3);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(193, 53);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxLogo.TabIndex = 16;
            this.picBoxLogo.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(-15, -3);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(1155, 53);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 15;
            this.pictureBox8.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.map1);
            this.panel1.Location = new System.Drawing.Point(31, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 551);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // map1
            // 
            this.map1.Image = ((System.Drawing.Image)(resources.GetObject("map1.Image")));
            this.map1.Location = new System.Drawing.Point(3, 3);
            this.map1.Name = "map1";
            this.map1.Size = new System.Drawing.Size(692, 738);
            this.map1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.map1.TabIndex = 19;
            this.map1.TabStop = false;
            // 
            // btn_backToHelp
            // 
            this.btn_backToHelp.Location = new System.Drawing.Point(966, 651);
            this.btn_backToHelp.Name = "btn_backToHelp";
            this.btn_backToHelp.Size = new System.Drawing.Size(145, 23);
            this.btn_backToHelp.TabIndex = 21;
            this.btn_backToHelp.Text = "Back To Main Help  screen";
            this.btn_backToHelp.UseVisualStyleBackColor = true;
            this.btn_backToHelp.Click += new System.EventHandler(this.btn_backToHelp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 747);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 309);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(582, 747);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(335, 314);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // MAPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 680);
            this.Controls.Add(this.btn_backToHelp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HOME_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.pictureBox8);
            this.Name = "MAPForm";
            this.Text = "MAPForm";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.map1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HOME_btn;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox map1;
        private System.Windows.Forms.Button btn_backToHelp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}