using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim.Bilgisayarlar
{
    internal class BaseClass
    {
        public Marka Marka { get; set; }
        public int Model { get; set; }
        public decimal Fiyat { get; set; }
        public DateTime GarantiBaslangic { get; set; }
        public DateTime GarantiBitis { get; set; }

    }
}
