using JavaVeJavacilar.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        public List<Masa> Masalar;
        public void MasaGetir()
        {
            flpLayoutPanel.Controls.Clear();
            foreach (Masa masa in Masalar)
            { 
                    for (int i = 1; i <= masa.MasaSayisi; i++)
                {
                    Button btn = new Button
                    {
                        Text = masa.Prefix + i.ToString(),
                        Name = "btn" + masa.Prefix+i.ToString(),
                        Font = new Font("Trebuchet MS", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(162))),
                        Size = new Size(150, 150)
                    };
                    flpLayoutPanel.Controls.Add(btn);
                }

            }
           
        }
        private void btnBahçe_Click(object sender, EventArgs e)
        {
            
            MasaGetir();
        }
        private void btnkat1_Click(object sender, EventArgs e)
        {
          
            MasaGetir();
        }

        private void btnKat2_Click(object sender, EventArgs e)
        {
            
            MasaGetir();
        }

        private void btnTerasK_Click(object sender, EventArgs e)
        {
           
            MasaGetir();
        }

        private void FrmFloorSelection_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            FileStream fileStream = new FileStream(path + "\\KatInfo.json", FileMode.Open);
            StreamReader reader = new StreamReader(fileStream);
            string dosyaIcerigi = reader.ReadToEnd();
            Masalar = JsonConvert.DeserializeObject<List<Masa>>(dosyaIcerigi);
        }
    }
}
