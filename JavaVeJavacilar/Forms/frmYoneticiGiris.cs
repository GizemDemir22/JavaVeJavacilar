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
    public partial class frmYoneticiGiris : Form
    {
        frmYoneticiMiGarsonMi frm;
        public frmYoneticiGiris(frmYoneticiMiGarsonMi fr)
        {
            InitializeComponent();
            frm = fr;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "admin" && txtSifre.Text == "admin")
            {
                var f = new frmYoneticiYetkileri();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı/parola.");
            }
        }

        private void btnGeriGit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm.Show();
        }
    }
}
