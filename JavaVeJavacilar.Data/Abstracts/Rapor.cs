using JavaVeJavacilar.Data.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaVeJavacilar.Data.Abstracts
{
    public abstract class Rapor
    {
        public decimal Toplam { get; set; }
        public DateTime AdisyonTarihi { get; set; }
        public List<Adisyon> Adisyonlar { get; set; } = new List<Adisyon>();

    }
}
