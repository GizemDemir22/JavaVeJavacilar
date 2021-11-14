using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JavaVeJavacilar.Data.Concrate
{
    public class UrunTuru
    {
        public string TurAdi { get; set; }

        [JsonIgnore]
        public List<Urun> Urunler { get; set; }
    }
}
