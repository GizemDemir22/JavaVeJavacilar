using JavaVeJavacilar.Data.Abstracts;
using JavaVeJavacilar.Data.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaVeJavacilar.Data.Managers
{
    public class UrunManager : IEklenebilirSilinebilir<Urun>
    {
        public Urun Ekle(Urun veri)
        {
            Context.Urunler.Add(veri);
            Context.Save();

            return veri;
        }

        public Urun Guncelle(Urun veri)
        {
            Urun u = Context.Urunler.Find(u => u.Id == veri.Id);
            if(u != null)
            {
                Context.Urunler.Remove(u);
                Context.Urunler.Add(veri);                
            }

            return veri;
        }

        public void Sil(Urun veri)
        {
            Context.Urunler.Remove(veri);
            Context.Save();
        }
    }
}
