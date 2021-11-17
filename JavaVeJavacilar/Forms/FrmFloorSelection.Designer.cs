
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpLayoutPanel
            // 
            this.flpLayoutPanel.Location = new System.Drawing.Point(110, 143);
            this.flpLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.flpLayoutPanel.Name = "flpLayoutPanel";
            this.flpLayoutPanel.Padding = new System.Windows.Forms.Padding(6);
            this.flpLayoutPanel.Size = new System.Drawing.Size(844, 94);
            this.flpLayoutPanel.TabIndex = 4;
            // 
            // flpKatlar
            // 
            this.flpKatlar.Location = new System.Drawing.Point(8, 7);
            this.flpKatlar.Margin = new System.Windows.Forms.Padding(2);
            this.flpKatlar.Name = "flpKatlar";
            this.flpKatlar.Size = new System.Drawing.Size(96, 352);
            this.flpKatlar.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Goldenrod;
            this.button1.Location = new System.Drawing.Point(841, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 41);
            this.button1.TabIndex = 13;
            this.button1.Text = "Geri";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmFloorSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = global::JavaVeJavacilar.Properties.Resources.backimage;
            this.ClientSize = new System.Drawing.Size(958, 364);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flpKatlar);
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
        private System.Windows.Forms.Panel pnlKatlar;
        private System.Windows.Forms.FlowLayoutPanel flpKatlar;
        private System.Windows.Forms.Button button1;
    }
}