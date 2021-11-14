using JavaVeJavacilar.Data;
using JavaVeJavacilar.Data.Concrate;
using JavaVeJavacilar.Data.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JavaVeJavacilar.Forms
{
    public partial class frmUrunler : Form
    {
        private readonly UrunManager _urunManager = new();

        public frmUrunler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUrunAdi.Text))
            {
                MessageBox.Show(
                       "Ürün adı boş olamaz", "Eksik veri",
                       MessageBoxButtons.OK, MessageBoxIcon.Error
                   );

                return;
            }

            if(!decimal.TryParse(txtFiyat.Text, out var fiyat))
            {
                MessageBox.Show(
                        "Ürün fiyatı sayı olmalı", "Hatalı veri formatı",
                        MessageBoxButtons.OK, MessageBoxIcon.Error
                    );

                return;
            }

            var urun = new Urun
            {
                UrunAdi = txtUrunAdi.Text,
                Fiyat = fiyat,
                Aciklama = txtAciklama.Text,
                UrunTuru = (UrunTuru)cbTurler.SelectedItem
            };

            if (pbUrunGorsel.Image != null)
            {
                MemoryStream resimStream = new MemoryStream();
                pbUrunGorsel.Image.Save(resimStream, ImageFormat.Jpeg);

                urun.Resim = resimStream.ToArray();
            }

            _urunManager.Ekle(urun);

            ListeYenile();
        }

        private void frmUrunler_Load(object sender, EventArgs e)
        {
            lstUrunler.DataSource = Context.DataSet.Urunler;
            cbTurler.DataSource = Context.DataSet.UrunTurleri;

            lstUrunler.SelectedIndex = -1;
        }

        private void pbUrunGorsel_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "Bir fotoğraf seçiniz";
            dialog.Filter = "Resim Dosyaları | *.jpeg; *.jpg";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pbUrunGorsel.ImageLocation = dialog.FileName;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (Secili == null)
                return;

            if (string.IsNullOrEmpty(txtUrunAdi.Text))
            {
                MessageBox.Show(
                       "Ürün adı boş olamaz", "Eksik veri",
                       MessageBoxButtons.OK, MessageBoxIcon.Error
                   );

                return;
            }

            if (!decimal.TryParse(txtFiyat.Text, out var fiyat))
            {
                MessageBox.Show(
                        "Ürün fiyatı sayı olmalı", "Hatalı veri formatı",
                        MessageBoxButtons.OK, MessageBoxIcon.Error
                    );

                return;
            }


            Secili.UrunAdi = txtUrunAdi.Text;
            Secili.Aciklama = txtAciklama.Text;
            Secili.UrunTuru = (UrunTuru)cbTurler.SelectedItem;
            Secili.Fiyat = fiyat;

            if (pbUrunGorsel.Image != null)
            {
                MemoryStream resimStream = new MemoryStream();
                pbUrunGorsel.Image.Save(resimStream, ImageFormat.Jpeg);

                Secili.Resim = resimStream.ToArray();
            }
            else
            {
                Secili.Resim = null;
            }

            _urunManager.Guncelle(Secili);

            ListeYenile();
        }

        private Urun Secili;
        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstUrunler.SelectedIndex > -1)
            {
                Secili = (Urun)lstUrunler.SelectedItem;

                txtUrunAdi.Text = Secili.UrunAdi;
                txtAciklama.Text = Secili.Aciklama;
                txtFiyat.Text = Convert.ToString(Secili.Fiyat);
                
                if(cbTurler.DataSource != null)
                {
                    foreach (UrunTuru tur in (List<UrunTuru>)cbTurler.DataSource)
                    {
                        if (tur.Id == Secili.UrunTuru.Id)
                        {
                            cbTurler.SelectedItem = tur;
                        }
                    }
                }

                if(Secili.Resim != null)
                {
                    pbUrunGorsel.Image = 
                        Image.FromStream(new MemoryStream(Secili.Resim));
                }
            }
            else
            {
                FormTemizle();
            }
        }

        private void lnkTemizle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormTemizle();
        }

        private void FormTemizle()
        {
            Secili = null;
            txtAciklama.Text = "";
            txtFiyat.Text = "";
            txtUrunAdi.Text = "";
            pbUrunGorsel.Image = null;
            cbTurler.SelectedIndex = -1;
            lstUrunler.SelectedIndex = -1;
        }

        private void ListeYenile()
        {
            lstUrunler.DataSource = null;
            lstUrunler.DataSource = Context.DataSet.Urunler;
            lstUrunler.SelectedIndex = -1;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Secili == null)
                return;

            _urunManager.Sil(Secili);

            ListeYenile();
        }
    }
}
