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
        public UrunTuru UrunTuruEkle(UrunTuru veri)
        {
            Context.DataSet.UrunTurleri.Add(veri);
            Context.Save();

            return veri;
        }

        public UrunTuru UrunTuruGuncelle(UrunTuru veri)
        {
            UrunTuru u = Context.DataSet.UrunTurleri.Find(u => u.TurAdi == veri.TurAdi);
            if (u != null)
            {
                Context.DataSet.UrunTurleri.Remove(u);
                Context.DataSet.UrunTurleri.Add(veri);
            }

            return veri;
        }

        public void UrunTuruSil(UrunTuru veri)
        {
            UrunTuru u = Context.DataSet.UrunTurleri.Find(u => u.TurAdi == veri.TurAdi);

            if(u != null)
            {
                var silinecek = Context.DataSet.Urunler.Where(u => u.UrunTuru == veri).ToList();

                foreach(var r in silinecek)
                {
                    Context.DataSet.Urunler.Remove(r);
                }

                Context.DataSet.UrunTurleri.Remove(veri);
            }
        }

        public Urun Ekle(Urun veri)
        {
            Context.DataSet.Urunler.Add(veri);
            Context.Save();

            return veri;
        }

        public Urun Guncelle(Urun veri)
        {
            Urun u = Context.DataSet.Urunler.Find(u => u.Id == veri.Id);
            if(u != null)
            {
                Context.DataSet.Urunler.Remove(u);
                Context.DataSet.Urunler.Add(veri);                
            }

            return veri;
        }

        public void Sil(Urun veri)
        {
            Context.DataSet.Urunler.Remove(veri);
            Context.Save();
        }
    }
}
