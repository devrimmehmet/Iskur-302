using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double elma = 3, armut = 5, muz = 7;
            double kackg, toplam = 0;
            string secim;
        start:
            Console.WriteLine("Ne almak istersiniz? (Elma,Armut,Muz)");
            secim = Console.ReadLine();
            if (secim != "Elma" && secim != "Armut" && secim != "Muz")
            {
                Console.WriteLine("Seçtiğiniz ürün maleesef yok.");
                goto start;
            }
            Console.WriteLine("Kaç kg almak istiyorsunuz?");
            kackg = Convert.ToDouble(Console.ReadLine());
            switch (secim)
            {
                case "Elma": toplam = elma * kackg; break;
                case "Armut": toplam = armut * kackg; break;
                case "Muz": toplam = muz * kackg; break;
            }
            if (toplam < 50)
            {
                Console.WriteLine("Toplam Fiyat: {0}TL İndirimli Fiyat: {1}TL Bu alışverişten kazancınız: {2}TL", toplam, (toplam * 0.9), (toplam * 0.1));
            }
            else if (toplam >= 50 && toplam < 100)
            {
                Console.WriteLine("Toplam Fiyat: {0}TL İndirimli Fiyat: {1}TL Bu alışverişten kazancınız: {2}TL", toplam, (toplam * 0.85), (toplam * 0.15));
            }
            else if (toplam >= 100)
            {
                Console.WriteLine("Toplam Fiyat: {0}TL İndirimli Fiyat: {1}TL Bu alışverişten kazancınız: {2}TL", toplam, (toplam * 0.80), (toplam * 0.2));
            }
            Console.ReadLine();
        }
    }
}
