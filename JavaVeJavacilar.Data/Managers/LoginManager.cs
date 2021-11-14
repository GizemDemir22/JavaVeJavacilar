using JavaVeJavacilar.Data.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaVeJavacilar.Data.Managers
{
    public class LoginManager
    {
        public bool GirisYap(string kullanici, string parola)
        {

            //foreach(Kullanici k in Context.Kullanicilar)
            //{
            //    if (k.KullaniciAdi == kullanici.KullaniciAdi && k.Parola == kullanici.Parola)
            //        return true;
            //}

            if (Context.DataSet.Kullanicilar
                .Any(s => s.KullaniciAdi == kullanici &&
                s.Parola == parola))
            {
                return true;
            }

            return false;
        }
    }
}
