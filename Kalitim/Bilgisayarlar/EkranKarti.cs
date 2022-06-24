using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim.Bilgisayarlar
{
    public enum EkranKartiTipi { Nvidia, Amd}
    internal class EkranKarti:BaseClass
    {
        public EkranKartiTipi KartiTipi { get; set; }
        public int Kapasite { get; set; }

    }
}
