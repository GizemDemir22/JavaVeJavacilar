
namespace JavaVeJavacilar.Forms
{
    partial class frmUrunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunler));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.pbUrunGorsel = new System.Windows.Forms.PictureBox();
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTurler = new System.Windows.Forms.ComboBox();
            this.lnkTemizle = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrunGorsel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4);
            this.label1.Size = new System.Drawing.Size(120, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(4);
            this.label2.Size = new System.Drawing.Size(145, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Fiyatı ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(4);
            this.label3.Size = new System.Drawing.Size(118, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Açıklama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 294);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(4);
            this.label4.Size = new System.Drawing.Size(95, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Görsel ";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(192, 51);
            this.txtUrunAdi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(368, 34);
            this.txtUrunAdi.TabIndex = 4;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(192, 199);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(368, 57);
            this.txtAciklama.TabIndex = 6;
            // 
            // pbUrunGorsel
            // 
            this.pbUrunGorsel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbUrunGorsel.Location = new System.Drawing.Point(192, 273);
            this.pbUrunGorsel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pbUrunGorsel.Name = "pbUrunGorsel";
            this.pbUrunGorsel.Size = new System.Drawing.Size(368, 190);
            this.pbUrunGorsel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUrunGorsel.TabIndex = 7;
            this.pbUrunGorsel.TabStop = false;
            this.pbUrunGorsel.Click += new System.EventHandler(this.pbUrunGorsel_Click);
            // 
            // lstUrunler
            // 
            this.lstUrunler.BackColor = System.Drawing.Color.Black;
            this.lstUrunler.ForeColor = System.Drawing.Color.Goldenrod;
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.ItemHeight = 27;
            this.lstUrunler.Location = new System.Drawing.Point(595, 39);
            this.lstUrunler.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(423, 436);
            this.lstUrunler.TabIndex = 8;
            this.lstUrunler.SelectedIndexChanged += new System.EventHandler(this.lstUrunler_SelectedIndexChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Black;
            this.btnEkle.Location = new System.Drawing.Point(192, 478);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(192, 54);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Black;
            this.btnGuncelle.Location = new System.Drawing.Point(405, 478);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(155, 54);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Black;
            this.btnSil.Location = new System.Drawing.Point(595, 483);
            this.btnSil.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(423, 52);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(192, 103);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(368, 34);
            this.txtFiyat.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(24, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(4);
            this.label5.Size = new System.Drawing.Size(137, 35);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ürün Türü ";
            // 
            // cbTurler
            // 
            this.cbTurler.FormattingEnabled = true;
            this.cbTurler.Location = new System.Drawing.Point(192, 152);
            this.cbTurler.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbTurler.Name = "cbTurler";
            this.cbTurler.Size = new System.Drawing.Size(368, 35);
            this.cbTurler.TabIndex = 15;
            // 
            // lnkTemizle
            // 
            this.lnkTemizle.AutoSize = true;
            this.lnkTemizle.BackColor = System.Drawing.Color.Black;
            this.lnkTemizle.LinkColor = System.Drawing.Color.Goldenrod;
            this.lnkTemizle.Location = new System.Drawing.Point(468, 9);
            this.lnkTemizle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lnkTemizle.Name = "lnkTemizle";
            this.lnkTemizle.Size = new System.Drawing.Size(92, 27);
            this.lnkTemizle.TabIndex = 16;
            this.lnkTemizle.TabStop = true;
            this.lnkTemizle.Text = "Temizle";
            this.lnkTemizle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkTemizle_LinkClicked);
            // 
            // frmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JavaVeJavacilar.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1066, 545);
            this.Controls.Add(this.lnkTemizle);
            this.Controls.Add(this.cbTurler);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstUrunler);
            this.Controls.Add(this.pbUrunGorsel);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Goldenrod;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUrunler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.frmUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbUrunGorsel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.PictureBox pbUrunGorsel;
        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTurler;
        private System.Windows.Forms.LinkLabel lnkTemizle;
    }
}