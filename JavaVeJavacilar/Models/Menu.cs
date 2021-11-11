using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaVeJavacilar.Models
{
   public class Menu :Yemek
    {
        public List<Corbalar> Corbalar { get; set; }
        public List<AnaYemekler> AnaYemekler { get; set; }
        public List<Baslangiclar> Baslangiclar { get; set; }
        public List<Salatalar> Salatalar { get; set; }
        public List<Tatlilar> Tatlilar { get; set;}
        public List<SicakIcecekler> SicakIcecekler { get; set; }
        public List<SogukIcecekler> SogukIcecekler { get; set; }

    }
}
