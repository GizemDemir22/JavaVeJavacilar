
namespace JavaVeJavacilar.Forms
{
    partial class FrmMenu
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
            this.flowLayoutMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCorba = new System.Windows.Forms.Button();
            this.btnSalatalar = new System.Windows.Forms.Button();
            this.btnAnaYemekler = new System.Windows.Forms.Button();
            this.btnBaslangıclar = new System.Windows.Forms.Button();
            this.btnTatlılar = new System.Windows.Forms.Button();
            this.btnSıcakİcecekler = new System.Windows.Forms.Button();
            this.btnSogukİcecekler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutMenu
            // 
            this.flowLayoutMenu.Location = new System.Drawing.Point(15, 110);
            this.flowLayoutMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutMenu.Name = "flowLayoutMenu";
            this.flowLayoutMenu.Size = new System.Drawing.Size(982, 438);
            this.flowLayoutMenu.TabIndex = 7;
            this.flowLayoutMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutMenu_Paint);
            // 
            // btnCorba
            // 
            this.btnCorba.Location = new System.Drawing.Point(15, 46);
            this.btnCorba.Margin = new System.Windows.Forms.Padding(4);
            this.btnCorba.Name = "btnCorba";
            this.btnCorba.Size = new System.Drawing.Size(118, 36);
            this.btnCorba.TabIndex = 0;
            this.btnCorba.Text = "Çorbalar";
            this.btnCorba.UseVisualStyleBackColor = true;
            this.btnCorba.Click += new System.EventHandler(this.btnCorba_Click);
            // 
            // btnSalatalar
            // 
            this.btnSalatalar.Location = new System.Drawing.Point(170, 46);
            this.btnSalatalar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalatalar.Name = "btnSalatalar";
            this.btnSalatalar.Size = new System.Drawing.Size(118, 36);
            this.btnSalatalar.TabIndex = 1;
            this.btnSalatalar.Text = "Salatalar";
            this.btnSalatalar.UseVisualStyleBackColor = true;
            // 
            // btnAnaYemekler
            // 
            this.btnAnaYemekler.Location = new System.Drawing.Point(461, 46);
            this.btnAnaYemekler.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnaYemekler.Name = "btnAnaYemekler";
            this.btnAnaYemekler.Size = new System.Drawing.Size(118, 36);
            this.btnAnaYemekler.TabIndex = 2;
            this.btnAnaYemekler.Text = "Ana Yemekler";
            this.btnAnaYemekler.UseVisualStyleBackColor = true;
            // 
            // btnBaslangıclar
            // 
            this.btnBaslangıclar.Location = new System.Drawing.Point(314, 46);
            this.btnBaslangıclar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaslangıclar.Name = "btnBaslangıclar";
            this.btnBaslangıclar.Size = new System.Drawing.Size(118, 36);
            this.btnBaslangıclar.TabIndex = 3;
            this.btnBaslangıclar.Text = "Başlangıçlar";
            this.btnBaslangıclar.UseVisualStyleBackColor = true;
            // 
            // btnTatlılar
            // 
            this.btnTatlılar.Location = new System.Drawing.Point(601, 46);
            this.btnTatlılar.Margin = new System.Windows.Forms.Padding(4);
            this.btnTatlılar.Name = "btnTatlılar";
            this.btnTatlılar.Size = new System.Drawing.Size(118, 36);
            this.btnTatlılar.TabIndex = 4;
            this.btnTatlılar.Text = "Tatlılar";
            this.btnTatlılar.UseVisualStyleBackColor = true;
            // 
            // btnSıcakİcecekler
            // 
            this.btnSıcakİcecekler.Location = new System.Drawing.Point(744, 46);
            this.btnSıcakİcecekler.Margin = new System.Windows.Forms.Padding(4);
            this.btnSıcakİcecekler.Name = "btnSıcakİcecekler";
            this.btnSıcakİcecekler.Size = new System.Drawing.Size(118, 36);
            this.btnSıcakİcecekler.TabIndex = 5;
            this.btnSıcakİcecekler.Text = "Sıcakİçecekler";
            this.btnSıcakİcecekler.UseVisualStyleBackColor = true;
            // 
            // btnSogukİcecekler
            // 
            this.btnSogukİcecekler.Location = new System.Drawing.Point(880, 46);
            this.btnSogukİcecekler.Margin = new System.Windows.Forms.Padding(4);
            this.btnSogukİcecekler.Name = "btnSogukİcecekler";
            this.btnSogukİcecekler.Size = new System.Drawing.Size(118, 36);
            this.btnSogukİcecekler.TabIndex = 6;
            this.btnSogukİcecekler.Text = "Soğuk İçecekler";
            this.btnSogukİcecekler.UseVisualStyleBackColor = true;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 562);
            this.Controls.Add(this.flowLayoutMenu);
            this.Controls.Add(this.btnSogukİcecekler);
            this.Controls.Add(this.btnSıcakİcecekler);
            this.Controls.Add(this.btnTatlılar);
            this.Controls.Add(this.btnBaslangıclar);
            this.Controls.Add(this.btnAnaYemekler);
            this.Controls.Add(this.btnSalatalar);
            this.Controls.Add(this.btnCorba);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutMenu;
        private System.Windows.Forms.Button btnCorba;
        private System.Windows.Forms.Button btnSalatalar;
        private System.Windows.Forms.Button btnAnaYemekler;
        private System.Windows.Forms.Button btnBaslangıclar;
        private System.Windows.Forms.Button btnTatlılar;
        private System.Windows.Forms.Button btnSıcakİcecekler;
        private System.Windows.Forms.Button btnSogukİcecekler;
    }
}