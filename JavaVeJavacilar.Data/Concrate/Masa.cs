using JavaVeJavacilar.Data.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaVeJavacilar.Data.Concrate
{
    public class Masa: IMasa
    {
        public bool DoluMu { get; set; }
        public MasaKati KatBilgisi { get; set; }
        public string MasaAdi { get; set; }
        public List<Siparis> Siparisler { get; set; } = new List<Siparis>();
    }
}
