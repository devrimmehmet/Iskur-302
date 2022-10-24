using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe
{
    public class Musteri
    {
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
        public string MusteriTC { get; set; }
        public void MusteriBilgileri()
        {
            Araba arabaBilgileri = new Araba();
            Console.WriteLine("Müşteri Adı:");
            MusteriAdi = Console.ReadLine();
            Console.WriteLine("Müşteri Soyadı:");
            MusteriSoyadi = Console.ReadLine();
            Console.WriteLine("Müşteri TC:");
            MusteriTC = Console.ReadLine();
            Console.WriteLine("Hoş Geldiniz {0} {1}",MusteriAdi,MusteriSoyadi);
            arabaBilgileri.ArabaBilgileri();
        }
        public void Getir()
        {
            Random random = new Random();
            
            
            string[] SinifListesi = { "Salih", "Cihat", "Neval", "İlker", "Devrim", "Muhammet", "Burak", "Bedirhan", "Büşra", "Mert Kutlu", "mert Tutunmaz", "Sena", "Erhan", "Berkcan" };
       //     var sehirlerList = new List<string>() { "Salih", "Cihat", "Neval", "İlker", "Devrim", "Muhammet", "Burak", "Bedirhan", "Büşra", "Mert Kutlu", "mert Tutunmaz", "Sena", "Erhan", "Berkcan" };

          //  sehirlerList.Remove("Çankırı");
            Console.WriteLine(SinifListesi[random.Next(0, 14)]);
            Console.ReadLine();
            
        }
        public void Getir2()
        {
            Random random = new Random();


           
                var sehirlerList = new List<string>() { "Salih", "Cihat", "Neval", "İlker", "Devrim", "Muhammet", "Burak", "Bedirhan", "Büşra", "Mert Kutlu", "mert Tutunmaz", "Sena", "Erhan", "Berkcan" };

            //  sehirlerList.Remove("Çankırı");
            Console.WriteLine(sehirlerList[random.Next(0, 14)]);
            Console.ReadLine();

        }
    }
}
