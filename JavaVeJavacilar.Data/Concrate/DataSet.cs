using JavaVeJavacilar.Data.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaVeJavacilar.Data.Concrate
{
    public class DataSet
    {
        public List<Garson> Kullanicilar { get; set; } = new List<Garson>();
        public List<MasaKati> Katlar { get; set; } = new List<MasaKati>();
        public List<Adisyon> Adisyonlar { get; set; } = new List<Adisyon>();
        public List<Urun> Urunler { get; set; } = new List<Urun>();
        public List<UrunTuru> UrunTurleri { get; set; } = new List<UrunTuru>();
    }
}
