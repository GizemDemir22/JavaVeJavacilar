
namespace JavaVeJavacilar.Forms
{
    partial class frmKatlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKatlar));
            this.label1 = new System.Windows.Forms.Label();
            this.txtKatAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.lstKatlar = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(46, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4);
            this.label1.Size = new System.Drawing.Size(136, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bölüm Adı ";
            // 
            // txtKatAdi
            // 
            this.txtKatAdi.Location = new System.Drawing.Point(201, 148);
            this.txtKatAdi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtKatAdi.Name = "txtKatAdi";
            this.txtKatAdi.Size = new System.Drawing.Size(304, 34);
            this.txtKatAdi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(31, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(4);
            this.label2.Size = new System.Drawing.Size(151, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Masa Sayısı ";
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(201, 211);
            this.txtSayi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(304, 34);
            this.txtSayi.TabIndex = 3;
            // 
            // lstKatlar
            // 
            this.lstKatlar.BackColor = System.Drawing.Color.Black;
            this.lstKatlar.ForeColor = System.Drawing.Color.Goldenrod;
            this.lstKatlar.FormattingEnabled = true;
            this.lstKatlar.ItemHeight = 27;
            this.lstKatlar.Location = new System.Drawing.Point(539, 38);
            this.lstKatlar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lstKatlar.Name = "lstKatlar";
            this.lstKatlar.Size = new System.Drawing.Size(411, 409);
            this.lstKatlar.TabIndex = 4;
            this.lstKatlar.SelectedIndexChanged += new System.EventHandler(this.lstKatlar_SelectedIndexChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Black;
            this.btnEkle.Location = new System.Drawing.Point(201, 289);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(304, 54);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Black;
            this.btnGuncelle.Location = new System.Drawing.Point(201, 370);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(304, 54);
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Black;
            this.btnSil.Location = new System.Drawing.Point(539, 470);
            this.btnSil.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(411, 50);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Black;
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.linkLabel1.LinkColor = System.Drawing.Color.Goldenrod;
            this.linkLabel1.Location = new System.Drawing.Point(335, 96);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(170, 27);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Seçimi Temizle";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmKatlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JavaVeJavacilar.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1066, 545);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstKatlar);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKatAdi);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Goldenrod;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmKatlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Katlar";
            this.Load += new System.EventHandler(this.frmKatlar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKatAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.ListBox lstKatlar;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}