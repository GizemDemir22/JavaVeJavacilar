using JavaVeJavacilar.Data.Abstracts;
using JavaVeJavacilar.Data.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaVeJavacilar.Data.Managers
{
    public class MasaManager : IEklenebilirSilinebilir<MasaKati>
    {
        public MasaKati Ekle(MasaKati veri)
        {
            Context.DataSet.Katlar.Add(veri);
            Context.Save();

            return veri;
        }

        public MasaKati Guncelle(MasaKati veri)
        {
            MasaKati kat = Context.DataSet.Katlar.Where(k => k.Id == veri.Id).FirstOrDefault();

            if(kat != null)
            {
                Context.DataSet.Katlar.Remove(kat);
                Context.DataSet.Katlar.Add(veri);
                Context.Save();
            }

            return veri;
        }

        public void Sil(MasaKati veri)
        {
            Context.DataSet.Katlar.Remove(veri);
            Context.Save();
        }
    }
}
