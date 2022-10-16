using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VucutKitleIndexi
{
    internal class Program
    {
        private double Hesaplama()
        {
            return 15;
        }
        static void Main(string[] args)
        {
            double boy, kilo, durum;
            string cinsiyet;
            while (true)
            {
                Console.WriteLine("Lütfen cinsiyetinizi giriniz");
                cinsiyet = Console.ReadLine();
                Console.WriteLine("Lütfen kilonuzu giriniz");
                kilo = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Lütfen boyunuzu giriniz");
                boy = Convert.ToDouble(Console.ReadLine());
                durum = (kilo / (boy * boy)) * 10000;

                if (durum < 18.5)
                {
                    Console.WriteLine("Vucüt kitle indexiniz : {0} , Zayıfsınız", durum);
                }
                else if (durum >= 18.5 && durum < 24.9)
                {
                    Console.WriteLine("Vucüt kitle indexiniz : {0} , Normalsiniz", durum);
                }
                else if (durum >= 24.9 && durum < 29.9)
                {
                    Console.WriteLine("Vucüt kitle indexiniz : {0} , Aşırı Kilolusunuz", durum);
                }
                else
                {
                    Console.WriteLine("Vucüt kitle indexiniz : {0} , Obezsiniz", durum);
                }
                Console.WriteLine();
                Console.WriteLine();
            }


            // erkekler için
            // 18,5'ten küçükse zayıf'
            //18,5 ve 24,9 normal
            //24,9 ve 29,9 aşırı kilolu
            // 29,9 obez
        }
    }
}
