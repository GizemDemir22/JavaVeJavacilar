using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaVeJavacilar.Data.Concrate
{
    public class UrunTuru
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string TurAdi { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public List<Urun> Urunler { get; set; }

        public override string ToString()
        {
            return TurAdi;
        }
    }
}
