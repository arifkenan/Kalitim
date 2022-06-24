using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim.Bilgisayarlar
{
    internal class Ram:BaseClass
    { 
        public RamTipi RamTipi { get; set; }
        public int Kapasite { get; set; }
    }
    public enum RamTipi { DDR3, DDR4, DDR5 };
}
