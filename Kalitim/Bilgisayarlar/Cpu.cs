using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim.Bilgisayarlar
{
    internal class Cpu:BaseClass
    {
        public Marka Marka { get; set; }
        public string Model { get; set; }
        public string Frekans { get; set; }
    }

    public enum CpuTip { Intel, Amd }
}
