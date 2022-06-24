using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim.Bilgisayarlar
{
    public enum KasaTip {SlimTower, MiniTower, MidiTower, Tower}
    internal class Kasa:BaseClass
    {
      
        public KasaTip KasaTip{ get; set; }
    }
}
