
namespace JavaVeJavacilar.Forms
{
    partial class frmAylikRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAylikRapor));
            this.lblToplam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.BackColor = System.Drawing.Color.Black;
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToplam.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblToplam.Location = new System.Drawing.Point(351, 151);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblToplam.Size = new System.Drawing.Size(62, 30);
            this.lblToplam.TabIndex = 1;
            this.lblToplam.Text = "0000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(88, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.label1.Size = new System.Drawing.Size(210, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aylık Toplam Tutar : ";
            // 
            // frmAylikRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JavaVeJavacilar.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(582, 309);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblToplam);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAylikRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AYLIK RAPOR";
            this.Load += new System.EventHandler(this.frmAylikRapor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label label1;
    }
}