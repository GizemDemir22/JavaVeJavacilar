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
    public partial class FrmWaiterLogin : Form
    {
        public FrmWaiterLogin()
        {
            InitializeComponent();
        }
        private List<Garson> garsonlar;

        private void FrmWaiterLogin_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            FileStream fileStream = new FileStream(path + "\\Garson.json", FileMode.Open);
            StreamReader reader = new StreamReader(fileStream);
            string dosyaIcerigi = reader.ReadToEnd();
            garsonlar = JsonConvert.DeserializeObject<List<Garson>>(dosyaIcerigi);
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            foreach (var item in garsonlar)
            {
                if (item.AdSoyad == txtAdSoyad.Text && item.Sifre == txtSifre.Text)
                {
                    FrmFloorSelection frmfloorSelection = new FrmFloorSelection();
                    frmfloorSelection.Show();
                    break;
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
                }
            }

        }

        
    }
}



