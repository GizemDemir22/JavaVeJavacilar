using JavaVeJavacilar.Data;
using JavaVeJavacilar.Data.Concrate;
using JavaVeJavacilar.Data.Managers;
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
    public partial class FrmKullanicilar : Form
    {
        private readonly KullaniciManager _kullaniciManager = new();
        public FrmKullanicilar()
        {
            InitializeComponent();
        }

        private void FrmKullanicilar_Load(object sender, EventArgs e)
        {
            lstKullanicilar.DataSource = Context.DataSet.Kullanicilar;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Secili == null)
                return;

            var kullanici = Context.DataSet.Kullanicilar.Where(s => s.Id == Secili.Id)
                .FirstOrDefault();

            kullanici.KullaniciAdi = txtKullaniciAdi.Text;
            kullanici.Parola = txtParola.Text;

            _kullaniciManager.Guncelle(kullanici);

            lstKullanicilar.DataSource = null;
            lstKullanicilar.DataSource = Context.DataSet.Kullanicilar;

            MessageBox.Show("Kullanıcı bilgileri güncellendi.", "İşlem Başarılı",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private Garson Secili;
        private void lstKullanicilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstKullanicilar.SelectedIndex > -1)
            {
                Secili = (Garson)lstKullanicilar.SelectedItem;

                txtKullaniciAdi.Text = Secili.KullaniciAdi;
                txtParola.Text = Secili.Parola;
            }
            else
            {
                Secili = null;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var kullanici = new Garson()
            {
                KullaniciAdi = txtKullaniciAdi.Text,
                Parola = txtParola.Text
            };

            if (_kullaniciManager.KontrolEt(kullanici.KullaniciAdi))
            {
                MessageBox.Show(
                        "Kullanıcı adı kullanılıyor.", "Tekrar Eden Veri",  
                        MessageBoxButtons.OK, MessageBoxIcon.Error
                    );

                return;
            }

            _kullaniciManager.Ekle(kullanici);

            lstKullanicilar.DataSource = null;
            lstKullanicilar.DataSource = Context.DataSet.Kullanicilar;
        }
    }
}
