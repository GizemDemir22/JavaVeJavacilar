using JavaVeJavacilar.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JavaVeJavacilar.Forms
{
    public partial class FrmFloorSelection : Form
    {
        public FrmFloorSelection()
        {
            InitializeComponent();
        }
      
        public string[] Masa = new string[10];
        public void MasaGetir(int baslangicSayisi)
        {
            for (int i = baslangicSayisi; i <= baslangicSayisi + 7; i++)
            {
                flpLayoutPanel.Controls.Clear();
                Button btn = new Button
                {
                    Text = "Masa " + i,
                    Name = "btn_" + i,
                    Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(162))),
                    Size = new Size(150, 150)
                };
                flpLayoutPanel.Controls.Add(btn);
            }
        }
        private void btnBahçe_Click(object sender, EventArgs e)
        {
            
            MasaGetir(1);
        }
        private void btnkat1_Click(object sender, EventArgs e)
        {
          
            MasaGetir(9);
        }

        private void btnKat2_Click(object sender, EventArgs e)
        {
            
            MasaGetir(17);
        }

        private void btnTerasK_Click(object sender, EventArgs e)
        {
           
            MasaGetir(25);
        }
    }
}
