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
    public partial class frmUrunTurleri : Form
    {
        private readonly UrunManager _urunManager = new();
        public frmUrunTurleri()
        {
            InitializeComponent();
        }

        private void frmUrunTurleri_Load(object sender, EventArgs e)
        {
            lstUrunTurleri.DataSource = Context.DataSet.UrunTurleri;

            lstUrunTurleri.SelectedIndex = -1;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTurAdi.Text))
            {
                return;
            }

            if (_urunManager.UrunTuruKontrolEt(txtTurAdi.Text))
            {
                MessageBox.Show(
                        "Bu ürün türü adı kullanılıyor.", "Tekrar Eden Veri",
                        MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
                return;
            }

            var tur = new UrunTuru()
            {
                TurAdi = txtTurAdi.Text
            };

            _urunManager.UrunTuruEkle(tur);

            lstUrunTurleri.DataSource = null;
            lstUrunTurleri.DataSource = Context.DataSet.UrunTurleri;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (Secili == null)
                return;


            Secili.TurAdi = txtTurAdi.Text;

            _urunManager.UrunTuruGuncelle(Secili);

            lstUrunTurleri.DataSource = null;
            lstUrunTurleri.DataSource = Context.DataSet.UrunTurleri;

            MessageBox.Show("Ürünü türü bilgileri güncellendi.", "İşlem Başarılı",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private UrunTuru Secili;
        private void lstUrunTurleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrunTurleri.SelectedIndex > -1)
            {
                Secili = (UrunTuru)lstUrunTurleri.SelectedItem;

                txtTurAdi.Text = Secili.TurAdi;
            }
            else
            {
                Secili = null;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Secili == null)
                return;

            _urunManager.UrunTuruSil(Secili);

            lstUrunTurleri.DataSource = null;
            lstUrunTurleri.DataSource = Context.DataSet.UrunTurleri;
        }
    }
}
