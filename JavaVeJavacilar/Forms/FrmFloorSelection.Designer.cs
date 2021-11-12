
namespace JavaVeJavacilar.Forms
{
    partial class FrmFloorSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFloorSelection));
            this.btnBahçe = new System.Windows.Forms.Button();
            this.btnkat1 = new System.Windows.Forms.Button();
            this.btnKat2 = new System.Windows.Forms.Button();
            this.btnTerasK = new System.Windows.Forms.Button();
            this.flpLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // btnBahçe
            // 
            this.btnBahçe.Location = new System.Drawing.Point(28, 16);
            this.btnBahçe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBahçe.Name = "btnBahçe";
            this.btnBahçe.Size = new System.Drawing.Size(116, 79);
            this.btnBahçe.TabIndex = 0;
            this.btnBahçe.Text = "Bahçe Katı";
            this.btnBahçe.UseVisualStyleBackColor = true;
            this.btnBahçe.Click += new System.EventHandler(this.btnBahçe_Click);
            // 
            // btnkat1
            // 
            this.btnkat1.Location = new System.Drawing.Point(204, 16);
            this.btnkat1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnkat1.Name = "btnkat1";
            this.btnkat1.Size = new System.Drawing.Size(116, 79);
            this.btnkat1.TabIndex = 1;
            this.btnkat1.Text = "1. Kat";
            this.btnkat1.UseVisualStyleBackColor = true;
            this.btnkat1.Click += new System.EventHandler(this.btnkat1_Click);
            // 
            // btnKat2
            // 
            this.btnKat2.Location = new System.Drawing.Point(385, 16);
            this.btnKat2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKat2.Name = "btnKat2";
            this.btnKat2.Size = new System.Drawing.Size(116, 79);
            this.btnKat2.TabIndex = 2;
            this.btnKat2.Text = "2.Kat";
            this.btnKat2.UseVisualStyleBackColor = true;
            this.btnKat2.Click += new System.EventHandler(this.btnKat2_Click);
            // 
            // btnTerasK
            // 
            this.btnTerasK.Location = new System.Drawing.Point(551, 16);
            this.btnTerasK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTerasK.Name = "btnTerasK";
            this.btnTerasK.Size = new System.Drawing.Size(116, 79);
            this.btnTerasK.TabIndex = 3;
            this.btnTerasK.Text = "Teras Katı";
            this.btnTerasK.UseVisualStyleBackColor = true;
            this.btnTerasK.Click += new System.EventHandler(this.btnTerasK_Click);
            // 
            // flpLayoutPanel
            // 
            this.flpLayoutPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flpLayoutPanel.BackgroundImage")));
            this.flpLayoutPanel.Location = new System.Drawing.Point(28, 130);
            this.flpLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpLayoutPanel.Name = "flpLayoutPanel";
            this.flpLayoutPanel.Padding = new System.Windows.Forms.Padding(4);
            this.flpLayoutPanel.Size = new System.Drawing.Size(649, 328);
            this.flpLayoutPanel.TabIndex = 4;
            // 
            // FrmFloorSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1041, 500);
            this.Controls.Add(this.flpLayoutPanel);
            this.Controls.Add(this.btnTerasK);
            this.Controls.Add(this.btnKat2);
            this.Controls.Add(this.btnkat1);
            this.Controls.Add(this.btnBahçe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmFloorSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFloorSelection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBahçe;
        private System.Windows.Forms.Button btnkat1;
        private System.Windows.Forms.Button btnKat2;
        private System.Windows.Forms.Button btnTerasK;
        private System.Windows.Forms.FlowLayoutPanel flpLayoutPanel;
    }
}