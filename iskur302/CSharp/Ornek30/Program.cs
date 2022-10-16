using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Ornek30
{
    internal class Program
    {
        void sayial()
        {
            int sayi = 0;
            bool durum = true;
            while (durum)
            {
                try
                {
                basadon:
                    Console.WriteLine("Lütfen bir sayı giriniz.");
                    sayi = int.Parse(Console.ReadLine());
                    if (sayi >= 1000 & sayi < 10000)
                    {

                        durum = false;
                    }
                    else
                    {
                        Console.WriteLine("4 basamaklı pozitif bir sayı giriniz.");
                        goto basadon;
                    }


                }
                catch (Exception)
                {

                    Console.WriteLine("Lütfen Sayı Giriniz.");
                }
                sayiOku(sayi);

            }
        }
        void sayiOku(int sayi)
        {
            string sonuc;

            int birlerbas = (sayi % 10);
            int onlarbas = (sayi / 10) % 10;
            int yuzlerbas = (sayi / 100) % 10;
            int binlerbas = (sayi / 1000) % 10;
            string[] birlerb = { "", "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
            string[] Onlarb = { "", "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };
            string[] Yuzlerb = { "", "Yüz", "İki Yüz", "Üç Yüz", "Dört Yüz", "Beş Yüz", "Altı Yüz", "Yedi Yüz", "Sekiz Yüz", "Dokuz Yüz" };
            string[] binlerb = { "", "Bin", "İki Bin", "Üç Bin", "Dört Bin", "Beş Bin", "Altı Bin", "Yedi Bin", "Sekiz Bin", "Dokuz Bin" };

            sonuc = binlerb[binlerbas] + " " + Yuzlerb[yuzlerbas] + " " + Onlarb[onlarbas] + " " +
           birlerb[birlerbas];

            Console.WriteLine(sonuc);
        }

        static void Main(string[] args)
        {
            /*Klavyeden girilen 4 basamaklı bir sayıyı ekrana yazdıran 
             * SayiOku(int sayi) adında metot yazınız.
             * 
                Örnek: SayiOku(9853); > dokuz bin sekiz yüz elli üç*/

            Program program = new Program();
            program.sayial();
            Console.ReadLine();

        }
    }
}
