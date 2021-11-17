using JavaVeJavacilar.Data;
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
    public partial class FrmMenu : Form
    {
        private readonly SiparisManager _siparisManager = new();

        private Siparis Siparis = new();

        public Masa masa;

        FrmFloorSelection frmFloorSelection;
        public FrmMenu(FrmFloorSelection frmFloorSelection)
        {
            InitializeComponent();
            this.frmFloorSelection = frmFloorSelection;
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            ImageList list = new ImageList();
            list.ImageSize = new Size(96, 96);

            foreach (var tur in Context.DataSet.UrunTurleri)
            {

                var group = new ListViewGroup()
                {
                    Header = tur.TurAdi,
                    Name = tur.TurAdi
                };

                listUrunler.Groups.Add(group);

                foreach( var urun in tur.Urunler)
                {
                    list.Images.Add(urun.Id.ToString(), Image.FromStream(new MemoryStream(urun.Resim)));

                    listUrunler.LargeImageList = list;

                    var item = new ListViewItem()
                    {
                        Text = urun.UrunAdi + " - " + urun.Fiyat,
                        Name = urun.UrunAdi,
                        ImageKey = urun.Id.ToString(),
                        Group = group,
                        Tag = urun
                    };

                    listUrunler.Items.Add(item);
                }
            }

            if(masa.Siparisler.Count > 0)
            {
                foreach(var siparis in masa.Siparisler)
                {
                    foreach(var urun in siparis.Urunler)
                    {
                        lstOzet.Items.Add(urun.Adet + "x " + urun.Urun.UrunAdi + " - " + (urun.Urun.Fiyat * urun.Adet) + "₺");
                    }
                }

                btnAdisyon.Enabled = true;
            }
        }

 




        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var seciliUrunler = new List<Urun>();

            foreach (var urun in listHesap.Items)
            {
                seciliUrunler.Add((Urun)urun);
            }

            if (seciliUrunler.Count <= 0)
            {
                MessageBox.Show("Eklenecek ürün bulunamadı.");
                return;
            }

            var siparisItems = new List<SiparisSatir>();

            foreach (var urun in seciliUrunler)
            {
                if (siparisItems.Any(s => s.Urun == urun))
                {
                    int index = siparisItems.FindIndex(u => u.Urun == urun);
                    siparisItems[index].Adet = siparisItems[index].Adet + 1;
                }
                else
                {
                    siparisItems.Add(new SiparisSatir()
                    {
                        Adet = 1,
                        Urun = urun
                    });
                }
            }

            var siparis = new Siparis()
            {
                Urunler = siparisItems
            };

            _siparisManager.Ekle(siparis, masa);

            this.DialogResult = DialogResult.OK;
        }

        private void listUrunler_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (listUrunler.SelectedItems.Count == 1)
            {
                var selectedItem = listUrunler.SelectedItems[0].Tag as Urun;

                listHesap.Items.Add(selectedItem);
            }
        }

        private void btnAdisyon_Click(object sender, EventArgs e)
        {
            var f = new frmAdisyon();

            f.Masa = masa;

            if (f.ShowDialog(this) == DialogResult.OK)
            {
                masa.DoluMu = false;
                masa.Siparisler = new List<Siparis>();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void listHesap_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listHesap.SelectedItems.Count == 1)
            {
                listHesap.Items.Remove(listHesap.SelectedItem);
            }
        }

        private void listUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.frmFloorSelection.Show();
        }
    }

}
 

