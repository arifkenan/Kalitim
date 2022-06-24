using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim.Bilgisayarlar
{
    internal class Bilgisayar:BaseClass
    {
        public Anakart Anakart { get; set; }
        public Cpu Cpu { get; set; }   
        public EkranKarti EkranKarti { get; set; }
        public Kasa Kasa { get; set; }
        public Ram Ram { get; set; }

    }
}
