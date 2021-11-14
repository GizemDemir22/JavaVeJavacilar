using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaVeJavacilar.Models
{
    public abstract class YiyecekTuru
    { 
        public string Isim { get; set; }
        public List<Yemek> Yemekler { get; set; }
    }
}
