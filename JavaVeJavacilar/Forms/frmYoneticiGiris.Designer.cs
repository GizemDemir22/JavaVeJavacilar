﻿
namespace JavaVeJavacilar.Forms
{
    partial class frmYoneticiGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYoneticiGiris));
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtParola = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGeriGit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.Black;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGiris.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnGiris.Location = new System.Drawing.Point(1018, 456);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(239, 39);
            this.btnGiris.TabIndex = 17;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.Black;
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSifre.ForeColor = System.Drawing.Color.Goldenrod;
            this.txtSifre.Location = new System.Drawing.Point(1018, 401);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(238, 35);
            this.txtSifre.TabIndex = 16;
            this.txtSifre.Text = "admin";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.BackColor = System.Drawing.Color.Black;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.Goldenrod;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(1018, 346);
            this.txtKullaniciAdi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(238, 35);
            this.txtKullaniciAdi.TabIndex = 15;
            this.txtKullaniciAdi.Text = "admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Goldenrod;
            this.label3.Location = new System.Drawing.Point(858, 271);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3);
            this.label3.Size = new System.Drawing.Size(399, 54);
            this.label3.TabIndex = 14;
            this.label3.Text = "Yönetici Giriş Ekranı ";
            // 
            // txtParola
            // 
            this.txtParola.AutoSize = true;
            this.txtParola.BackColor = System.Drawing.Color.Black;
            this.txtParola.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtParola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtParola.ForeColor = System.Drawing.Color.Goldenrod;
            this.txtParola.Location = new System.Drawing.Point(858, 405);
            this.txtParola.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtParola.Name = "txtParola";
            this.txtParola.Padding = new System.Windows.Forms.Padding(3);
            this.txtParola.Size = new System.Drawing.Size(91, 37);
            this.txtParola.TabIndex = 13;
            this.txtParola.Text = "Parola";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(858, 350);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(153, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // btnGeriGit
            // 
            this.btnGeriGit.BackColor = System.Drawing.Color.Black;
            this.btnGeriGit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGeriGit.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnGeriGit.Location = new System.Drawing.Point(-1, -1);
            this.btnGeriGit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGeriGit.Name = "btnGeriGit";
            this.btnGeriGit.Size = new System.Drawing.Size(170, 49);
            this.btnGeriGit.TabIndex = 18;
            this.btnGeriGit.Text = "Geri git";
            this.btnGeriGit.UseVisualStyleBackColor = false;
            this.btnGeriGit.Click += new System.EventHandler(this.btnGeriGit_Click);
            // 
            // frmYoneticiGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JavaVeJavacilar.Properties.Resources.icon_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1290, 546);
            this.Controls.Add(this.btnGeriGit);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmYoneticiGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "YONETICI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtParola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGeriGit;
    }
}