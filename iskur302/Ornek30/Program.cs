using System;
using System.Collections.Generic;
using System.Linq;
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
            string binler = "bin";
            string yuzler = "yüz";
            string[] onlar = { "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
            string[] rakamlar = {"bir","iki","üç","dört","beş","altı","yedi","sekiz","dokuz" };
            string sonuc = " ";
            int kalan = 0;
            int binler1 = sayi / 1000;
            kalan = sayi % 1000;
            if (binler1 > 1)
            {
                sonuc = rakamlar[binler1 - 1] + " " + binler;
            }else
            {
                sonuc = binler;
            }
           // sonuc = rakamlar[binler1-1]+" "+ binler;
            sayi = kalan;
            int yuzler1 = sayi / 100;
            kalan = sayi % 100;
            if (yuzler1 > 0)
            {
                sonuc = sonuc +" "+ rakamlar[yuzler1 - 1] + " " + yuzler;
            }
            sayi = kalan;
            int onlar1 = sayi / 10;
            kalan = sayi % 10;
            if (onlar1 > 0)
            {
                sonuc = sonuc + " " + onlar[onlar1 - 1]  ;
            }else
            {
                sonuc = sonuc + " " +onlar;
            }
            sayi = kalan;
            int rakamlar1 = sayi % 10;
            
            if (rakamlar1 > 0)
            {
                sonuc = sonuc + " " + rakamlar[rakamlar1 - 1];
            }
            

            Console.WriteLine(sonuc);
        }

        static void Main(string[] args)
        {
            /*Klavyeden girilen 4 basamaklı bir sayıyı ekrana yazdıran 
             * SayiOku(int sayi) adında metot yazınız.
             * 
                Örnek: SayiOku(9853); > dokuz bin sekiz yüz elli üç*/

            Program program = new Program();
           program. sayial();
            Console.ReadLine();

        }
    }
}
