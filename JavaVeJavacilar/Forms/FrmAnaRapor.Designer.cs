
namespace JavaVeJavacilar.Forms
{
    partial class FrmAnaRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaRapor));
            this.btnGunlukRapor = new System.Windows.Forms.Button();
            this.btnAylıkRapor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGunlukRapor
            // 
            this.btnGunlukRapor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGunlukRapor.BackColor = System.Drawing.Color.Black;
            this.btnGunlukRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGunlukRapor.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnGunlukRapor.Location = new System.Drawing.Point(97, 145);
            this.btnGunlukRapor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGunlukRapor.Name = "btnGunlukRapor";
            this.btnGunlukRapor.Size = new System.Drawing.Size(201, 46);
            this.btnGunlukRapor.TabIndex = 0;
            this.btnGunlukRapor.Text = "Günlük Rapor";
            this.btnGunlukRapor.UseVisualStyleBackColor = false;
            this.btnGunlukRapor.Click += new System.EventHandler(this.btnGunlukRapor_Click);
            // 
            // btnAylıkRapor
            // 
            this.btnAylıkRapor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAylıkRapor.BackColor = System.Drawing.Color.Black;
            this.btnAylıkRapor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAylıkRapor.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnAylıkRapor.Location = new System.Drawing.Point(477, 145);
            this.btnAylıkRapor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAylıkRapor.Name = "btnAylıkRapor";
            this.btnAylıkRapor.Size = new System.Drawing.Size(201, 46);
            this.btnAylıkRapor.TabIndex = 1;
            this.btnAylıkRapor.Text = "Aylık Rapor";
            this.btnAylıkRapor.UseVisualStyleBackColor = false;
            this.btnAylıkRapor.Click += new System.EventHandler(this.btnAylıkRapor_Click);
            // 
            // FrmAnaRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JavaVeJavacilar.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(779, 330);
            this.Controls.Add(this.btnAylıkRapor);
            this.Controls.Add(this.btnGunlukRapor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmAnaRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RAPOR CESITLERI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGunlukRapor;
        private System.Windows.Forms.Button btnAylıkRapor;
    }
}