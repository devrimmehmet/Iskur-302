using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe
{
    internal class Araba
    {
        public string plaka { get; set; }
        public int arabaYasi { get; set; }
        public int ArabaYasi
        {
            get
            {
                return  arabaYasi;
            }
            set
            {
                arabaYasi = value;
                if (arabaYasi>254)
                {
                    arabaYasi = DateTime.Now.Year - arabaYasi;
                }
                
            }
        }
        public bool kazaDurumu { get; set; }
        public void ArabaBilgileri()
        {
            Console.WriteLine("Arabanızın Plakasını Giriniz: ");
            plaka = Console.ReadLine();
            Console.WriteLine("Arabanızın Yaşını yada modelini Giriniz: ");
            ArabaYasi = int.Parse( Console.ReadLine());
            Console.WriteLine("Araba Yaşınız: {0}",arabaYasi);
            Console.WriteLine("Arabanız Kaza Yaptımı: (evet/hayir)");
           string kazaYaptimi = Console.ReadLine();
            if (kazaYaptimi=="evet")
            {
                kazaDurumu = true;
            }else if (kazaYaptimi == "hayır")
            {
                kazaDurumu = false;
            }
            else
            {
                Console.WriteLine("Lütfen evet yada hayır yazınız.");
            }
            OdemeHesapla odemeHesapla = new OdemeHesapla();
            odemeHesapla.Fatura(arabaYasi, kazaDurumu);
        }
    }
}
