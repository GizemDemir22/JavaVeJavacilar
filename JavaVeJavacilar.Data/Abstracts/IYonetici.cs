using JavaVeJavacilar.Data.Concrate;
using JavaVeJavacilar.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaVeJavacilar.Data.Abstracts
{
    public interface IYonetici
    {
        Rapor Rapor(RaporTuru raporTuru);

        void KatEkle(MasaKati katBilgisi);

        void KatSil(MasaKati katBilgisi);

        void UrunEkle(Urun urunBilgisi);

        void UrunSil(Urun urunBilgisi);

        void UrunTuruEkle(UrunTuru tur);

        void UrunTuruSil(UrunTuru tur);
    }
}
