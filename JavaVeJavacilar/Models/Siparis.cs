using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaVeJavacilar.Models
{
   public class Siparis:Yemek
    {
        public int SiparisId { get; set; }
        public decimal HesapTutari { get; set; }
        public DateTime SiparisDate { get; set; }

    }
}
