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
    public partial class frmKatlar : Form
    {
        private readonly MasaManager _masaManager = new();

        public frmKatlar()
        {
            InitializeComponent();
        }

        private void frmKatlar_Load(object sender, EventArgs e)
        {
            lstKatlar.DataSource = Context.DataSet.Katlar;

            lstKatlar.SelectedIndex = -1;
        }

        private MasaKati Secili;
        private void lstKatlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstKatlar.SelectedIndex > -1)
            {
                Secili = (MasaKati)lstKatlar.SelectedItem;

                txtSayi.Text = Convert.ToString(Secili.MasaSayisi);
                txtKatAdi.Text = Secili.KatBilgisi;
            }
            else
            {
                FormTemizle();
            }
        }

        private void FormTemizle()
        {
            Secili = null;
            txtKatAdi.Text = "";
            txtSayi.Text = "";
            lstKatlar.SelectedIndex = -1;
        }

        private void ListeYenile()
        {
            lstKatlar.DataSource = null;
            lstKatlar.DataSource = Context.DataSet.Katlar;

            lstKatlar.SelectedIndex = -1;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKatAdi.Text))
            {
                MessageBox.Show(
                       "Bölüm bilgisi boş olamaz", "Eksik veri",
                       MessageBoxButtons.OK, MessageBoxIcon.Error
                   );

                return;
            }

            if(!int.TryParse(txtSayi.Text, out int sayi))
            {
                MessageBox.Show(
                       "Masa sayısı sayı ile belirtilmeli.", "Hatalı veri",
                       MessageBoxButtons.OK, MessageBoxIcon.Error
                   );

                return;
            }

            _masaManager.Ekle(new MasaKati()
            {
                KatBilgisi = txtKatAdi.Text,
                MasaSayisi = sayi
            });

            ListeYenile();
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKatAdi.Text))
            {
                MessageBox.Show(
                       "Bölüm bilgisi boş olamaz", "Eksik veri",
                       MessageBoxButtons.OK, MessageBoxIcon.Error
                   );

                return;
            }

            if (!int.TryParse(txtSayi.Text, out int sayi))
            {
                MessageBox.Show(
                       "Masa sayısı sayı ile belirtilmeli.", "Hatalı veri",
                       MessageBoxButtons.OK, MessageBoxIcon.Error
                   );

                return;
            }

            _masaManager.Guncelle(new MasaKati()
            {
                Id = Secili.Id,
                KatBilgisi = txtKatAdi.Text,
                MasaSayisi = sayi
            });

            ListeYenile();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(Secili == null)
            {
                return;
            }

            _masaManager.Sil(Secili);
            ListeYenile();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormTemizle();
        }
    }
}
