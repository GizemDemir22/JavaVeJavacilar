using JavaVeJavacilar.Data;
using JavaVeJavacilar.Data.Abstracts;
using JavaVeJavacilar.Data.Concrate;
using JavaVeJavacilar.Data.Managers;
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
        private void btnGiris_Click(object sender, EventArgs e)
        {

            var manager = new LoginManager();

            if (manager.GirisYap(txtKullaniciAdi.Text, txtSifre.Text))
            {
                FrmFloorSelection frmfloorSelection = new FrmFloorSelection();
                frmfloorSelection.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

        }
    }
}



