using JavaVeJavacilar.Data.Abstracts;
using JavaVeJavacilar.Data.Concrate;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JavaVeJavacilar.Data
{
    public class Context
    {
        private static readonly string _path = "C:/Menu/db.json";

        public static void Load()
        {
            string json = System.IO.File.ReadAllText(_path);

            DataSet = JsonConvert.DeserializeObject<DataSet>(json);

            foreach(var m in DataSet.Katlar)
            {
                for(int i = 1; i <= m.MasaSayisi; i++)
                {
                    Masalar.Add(new Masa()
                    {
                        DoluMu = false,
                        KatBilgisi = m,
                        MasaAdi = m.KatBilgisi + " - " + i,
                    });
                }
            }

            foreach(var u in DataSet.UrunTurleri)
            {
                u.Urunler = DataSet.Urunler.Where(s => s.UrunTuru.TurAdi == u.TurAdi).ToList();
            }
        }

        public static void Save()
        {
            try
            {
                string json = JsonConvert.SerializeObject(DataSet);

                System.IO.File.WriteAllText(_path, json);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static DataSet DataSet { get; set; } = new DataSet();

        public static Menu Menu { 
            get 
            {
                return new Menu()
                {
                    Urunler = DataSet.UrunTurleri
                };
            } 
        }

        public static List<Masa> Masalar { get; set; } = new List<Masa>();
    }
}
