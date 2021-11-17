
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
            this.flpKtl = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpLayoutPanel
            // 
            this.flpLayoutPanel.Location = new System.Drawing.Point(42, 114);
            this.flpLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpLayoutPanel.Name = "flpLayoutPanel";
            this.flpLayoutPanel.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpLayoutPanel.Size = new System.Drawing.Size(881, 208);
            this.flpLayoutPanel.TabIndex = 4;
            this.flpLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flpLayoutPanel_Paint);
            // 
            // flpKatlar
            // 
            this.flpKatlar.Location = new System.Drawing.Point(0, 0);
            this.flpKatlar.Name = "flpKatlar";
            this.flpKatlar.Size = new System.Drawing.Size(200, 100);
            this.flpKatlar.TabIndex = 0;
            // 
            // flpKtl
            // 
            this.flpKtl.Location = new System.Drawing.Point(42, 9);
            this.flpKtl.Name = "flpKtl";
            this.flpKtl.Size = new System.Drawing.Size(881, 100);
            this.flpKtl.TabIndex = 5;
            // 
            // FrmFloorSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = global::JavaVeJavacilar.Properties.Resources.backimage;
            this.ClientSize = new System.Drawing.Size(970, 343);
            this.Controls.Add(this.flpKtl);
            this.Controls.Add(this.flpLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmFloorSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFloorSelection";
            this.Load += new System.EventHandler(this.FrmFloorSelection_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel flpKatlar;
        private System.Windows.Forms.FlowLayoutPanel flpKtl;
    }
}