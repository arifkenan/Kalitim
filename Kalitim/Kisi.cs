using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    public class Kisi
    {
        public string Adı { get; set; }
        public string Soyadı { get; set; }
        public string TcNo { get; set; }
        public string Gsm { get; set; }
        public string Email { get; set; }
        public DateTime DogumTarihi { get; set; }
        public bool Cinsiyet { get; set; }


        public Kisi()
        {

        }
        public Kisi(string ad, string soyad)
        {
            Adı = ad;
            Soyadı = soyad;
        }
        public Kisi(string ad, string soyad, string tcno)
        {
            Adı = ad;
            Soyadı = soyad;
            TcNo = tcno;
        }


    }







}
