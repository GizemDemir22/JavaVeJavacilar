
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
            this.flpLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flpKatlar = new System.Windows.Forms.FlowLayoutPanel();
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
            this.flpLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flpLayoutPanel_Paint);
            // 
            // flpKatlar
            // 
            this.flpKatlar.Location = new System.Drawing.Point(32, 28);
            this.flpKatlar.Name = "flpKatlar";
            this.flpKatlar.Size = new System.Drawing.Size(802, 110);
            this.flpKatlar.TabIndex = 5;
            this.flpKatlar.Paint += new System.Windows.Forms.PaintEventHandler(this.flpKatlar_Paint);
            // 
            // FrmFloorSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(870, 611);
            this.Controls.Add(this.flpKatlar);
            this.Controls.Add(this.flpLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFloorSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFloorSelection";
            this.Load += new System.EventHandler(this.FrmFloorSelection_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel flpKatlar;
    }
}