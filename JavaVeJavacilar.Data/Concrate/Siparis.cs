using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaVeJavacilar.Data.Concrate
{
    public class Siparis
    {
        public Guid SiparisId { get; set; } = Guid.NewGuid();

        public DateTime SiparisTarihi { get; set; } = DateTime.Now;
 
        public List<SiparisSatir> Urunler { get; set; }

        //public void ToplamHesaplama()
        //{
        //    decimal toplam = 0;
        //    foreach(Urun urun in Urunler)
        //    {
        //        toplam += urun.Fiyat;
        //    }
        //}

    }
}
