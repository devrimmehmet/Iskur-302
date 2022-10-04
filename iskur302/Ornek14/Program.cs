using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek14
{
    internal class Program
    {
        void randomDizi()
        {
            Random random = new Random();
            int[] a = new int[20];
            double toplam = 0;
            double aritmetikort = 0;
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(0, 100);
                toplam = toplam + a[i];

            }
            aritmetikort = toplam / a.Length;
            int sayac = 0;
            int sayac2 = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > aritmetikort)
                {
                   // Console.WriteLine($"  - {a[i]} sayısı  ortalamadan büyüktür.");
                    sayac++;
                }
                else if (a[i] < aritmetikort)
                {
                  //  Console.WriteLine($"  - {a[i]} sayısı  ortalamadan küçüktür.");
                    sayac2++;
                }


            }
            Console.WriteLine($"Toplam: {toplam}   Aritmetik Ortalama: {aritmetikort}");

            Console.WriteLine($"Toplam 20 sayının {sayac} tanesi ortalamadan büyüktür. {sayac2} tanesi ortalamadan küçüktür.");
        }
        static void Main(string[] args)
        {
            // Elemanları tamsayı olan 1 a  dizisinin (20 elemanlı) rastgele sayıları atayan sonra dizi elemanlarının aritmetik ortalamasını hesaplayan ve elemanlardan kaç tanesinin ? bu ortlamadan büyük ve küçük olduğunu sayan programın kodunu yazın.
            Program program = new Program();
            program.randomDizi();
            Console.ReadLine();
        }
    }
}
