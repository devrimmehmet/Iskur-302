using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek10
{
    internal class Program
    {
        void klavyeSayi()
        {
          
            ERROR1:


            Console.WriteLine("1-Bir sayı giriniz.");
            int sayi = int.Parse(Console.ReadLine());
            if (sayi == 0)
            {
                Console.WriteLine("Sayınız 0'dır. Tekrar Sayı Giriniz");
                goto ERROR1;
            }
            else
            {
                Console.WriteLine("Sayınız 0 değildir. İkinci Sayınızı Girebiliriniz");
                
            }
            ERROR2:
            Console.WriteLine("2-Bir sayı giriniz.");
            int sayi2 = int.Parse(Console.ReadLine());
            if (sayi2 == 0)
            {
                Console.WriteLine("Sayınız 0'dır. Tekrar Sayı Giriniz");
                goto ERROR2;
            }
            else
            {
                Console.WriteLine("Sayınız 0 değildir. Girdiğiniz iki sayının Toplamı : {0} ",(sayi+sayi2));
                
            }
            Console.ReadLine();
            goto ERROR1;
        }
        private static int Sayi1Getir()
        {
            int girilen = -1;
            try
            {
                Console.WriteLine("1.Sayı Giriniz: ");
                girilen = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception Hata)
            {

                Console.WriteLine("Hatalı Giriş!");
            }
            return girilen;
        }

        private static int Sayi2Getir()
        {
            int girilen2 = -1;
            try
            {
                Console.WriteLine("2.Sayı Giriniz: ");
                girilen2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception Hata)
            {

                Console.WriteLine("Hatalı Giriş! Hata Kodunuz: {0}",Hata.Message);
            }
            return girilen2;
        }

        private static void KontrolEt(int sayi)
        {
            if (sayi==0)
            {
                Console.WriteLine("Sıfıdan farklı bir sayı giriniz:");
                sayi = Sayi1Getir();
                KontrolEt(sayi);
            }
            if (sayi == -1)
            {
                sayi = Sayi1Getir();
                KontrolEt(sayi);
            }
            else
            {
                Console.WriteLine("Girilen Sayi :" + sayi);
                int sayi2=Sayi2Getir();
                if (sayi2==0)
                {
                    Console.WriteLine("Sıfırdan farklı bir sayı giriniz :");
                    sayi2 = Sayi2Getir();
                    KontrolEt(sayi2);

                }
                if (sayi2 == -1)
                {
                    
                    sayi2 = Sayi2Getir();
                    KontrolEt(sayi2);

                }
                else
                {
                    Console.WriteLine("2.Sayi ="+sayi2);
                    int toplam = sayi + sayi2;
                    Console.WriteLine("Sonuç Değer="+toplam);
                    Console.ReadLine();
                }
            } 
        }
        static void Main(string[] args)
        {// klavyede girilen sayının 0dan farklı olup olmadığını kontrol ediniz. // Try - Catch bloğu kullan
         //  Program program = new Program();
         // program.klavyeSayi();
            int sayi = Sayi1Getir();
            KontrolEt(sayi);
           


        }
    }
}
