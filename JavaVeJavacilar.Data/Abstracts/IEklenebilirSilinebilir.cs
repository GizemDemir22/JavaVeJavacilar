using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaVeJavacilar.Data.Abstracts
{
    public interface IEklenebilirSilinebilir<T>
    {
        T Ekle(T veri);
        T Guncelle(T veri);
        void Sil(T veri);
    }
}
