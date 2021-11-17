
namespace JavaVeJavacilar.Forms
{
    partial class frmGunlukRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGunlukRapor));
            this.listView1 = new System.Windows.Forms.ListView();
            this.urunAdet = new System.Windows.Forms.ColumnHeader();
            this.urunAdi = new System.Windows.Forms.ColumnHeader();
            this.urunFiyat = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Black;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.urunAdet,
            this.urunAdi,
            this.urunFiyat});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listView1.ForeColor = System.Drawing.Color.Goldenrod;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(43, 82);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1012, 336);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // urunAdet
            // 
            this.urunAdet.Text = "Ürün Adet";
            this.urunAdet.Width = 300;
            // 
            // urunAdi
            // 
            this.urunAdi.Text = "Ürün Adı";
            this.urunAdi.Width = 400;
            // 
            // urunFiyat
            // 
            this.urunFiyat.Text = "Ürün Fiyat";
            this.urunFiyat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.urunFiyat.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(721, 464);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(171, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "TOPLAM : ";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.BackColor = System.Drawing.Color.Black;
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplam.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblToplam.Location = new System.Drawing.Point(919, 464);
            this.lblToplam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Padding = new System.Windows.Forms.Padding(5);
            this.lblToplam.Size = new System.Drawing.Size(92, 42);
            this.lblToplam.TabIndex = 2;
            this.lblToplam.Text = "0000";
            // 
            // frmGunlukRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::JavaVeJavacilar.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1113, 550);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGunlukRapor";
            this.Text = "GUNLUK RAPOR";
            this.Load += new System.EventHandler(this.frmGunlukRapor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader urunAdet;
        private System.Windows.Forms.ColumnHeader urunAdi;
        private System.Windows.Forms.ColumnHeader urunFiyat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblToplam;
    }
}