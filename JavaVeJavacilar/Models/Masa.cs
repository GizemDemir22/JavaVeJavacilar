using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaVeJavacilar.Models
{
   public class Masa:IAdisyonKapat
    {
        public Boolean Dolumu { get; set; }
        List<Siparis> Siparisler { get; set; }
        decimal IAdisyonKapat.AdisyonKapat()
        {
            throw new NotImplementedException();
        }
    }
}
