
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
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
            this.btnAdisyon.BackColor = System.Drawing.Color.Black;
            this.btnAdisyon.Enabled = false;
            this.btnAdisyon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdisyon.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnAdisyon.Location = new System.Drawing.Point(1104, 448);
            this.btnAdisyon.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAdisyon.Name = "btnAdisyon";
            this.btnAdisyon.Size = new System.Drawing.Size(282, 55);
            this.btnAdisyon.TabIndex = 8;
            this.btnAdisyon.Text = "Hesap Kapat";
            this.btnAdisyon.UseVisualStyleBackColor = false;
            this.btnAdisyon.Click += new System.EventHandler(this.btnAdisyon_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Black;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnKaydet.Location = new System.Drawing.Point(812, 448);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(282, 55);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // listUrunler
            // 
            this.listUrunler.HideSelection = false;
            this.listUrunler.Location = new System.Drawing.Point(20, 16);
            this.listUrunler.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listUrunler.Name = "listUrunler";
            this.listUrunler.Size = new System.Drawing.Size(760, 487);
            this.listUrunler.TabIndex = 11;
            this.listUrunler.UseCompatibleStateImageBehavior = false;
            this.listUrunler.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listUrunler_MouseDoubleClick);
            // 
            // listHesap
            // 
            this.listHesap.BackColor = System.Drawing.Color.Black;
            this.listHesap.ForeColor = System.Drawing.Color.Goldenrod;
            this.listHesap.FormattingEnabled = true;
            this.listHesap.ItemHeight = 27;
            this.listHesap.Location = new System.Drawing.Point(812, 73);
            this.listHesap.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.listHesap.Name = "listHesap";
            this.listHesap.Size = new System.Drawing.Size(269, 355);
            this.listHesap.TabIndex = 12;
            this.listHesap.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listHesap_MouseDoubleClick);
            // 
            // lstOzet
            // 
            this.lstOzet.BackColor = System.Drawing.Color.Black;
            this.lstOzet.ForeColor = System.Drawing.Color.Goldenrod;
            this.lstOzet.FormattingEnabled = true;
            this.lstOzet.ItemHeight = 27;
            this.lstOzet.Location = new System.Drawing.Point(1100, 73);
            this.lstOzet.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lstOzet.Name = "lstOzet";
            this.lstOzet.Size = new System.Drawing.Size(280, 355);
            this.lstOzet.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(1157, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4);
            this.label1.Size = new System.Drawing.Size(142, 35);
            this.label1.TabIndex = 14;
            this.label1.Text = "Masa Özeti ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(879, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(4);
            this.label2.Size = new System.Drawing.Size(153, 35);
            this.label2.TabIndex = 15;
            this.label2.Text = "Yeni Sipariş ";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JavaVeJavacilar.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1394, 516);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstOzet);
            this.Controls.Add(this.listHesap);
            this.Controls.Add(this.listUrunler);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnAdisyon);
            this.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
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