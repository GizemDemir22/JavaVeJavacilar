using JavaVeJavacilar.Data;
using JavaVeJavacilar.Data.Abstracts;
using JavaVeJavacilar.Data.Concrate;
using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Context.DataSet.Kullanicilar.Add(new Garson() { KullaniciAdi = "ömer", Parola = "123" });

                //Context.DataSet.Katlar.Add(new MasaKati()
                //{
                //    KatBilgisi = "Bahçe Katı",
                //    MasaSayisi = 10
                //});
                //Context.DataSet.UrunTurleri.Add(new UrunTuru()
                //{
                //    TurAdi = "Çorbalar"
                //});
                //Context.DataSet.UrunTurleri.Add(new UrunTuru()
                //{
                //    TurAdi = "Ana Yemek"
                //});

                //Context.DataSet.Urunler.Add(new Urun()
                //{
                //    UrunTuru = new UrunTuru()
                //    {
                //        TurAdi = "Çorbalar"
                //    },
                //    Fiyat = 12,
                //    UrunAdi = "Ezogelin"
                //}); 

                //Context.DataSet.Urunler.Add(new Urun()
                //{
                //    UrunTuru = new UrunTuru()
                //    {
                //        TurAdi = "Ana Yemek"
                //    },
                //    Fiyat = 40,
                //    UrunAdi = "Pirzola"
                //});

                //Context.Save();

                Context.Load();


                foreach(var k in Context.DataSet.Kullanicilar)
                {
                    Console.WriteLine(k.KullaniciAdi);
                }

                foreach(var u in Context.DataSet.Urunler)
                {
                    Console.WriteLine($"{u.UrunAdi} - {u.Fiyat} - {u.UrunTuru.TurAdi}");
                }

                foreach(var k in Context.Masalar)
                {
                    Console.WriteLine(k.MasaAdi);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.ReadKey();

        }
    }
}
