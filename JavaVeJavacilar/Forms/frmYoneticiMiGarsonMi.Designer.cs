﻿
namespace JavaVeJavacilar.Forms
{
    partial class frmYoneticiMiGarsonMi
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnYonetici = new System.Windows.Forms.Button();
            this.btnGarson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(248, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yönetici Misin Garson mu?";
            // 
            // btnYonetici
            // 
            this.btnYonetici.Location = new System.Drawing.Point(248, 165);
            this.btnYonetici.Name = "btnYonetici";
            this.btnYonetici.Size = new System.Drawing.Size(119, 53);
            this.btnYonetici.TabIndex = 1;
            this.btnYonetici.Text = "Yönetici";
            this.btnYonetici.UseVisualStyleBackColor = true;
            // 
            // btnGarson
            // 
            this.btnGarson.Location = new System.Drawing.Point(418, 165);
            this.btnGarson.Name = "btnGarson";
            this.btnGarson.Size = new System.Drawing.Size(126, 53);
            this.btnGarson.TabIndex = 2;
            this.btnGarson.Text = "Garson";
            this.btnGarson.UseVisualStyleBackColor = true;
            // 
            // frmYoneticiMiGarsonMi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGarson);
            this.Controls.Add(this.btnYonetici);
            this.Controls.Add(this.label1);
            this.Name = "frmYoneticiMiGarsonMi";
            this.Text = "frmYoneticiMiGarsonMi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYonetici;
        private System.Windows.Forms.Button btnGarson;
    }
}