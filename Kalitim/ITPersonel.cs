using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    public class ITPersonel:Personel,IITPersonel
    {
        public ITTecrube Tecrube { get; set; }
        public void ArizalaraMudaheleEt()
        {

        }
        public void KodYaz()
        {

        }

        public void NetworkProblemleriniGider()
        {

        }

        public void KodlariTestEt()
        {
            throw new NotImplementedException();
        }

        public ITPersonel()
        {
            switch (Tecrube)
            {
                case ITTecrube.Az:
                    Maas = 7000;
                    break;
                case ITTecrube.Orta:
                    Maas = 11000;
                    break;
                case ITTecrube.CokTecrubeli:
                    Maas = 15000;
                    break;
                case ITTecrube.UstDuzey:
                    Maas = 25000;
                    break;
                default:
                    break;
            }
        }
    }
}
