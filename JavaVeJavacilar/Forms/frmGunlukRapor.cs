using JavaVeJavacilar.Data;
using JavaVeJavacilar.Data.Concrate;
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
    public partial class frmGunlukRapor : Form
    {
        public frmGunlukRapor()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        decimal gunlukAdisyonToplam = 0;
        Dictionary<string, int> dict = new Dictionary<string, int>();
        private void frmGunlukRapor_Load(object sender, EventArgs e)
        {
            var GününAdisyonlari = Context.DataSet.Adisyonlar.Where(adisyon => adisyon.AdisyonTarihi.Day == DateTime.Now.Day).ToList();
            foreach (var adisyon in GününAdisyonlari)
            {
                var siparisler = adisyon.Siparisler;
                foreach (var siparis in siparisler)
                {
                    var siparisSatirlari = siparis.Urunler;
                    int value;
                    foreach (var siparisSatir in siparisSatirlari)
                    {
                        if (dict.TryGetValue(siparisSatir.Urun.UrunAdi, out value))
                        {
                            dict[siparisSatir.Urun.UrunAdi] += 1;
                            gunlukAdisyonToplam += siparisSatir.Urun.Fiyat;
                        }
                        else
                        {
                            dict[siparisSatir.Urun.UrunAdi] = 1;
                            gunlukAdisyonToplam += siparisSatir.Urun.Fiyat;

                        }
                    }
                }
            }

            foreach (KeyValuePair<string, int> pair in dict)
            {
                // do something with pair.Value or pair.Key
                ListViewItem lvi = listView1.Items.Add(pair.Value.ToString());
                string temp = string.Join(", ", pair.Key);
                lvi.SubItems.Add(temp);
            }

            lblToplam.Text = gunlukAdisyonToplam.ToString();

            //decimal Toplam = 0;
            //var günlükrapor = new GunlukRapor();

            //if (günlükrapor.Adisyonlar.Count > 0)
            //{
            //    foreach (var siparis in günlükrapor.Adisyonlar)
            //    {
            //        foreach (var satir in siparis.Siparisler)
            //        {
            //            var item = new ListViewItem()
            //            {
            //                Text = satir.Urunler.ToString()
            //            };

            //            item.SubItems.Add(
            //                new ListViewItem.ListViewSubItem()
            //                {
            //                    Text = Convert.ToString(satir.Urunler.Count)
            //                }
            //            );
            //----------------

            //        item.SubItems.Add(
            //            new ListViewItem.ListViewSubItem()
            //            {
            //                Text = Convert.ToString(satir.Urunler.)
            //            }
            //        );

            //        item.SubItems.Add(new ListViewItem.ListViewSubItem()
            //        {
            //            Text = Convert.ToString(satir.Adet * satir.Urun.Fiyat)
            //        });

            //        listSiparis.Items.Add(item);

            //        Toplam += satir.Adet * satir.Urun.Fiyat;
            //    }
            //}

            //lblAdisyonToplam.Text = Convert.ToString(Toplam) + "₺";
        }
                }
            }


