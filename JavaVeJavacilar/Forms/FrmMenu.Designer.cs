
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
            this.btnCorba = new System.Windows.Forms.Button();
            this.btnSalatalar = new System.Windows.Forms.Button();
            this.btnAnaYemekler = new System.Windows.Forms.Button();
            this.btnBaslangıclar = new System.Windows.Forms.Button();
            this.btnTatlılar = new System.Windows.Forms.Button();
            this.btnSıcakİcecekler = new System.Windows.Forms.Button();
            this.btnSogukİcecekler = new System.Windows.Forms.Button();
            this.flowLayoutMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.flowLayoutMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCorba
            // 
            this.btnCorba.Location = new System.Drawing.Point(12, 37);
            this.btnCorba.Name = "btnCorba";
            this.btnCorba.Size = new System.Drawing.Size(94, 29);
            this.btnCorba.TabIndex = 0;
            this.btnCorba.Text = "Çorbalar";
            this.btnCorba.UseVisualStyleBackColor = true;
            this.btnCorba.Click += new System.EventHandler(this.btnCorba_Click);
            // 
            // btnSalatalar
            // 
            this.btnSalatalar.Location = new System.Drawing.Point(136, 37);
            this.btnSalatalar.Name = "btnSalatalar";
            this.btnSalatalar.Size = new System.Drawing.Size(94, 29);
            this.btnSalatalar.TabIndex = 1;
            this.btnSalatalar.Text = "Salatalar";
            this.btnSalatalar.UseVisualStyleBackColor = true;
            // 
            // btnAnaYemekler
            // 
            this.btnAnaYemekler.Location = new System.Drawing.Point(369, 37);
            this.btnAnaYemekler.Name = "btnAnaYemekler";
            this.btnAnaYemekler.Size = new System.Drawing.Size(94, 29);
            this.btnAnaYemekler.TabIndex = 2;
            this.btnAnaYemekler.Text = "Ana Yemekler";
            this.btnAnaYemekler.UseVisualStyleBackColor = true;
            // 
            // btnBaslangıclar
            // 
            this.btnBaslangıclar.Location = new System.Drawing.Point(251, 37);
            this.btnBaslangıclar.Name = "btnBaslangıclar";
            this.btnBaslangıclar.Size = new System.Drawing.Size(94, 29);
            this.btnBaslangıclar.TabIndex = 3;
            this.btnBaslangıclar.Text = "Başlangıçlar";
            this.btnBaslangıclar.UseVisualStyleBackColor = true;
            // 
            // btnTatlılar
            // 
            this.btnTatlılar.Location = new System.Drawing.Point(481, 37);
            this.btnTatlılar.Name = "btnTatlılar";
            this.btnTatlılar.Size = new System.Drawing.Size(94, 29);
            this.btnTatlılar.TabIndex = 4;
            this.btnTatlılar.Text = "Tatlılar";
            this.btnTatlılar.UseVisualStyleBackColor = true;
            // 
            // btnSıcakİcecekler
            // 
            this.btnSıcakİcecekler.Location = new System.Drawing.Point(595, 37);
            this.btnSıcakİcecekler.Name = "btnSıcakİcecekler";
            this.btnSıcakİcecekler.Size = new System.Drawing.Size(94, 29);
            this.btnSıcakİcecekler.TabIndex = 5;
            this.btnSıcakİcecekler.Text = "Sıcakİçecekler";
            this.btnSıcakİcecekler.UseVisualStyleBackColor = true;
            // 
            // btnSogukİcecekler
            // 
            this.btnSogukİcecekler.Location = new System.Drawing.Point(704, 37);
            this.btnSogukİcecekler.Name = "btnSogukİcecekler";
            this.btnSogukİcecekler.Size = new System.Drawing.Size(94, 29);
            this.btnSogukİcecekler.TabIndex = 6;
            this.btnSogukİcecekler.Text = "Soğuk İçecekler";
            this.btnSogukİcecekler.UseVisualStyleBackColor = true;
            // 
            // flowLayoutMenu
            // 
            this.flowLayoutMenu.Controls.Add(this.comboBox1);
            this.flowLayoutMenu.Location = new System.Drawing.Point(12, 88);
            this.flowLayoutMenu.Name = "flowLayoutMenu";
            this.flowLayoutMenu.Size = new System.Drawing.Size(786, 350);
            this.flowLayoutMenu.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 8;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 450);
            this.Controls.Add(this.flowLayoutMenu);
            this.Controls.Add(this.btnSogukİcecekler);
            this.Controls.Add(this.btnSıcakİcecekler);
            this.Controls.Add(this.btnTatlılar);
            this.Controls.Add(this.btnBaslangıclar);
            this.Controls.Add(this.btnAnaYemekler);
            this.Controls.Add(this.btnSalatalar);
            this.Controls.Add(this.btnCorba);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.flowLayoutMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalatalar;
        private System.Windows.Forms.Button btnAnaYemekler;
        private System.Windows.Forms.Button btnBaslangıclar;
        private System.Windows.Forms.Button btnTatlılar;
        private System.Windows.Forms.Button btnSıcakİcecekler;
        private System.Windows.Forms.Button btnSogukİcecekler;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutMenu;
        public System.Windows.Forms.Button btnCorba;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}