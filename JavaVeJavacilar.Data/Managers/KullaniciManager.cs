using JavaVeJavacilar.Data.Abstracts;
using JavaVeJavacilar.Data.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaVeJavacilar.Data.Managers
{
    public class KullaniciManager : IEklenebilirSilinebilir<Kullanici> 
    {
        public Kullanici Ekle(Kullanici veri)
        {
            Context.DataSet.Kullanicilar.Add(veri as Garson);
            Context.Save();

            return veri;
        }

        public Kullanici Guncelle(Kullanici veri)
        {
            Garson g = Context.DataSet.Kullanicilar.Where(k => k.Id == veri.Id).FirstOrDefault();

            if (g != null)
            {
                Context.DataSet.Kullanicilar.Remove(g);
                Context.DataSet.Kullanicilar.Add(veri as Garson);
                Context.Save();
            }

            return g;
        }

        public void Sil(Kullanici veri)
        {
            Context.DataSet.Kullanicilar.Remove(veri as Garson);
            Context.Save();
        }
    }
}
