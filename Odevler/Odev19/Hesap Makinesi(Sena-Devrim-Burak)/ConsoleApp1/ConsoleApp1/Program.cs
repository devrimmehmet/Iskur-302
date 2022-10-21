using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplamCift = 0;
            int toplamTek = 0;
            Console.WriteLine("sayı gir ");
            int sayi=Convert.ToInt32( Console.ReadLine());
            List<int> ciftler = new List<int>();
            List<int> tekler = new List<int>();
            for (int i = 1; i < sayi; i++)
            {
                if (i % 2 == 0)
                {
                  //  Console.WriteLine($"{i}   " + i*i);
                    toplamCift += (i * i);
                    ciftler.Add(i*i);
                }
                else
                {
                  //  Console.WriteLine($"{i}   "+i * i);
                    toplamTek += (i * i);
                    tekler.Add(i*i);
                }
            }

         //   Console.WriteLine(toplamTek+"tekler toplamı");
         //   Console.WriteLine(toplamCift+"çiftler toplamı");
           
            Console.WriteLine("Tek Sayılar");
          int  sayac = 1;
            foreach (var item in tekler)
            {
                Console.WriteLine(item);
                sayac++;

            }
            Console.WriteLine("Çift Sayılar");
             sayac = 1;
            foreach (var item in ciftler)
            {
                Console.WriteLine(item);
                sayac++;
            }
            Console.ReadLine();
        }
    }
}
