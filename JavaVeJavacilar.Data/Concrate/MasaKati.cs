using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaVeJavacilar.Data.Concrate
{
    public class MasaKati
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int MasaSayisi { get; set; }
        public string KatBilgisi { get; set; }

        public override string ToString()
        {
            return KatBilgisi;
        }

    }
}
