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
        public void MasaGetir(Masa masa)
        {
            flpLayoutPanel.Controls.Clear();
         
                    for (int i = 1; i <= int.Parse(masa.MasaSayisi); i++)
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
        private void btnBahçe_Click(object sender, EventArgs e)
        {
            foreach (Masa item in Masalar)
            {
                if (item.KatInfo.ToLower()=="Bahçe".ToLower())
                {
                    MasaGetir(item);
                }
            }
            
            
        }
        private void btnkat1_Click(object sender, EventArgs e)
        {

            foreach (Masa item in Masalar)
            {
                if (item.KatInfo.ToLower() == "Kat1".ToLower())
                {
                    MasaGetir(item);
                }
            }
        }

        private void btnKat2_Click(object sender, EventArgs e)
        {

            foreach (Masa item in Masalar)
            {
                if (item.KatInfo.ToLower() == "Kat2".ToLower())
                {
                    MasaGetir(item);
                }
            }
        }

        private void btnTerasK_Click(object sender, EventArgs e)
        {

            foreach (Masa item in Masalar)
            {
                if (item.KatInfo.ToLower() == "Teras".ToLower())
                {
                    MasaGetir(item);
                }
            }
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
