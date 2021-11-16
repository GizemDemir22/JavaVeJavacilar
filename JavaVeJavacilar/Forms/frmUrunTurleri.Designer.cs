
namespace JavaVeJavacilar.Forms
{
    partial class frmUrunTurleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunTurleri));
            this.lstUrunTurleri = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtTurAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstUrunTurleri
            // 
            this.lstUrunTurleri.BackColor = System.Drawing.Color.Black;
            this.lstUrunTurleri.ForeColor = System.Drawing.Color.Goldenrod;
            this.lstUrunTurleri.FormattingEnabled = true;
            this.lstUrunTurleri.ItemHeight = 27;
            this.lstUrunTurleri.Location = new System.Drawing.Point(573, 25);
            this.lstUrunTurleri.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lstUrunTurleri.Name = "lstUrunTurleri";
            this.lstUrunTurleri.Size = new System.Drawing.Size(445, 490);
            this.lstUrunTurleri.TabIndex = 0;
            this.lstUrunTurleri.SelectedIndexChanged += new System.EventHandler(this.lstUrunTurleri_SelectedIndexChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Black;
            this.btnEkle.Location = new System.Drawing.Point(213, 225);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(278, 49);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Yeni Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Black;
            this.btnGuncelle.Location = new System.Drawing.Point(213, 307);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(278, 49);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // txtTurAdi
            // 
            this.txtTurAdi.Location = new System.Drawing.Point(213, 141);
            this.txtTurAdi.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTurAdi.Name = "txtTurAdi";
            this.txtTurAdi.Size = new System.Drawing.Size(278, 34);
            this.txtTurAdi.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(39, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4);
            this.label1.Size = new System.Drawing.Size(137, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün Türü ";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Black;
            this.btnSil.Location = new System.Drawing.Point(213, 385);
            this.btnSil.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(278, 49);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Seçili Olanı Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // frmUrunTurleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JavaVeJavacilar.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1066, 545);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTurAdi);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstUrunTurleri);
            this.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Goldenrod;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUrunTurleri";
            this.Text = "URUN TURLERI";
            this.Load += new System.EventHandler(this.frmUrunTurleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUrunTurleri;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtTurAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSil;
    }
}