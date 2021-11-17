
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYoneticiMiGarsonMi));
            this.btnYonetici = new System.Windows.Forms.Button();
            this.btnGarson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYonetici
            // 
            this.btnYonetici.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnYonetici.BackColor = System.Drawing.Color.Black;
            this.btnYonetici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYonetici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYonetici.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnYonetici.Location = new System.Drawing.Point(93, 209);
            this.btnYonetici.Name = "btnYonetici";
            this.btnYonetici.Size = new System.Drawing.Size(195, 47);
            this.btnYonetici.TabIndex = 1;
            this.btnYonetici.Text = "Yönetici";
            this.btnYonetici.UseVisualStyleBackColor = false;
            this.btnYonetici.Click += new System.EventHandler(this.btnYonetici_Click);
            // 
            // btnGarson
            // 
            this.btnGarson.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGarson.BackColor = System.Drawing.Color.Black;
            this.btnGarson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGarson.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGarson.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnGarson.Location = new System.Drawing.Point(613, 209);
            this.btnGarson.Name = "btnGarson";
            this.btnGarson.Size = new System.Drawing.Size(195, 47);
            this.btnGarson.TabIndex = 2;
            this.btnGarson.Text = "Garson";
            this.btnGarson.UseVisualStyleBackColor = false;
            this.btnGarson.Click += new System.EventHandler(this.btnGarson_Click);
            // 
            // frmYoneticiMiGarsonMi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JavaVeJavacilar.Properties.Resources.icon_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 325);
            this.Controls.Add(this.btnGarson);
            this.Controls.Add(this.btnYonetici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmYoneticiMiGarsonMi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Java";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmYoneticiMiGarsonMi_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnYonetici;
        private System.Windows.Forms.Button btnGarson;
    }
}