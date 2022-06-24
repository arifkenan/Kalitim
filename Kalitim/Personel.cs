using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    public class Personel:Kisi,IPersonel
    {

        public int Maas { get; set; }
        public string Departman { get; set; }
        public string Pozisyon { get; set; }

        public Personel()
        {
            Maas = 4500;
        }
        public Personel(string ad, string soyad)
        {
            Adı = ad;
            Soyadı = soyad;
            Maas = 4500;
        }

        public bool isezamanindagel()
        {
            throw new NotImplementedException();
        }
    }
}
