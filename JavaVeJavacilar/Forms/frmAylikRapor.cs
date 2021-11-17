using JavaVeJavacilar.Data;
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
    public partial class frmAylikRapor : Form
    {
        public frmAylikRapor()
        {
            InitializeComponent();
        }
        decimal aylikAdisyonToplami;
        DateTimePicker dtp = new DateTimePicker();
        Dictionary<string, int> dict = new Dictionary<string, int>();
        private void frmAylikRapor_Load(object sender, EventArgs e)
        {
            aylikAdisyonToplami = 0;
            for (DateTime a = DateTime.Now.AddDays(-2); a <= dtp.Value.AddDays(30); a = a.AddDays(1))
            {
                var query = Context.DataSet.Adisyonlar.Where(adisyom => adisyom.AdisyonTarihi.Day == a.Day);
                foreach (var adisyon in query)
                {
                    var siparisler = adisyon.Siparisler;
                    var sum = siparisler.Sum(x => x.Urunler.Sum(y => y.Urun.Fiyat * y.Adet));
                    aylikAdisyonToplami += sum;
                    //foreach (var siparis in siparisler)
                    //{
                    //    var siparisSatirlari = siparis.Urunler;
                    //    int value;
                    //    foreach (var siparisSatir in siparisSatirlari)
                    //    {
                    //        if (dict.TryGetValue(siparisSatir.Urun.UrunAdi, out value))
                    //        {
                    //            dict[siparisSatir.Urun.UrunAdi] += 1;
                    //            aylikAdisyonToplami += siparisSatir.Urun.Fiyat * siparisSatir.Adet;
                    //        }
                    //        else
                    //        {
                    //            dict[siparisSatir.Urun.UrunAdi] = 1;
                    //            aylikAdisyonToplami += siparisSatir.Urun.Fiyat * siparisSatir.Adet;

                    //        }
                    //    }
                    //}
                }
                lblToplam.Text = aylikAdisyonToplami.ToString();
            }

        }
    }
}
