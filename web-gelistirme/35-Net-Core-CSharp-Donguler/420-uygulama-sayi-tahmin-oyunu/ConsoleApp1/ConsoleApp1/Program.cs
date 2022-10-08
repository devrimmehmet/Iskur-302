using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // sayı tahmin
            // 1-100 arasında rastgele tutulan bir sayıyı buldurmaya çalışın
            // puanlama yapınız.

            var sayi = new Random();
            int sayimiz=sayi.Next(1,100);
            int tahmin=100;
            int puan = 100;
            while(sayimiz!=tahmin)
            {
            Console.WriteLine("Lütfen bir sayı giriniz");
             tahmin = int.Parse(Console.ReadLine());

                if (tahmin<sayimiz)
                {
                    Console.WriteLine("yukarı");
                    puan--;
                }else if (tahmin > sayimiz)
                {
                    Console.WriteLine("aşağı");
                    puan--;
                }
            }

            Console.WriteLine("Tebrikler doğru tahmin puanınız: {0}",puan);

        }
    }
}
