
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
            this.btnAdisyon = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.listUrunler = new System.Windows.Forms.ListView();
            this.listHesap = new System.Windows.Forms.ListBox();
            this.lstOzet = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdisyon
            // 
            this.btnAdisyon.Enabled = false;
            this.btnAdisyon.Location = new System.Drawing.Point(836, 364);
            this.btnAdisyon.Name = "btnAdisyon";
            this.btnAdisyon.Size = new System.Drawing.Size(94, 48);
            this.btnAdisyon.TabIndex = 8;
            this.btnAdisyon.Text = "Hesap Kapat";
            this.btnAdisyon.UseVisualStyleBackColor = true;
            this.btnAdisyon.Click += new System.EventHandler(this.btnAdisyon_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(637, 364);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(94, 48);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // listUrunler
            // 
            this.listUrunler.HideSelection = false;
            this.listUrunler.Location = new System.Drawing.Point(12, 12);
            this.listUrunler.Name = "listUrunler";
            this.listUrunler.Size = new System.Drawing.Size(501, 400);
            this.listUrunler.TabIndex = 11;
            this.listUrunler.UseCompatibleStateImageBehavior = false;
            this.listUrunler.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listUrunler_MouseDoubleClick);
            // 
            // listHesap
            // 
            this.listHesap.FormattingEnabled = true;
            this.listHesap.ItemHeight = 20;
            this.listHesap.Location = new System.Drawing.Point(531, 32);
            this.listHesap.Name = "listHesap";
            this.listHesap.Size = new System.Drawing.Size(200, 324);
            this.listHesap.TabIndex = 12;
            this.listHesap.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listHesap_MouseDoubleClick);
            // 
            // lstOzet
            // 
            this.lstOzet.FormattingEnabled = true;
            this.lstOzet.ItemHeight = 20;
            this.lstOzet.Location = new System.Drawing.Point(737, 32);
            this.lstOzet.Name = "lstOzet";
            this.lstOzet.Size = new System.Drawing.Size(193, 324);
            this.lstOzet.TabIndex = 13;
            this.lstOzet.SelectedIndexChanged += new System.EventHandler(this.lstOzet_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(737, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Masa Özeti:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(531, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Yeni Sipariş:";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 442);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstOzet);
            this.Controls.Add(this.listHesap);
            this.Controls.Add(this.listUrunler);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnAdisyon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menü";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdisyon;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ListView listUrunler;
        private System.Windows.Forms.ListBox listHesap;
        private System.Windows.Forms.ListBox lstOzet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}