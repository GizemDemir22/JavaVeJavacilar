using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaVeJavacilar.Data.Abstracts
{
    public abstract class Kullanici
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string KullaniciAdi { get; set; }
        public string Parola { get; set; }
        public bool YoneticiMi { get; set; } = false;
    }
}
