using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaVeJavacilar.Models
{
   public class Masa:IAdisyonKapat
    {
        public string KatInfo { get; set; }
        public string MasaSayisi { get; set; }
        public string Prefix { get; set; }
        public Boolean Dolumu { get; set; }
        public List<Siparis> Siparisler { get; set; }
        decimal IAdisyonKapat.AdisyonKapat()
        {
            throw new NotImplementedException();
        }
    }
}
