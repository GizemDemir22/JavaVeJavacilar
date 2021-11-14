using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaVeJavacilar.Data.Concrate
{
    public class Urun
    {
        public Guid Id { get; set; }
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }
        public byte[] Resim { get; set; }
        public string Aciklama { get; set; }
        public UrunTuru UrunTuru { get; set; }
    }
}
