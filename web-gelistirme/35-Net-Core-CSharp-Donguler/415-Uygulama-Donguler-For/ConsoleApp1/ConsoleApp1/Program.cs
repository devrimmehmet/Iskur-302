using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region   Kullanıcıdan başlangıç, bitiş ve artış miktarı alınarak aralıktaki tüm sayıları ekrana yazdırınız.

            //Console.WriteLine("Başlangıç değerini giriniz: ");
            //int baslangic = int.Parse(Console.ReadLine());
            //Console.WriteLine("Bitiş değerini giriniz: ");
            //int bitis = int.Parse(Console.ReadLine());
            //Console.WriteLine("Artış miktarını giriniz: ");
            //int artis = int.Parse(Console.ReadLine());
            //for (int i = baslangic; i < bitis; i+=artis)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region dizideki 3ün katı olan sayılar
            // int[] sayilar = { 1, 3, 5, 6, 7, 23, 67, 90,120 };
            // for (int i = 0; i < sayilar.Length; i++)
            // {
            //     if (sayilar[i] % 3 == 0)
            //     {
            //         Console.WriteLine(sayilar[i]);
            //     }
            // }
            // //sayıların toplamı
            //int toplam = 0;
            // for (int i = 0; i < sayilar.Length; i++)
            // {
            //     toplam += sayilar[i];

            // }
            // Console.WriteLine("dizideki sayıların toplamı "+toplam);
            #endregion
            #region arabalar diziindeki en az 5 karakterli araç isimlerini yazdırınız.
            string[] arabalar = { "opel", "mazda", "toyota", "bmw", "mercedes" };
            for (int i = 0; i < arabalar.Length; i++)
            {
               if(arabalar[i].Length >= 5)
                {
                    Console.WriteLine(arabalar[i]);
                }
            }
            #endregion

        }
    }
}
