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
    public partial class frmAdisyon : Form
    {

        private readonly AdisyonManager _adisyonManager = new();

        public Masa Masa { get; set; }

        public frmAdisyon()
        {
            InitializeComponent();
        }

        private void frmAdisyon_Load(object sender, EventArgs e)
        {
            decimal Toplam = 0;

            lblMasaNo.Text = Masa.MasaAdi;
            lblDateTime.Text = DateTime.Now.ToString("G");

            if(Masa.Siparisler.Count > 0)
            {
                foreach(var siparis in Masa.Siparisler)
                {
                    foreach(var satir in siparis.Urunler)
                    {
                        var item = new ListViewItem()
                        {
                            Text = satir.Urun.UrunAdi
                        };

                        item.SubItems.Add(
                            new ListViewItem.ListViewSubItem() {  
                                Text = Convert.ToString(satir.Adet) 
                            }
                        );

                        item.SubItems.Add(
                            new ListViewItem.ListViewSubItem() { 
                                Text = Convert.ToString(satir.Urun.Fiyat) 
                            }
                        );

                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { 
                            Text = Convert.ToString(satir.Adet * satir.Urun.Fiyat) 
                        });

                        listSiparis.Items.Add(item);

                        Toplam += satir.Adet * satir.Urun.Fiyat;
                    }
                }

                lblAdisyonToplam.Text = Convert.ToString(Toplam) + "₺";
            }
        }

        //https://www.ismailgursoy.com.tr/c-print-islemleri-siparis-formu-ornegi-4/
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Yazı fontumu ve çizgi çizmek için fırçamı ve kalem nesnemi oluşturdum
            Font myFont = new Font("Calibri", 28);
            SolidBrush sbrush = new SolidBrush(Color.Black);
            Pen myPen = new Pen(Color.Black);

            //Bu kısımda sipariş formu yazısını ve çizgileri yazdırıyorum
            e.Graphics.DrawLine(myPen, 120, 120, 750, 120);
            e.Graphics.DrawLine(myPen, 120, 180, 750, 180);
            e.Graphics.DrawString(Masa.MasaAdi + " Adisyonu", myFont, sbrush, 200, 120);

            e.Graphics.DrawLine(myPen, 120, 320, 750, 320);

            myFont = new Font("Calibri", 12, FontStyle.Bold);
            e.Graphics.DrawString("Adet", myFont, sbrush, 140, 328);
            e.Graphics.DrawString("Ürün Adı", myFont, sbrush, 240, 328);
            e.Graphics.DrawString("Birim Fiyatı", myFont, sbrush, 440, 328);
            e.Graphics.DrawString("Fiyat", myFont, sbrush, 640, 328);

            e.Graphics.DrawLine(myPen, 120, 348, 750, 348);

            int y = 360;

            StringFormat myStringFormat = new StringFormat();
            myStringFormat.Alignment = StringAlignment.Far;

            decimal gTotal = 0;

            foreach (ListViewItem lvi in listSiparis.Items)
            {
                e.Graphics.DrawString(lvi.SubItems[1].Text, myFont, sbrush, 160, y, myStringFormat);
                e.Graphics.DrawString(lvi.Text, myFont, sbrush, 220, y);
                decimal bFiyat = Convert.ToDecimal(lvi.SubItems[2].Text);
                decimal fiyat = Convert.ToDecimal(lvi.SubItems[1].Text) * Convert.ToDecimal(lvi.SubItems[2].Text);
                gTotal += fiyat;
                e.Graphics.DrawString(bFiyat.ToString("c"), myFont, sbrush, 530, y, myStringFormat);
                e.Graphics.DrawString(fiyat.ToString("c"), myFont, sbrush, 700, y, myStringFormat);

                y += 20;

            }

            e.Graphics.DrawLine(myPen, 120, y, 750, y);
            e.Graphics.DrawString(gTotal.ToString("c"), myFont, sbrush, 700, y + 10, myStringFormat);

        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            _adisyonManager.AdisyonOlustur(Masa);

            DialogResult pdr = printDialog1.ShowDialog();
            if (pdr == DialogResult.OK)
            {
                printDocument1.Print();

                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
