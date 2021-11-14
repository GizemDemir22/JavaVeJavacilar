using JavaVeJavacilar.Data.Abstracts;
using JavaVeJavacilar.Data.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaVeJavacilar.Data.Managers
{
    public class SiparisManager
    {
        public void Ekle(Siparis veri, Masa masa)
        {
            masa.Siparisler.Add(veri);
        }

        public Siparis Guncelle(Siparis veri)
        {
            throw new NotImplementedException();
        }

        public void Sil(Siparis veri)
        {
            throw new NotImplementedException();
        }
    }
}
