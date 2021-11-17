
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
            this.flpLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flpKatlar = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpLayoutPanel
            // 
            this.flpLayoutPanel.Location = new System.Drawing.Point(158, 251);
            this.flpLayoutPanel.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.flpLayoutPanel.Name = "flpLayoutPanel";
            this.flpLayoutPanel.Padding = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.flpLayoutPanel.Size = new System.Drawing.Size(1205, 156);
            this.flpLayoutPanel.TabIndex = 4;
            // 
            // flpKatlar
            // 
            this.flpKatlar.Location = new System.Drawing.Point(12, 12);
            this.flpKatlar.Name = "flpKatlar";
            this.flpKatlar.Size = new System.Drawing.Size(137, 586);
            this.flpKatlar.TabIndex = 5;
            // 
            // FrmFloorSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = global::JavaVeJavacilar.Properties.Resources.backimage;
            this.ClientSize = new System.Drawing.Size(1368, 606);
            this.Controls.Add(this.flpKatlar);
            this.Controls.Add(this.flpLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmFloorSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFloorSelection";
            this.Load += new System.EventHandler(this.FrmFloorSelection_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpLayoutPanel;
        private System.Windows.Forms.Panel pnlKatlar;
        private System.Windows.Forms.FlowLayoutPanel flpKatlar;
    }
}