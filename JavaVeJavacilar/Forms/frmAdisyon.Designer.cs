
namespace JavaVeJavacilar.Forms
{
    partial class frmAdisyon
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
            this.lblMasa = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.listSiparis = new System.Windows.Forms.ListView();
            this.clmUrunAdi = new System.Windows.Forms.ColumnHeader();
            this.clmAdet = new System.Windows.Forms.ColumnHeader();
            this.clmUrunFiyat = new System.Windows.Forms.ColumnHeader();
            this.clmSatirToplam = new System.Windows.Forms.ColumnHeader();
            this.lblAdisyonToplam = new System.Windows.Forms.Label();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.lblMasaNo = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // lblMasa
            // 
            this.lblMasa.AutoSize = true;
            this.lblMasa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMasa.Location = new System.Drawing.Point(12, 19);
            this.lblMasa.Name = "lblMasa";
            this.lblMasa.Size = new System.Drawing.Size(70, 28);
            this.lblMasa.TabIndex = 0;
            this.lblMasa.Text = "Masa: ";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplam.Location = new System.Drawing.Point(341, 493);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(135, 28);
            this.lblToplam.TabIndex = 1;
            this.lblToplam.Text = "Toplam Tutar:";
            // 
            // listSiparis
            // 
            this.listSiparis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmUrunAdi,
            this.clmAdet,
            this.clmUrunFiyat,
            this.clmSatirToplam});
            this.listSiparis.HideSelection = false;
            this.listSiparis.Location = new System.Drawing.Point(12, 70);
            this.listSiparis.Name = "listSiparis";
            this.listSiparis.Size = new System.Drawing.Size(572, 420);
            this.listSiparis.TabIndex = 2;
            this.listSiparis.UseCompatibleStateImageBehavior = false;
            this.listSiparis.View = System.Windows.Forms.View.Details;
            // 
            // clmUrunAdi
            // 
            this.clmUrunAdi.Text = "Ürün Adı";
            this.clmUrunAdi.Width = 300;
            // 
            // clmAdet
            // 
            this.clmAdet.Text = "Adet";
            this.clmAdet.Width = 70;
            // 
            // clmUrunFiyat
            // 
            this.clmUrunFiyat.Text = "Ürün Fiyatı";
            this.clmUrunFiyat.Width = 100;
            // 
            // clmSatirToplam
            // 
            this.clmSatirToplam.Text = "Toplam";
            this.clmSatirToplam.Width = 90;
            // 
            // lblAdisyonToplam
            // 
            this.lblAdisyonToplam.AutoSize = true;
            this.lblAdisyonToplam.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdisyonToplam.Location = new System.Drawing.Point(482, 493);
            this.lblAdisyonToplam.Name = "lblAdisyonToplam";
            this.lblAdisyonToplam.Size = new System.Drawing.Size(40, 28);
            this.lblAdisyonToplam.TabIndex = 3;
            this.lblAdisyonToplam.Text = "0 ₺";
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(12, 496);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(94, 29);
            this.btnYazdir.TabIndex = 4;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // lblMasaNo
            // 
            this.lblMasaNo.AutoSize = true;
            this.lblMasaNo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMasaNo.Location = new System.Drawing.Point(74, 19);
            this.lblMasaNo.Name = "lblMasaNo";
            this.lblMasaNo.Size = new System.Drawing.Size(74, 28);
            this.lblMasaNo.TabIndex = 5;
            this.lblMasaNo.Text = "Bahçe1";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDateTime.Location = new System.Drawing.Point(386, 19);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(198, 28);
            this.lblDateTime.TabIndex = 6;
            this.lblDateTime.Text = "00-00-0000 00:00:00";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmAdisyon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 544);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.lblMasaNo);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.lblAdisyonToplam);
            this.Controls.Add(this.listSiparis);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.lblMasa);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdisyon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Kapat";
            this.Load += new System.EventHandler(this.frmAdisyon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMasa;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.ListView listSiparis;
        private System.Windows.Forms.ColumnHeader clmUrunAdi;
        private System.Windows.Forms.ColumnHeader clmAdet;
        private System.Windows.Forms.ColumnHeader clmUrunFiyat;
        private System.Windows.Forms.ColumnHeader clmSatirToplam;
        private System.Windows.Forms.Label lblAdisyonToplam;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Label lblMasaNo;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}