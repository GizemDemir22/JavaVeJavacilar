
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
            // flpLayoutPanel
            // 
            this.flpLayoutPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flpLayoutPanel.BackgroundImage")));
            this.flpLayoutPanel.Location = new System.Drawing.Point(32, 144);
            this.flpLayoutPanel.Name = "flpLayoutPanel";
            this.flpLayoutPanel.Padding = new System.Windows.Forms.Padding(5);
            this.flpLayoutPanel.Size = new System.Drawing.Size(802, 447);
            this.flpLayoutPanel.TabIndex = 4;
            // 
            // FrmFloorSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(994, 667);
            this.Controls.Add(this.flpLayoutPanel);
            this.Controls.Add(this.btnTerasK);
            this.Controls.Add(this.btnKat2);
            this.Controls.Add(this.btnkat1);
            this.Controls.Add(this.btnBahçe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFloorSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFloorSelection";
            this.Load += new System.EventHandler(this.FrmFloorSelection_Load);
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