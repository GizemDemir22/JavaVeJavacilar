using JavaVeJavacilar.Data.Abstracts;
using JavaVeJavacilar.Data.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaVeJavacilar.Data.Managers
{
    public class AdisyonManager : IEklenebilirSilinebilir<Adisyon>
    {
        public Adisyon AdisyonOlustur(Masa masa)
        {
            Adisyon yeni = new();

            yeni.AdisyonTarihi = DateTime.Now;
            yeni.Siparisler = masa.Siparisler;
            
            foreach(var s in yeni.Siparisler)
            {
                yeni.Toplam += s.Urunler.Sum(s => s.Adet * s.Urun.Fiyat);
            }

            masa.DoluMu = false;
            masa.Siparisler = new List<Siparis>();

            return Ekle(yeni);
        }

        public Adisyon Ekle(Adisyon veri)
        {
            Context.DataSet.Adisyonlar.Add(veri);
            Context.Save();

            return veri;
        }

        public Adisyon Guncelle(Adisyon veri)
        {
            throw new NotImplementedException();
        }

        public void Sil(Adisyon veri)
        {
            Context.DataSet.Adisyonlar.Remove(veri);
            Context.Save();
        }
    }
}
