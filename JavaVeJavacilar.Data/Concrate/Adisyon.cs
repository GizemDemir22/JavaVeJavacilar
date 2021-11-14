using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaVeJavacilar.Data.Concrate
{
    public class Adisyon
    {
        public Guid AdisyonId { get; set; } = Guid.NewGuid();
        public List<Siparis> Siparisler { get; set; }
        public decimal Toplam { get; set; }
        public DateTime AdisyonTarihi { get; set; }
    }
}
