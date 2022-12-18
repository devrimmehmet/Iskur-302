using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriTipi
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            #region veritipleri
            //veri tipleri
            int number = 12;
            //Console.Beep();
            Console.WriteLine("Sayımız : " + number);

            char letter = 'A'; //Karakter

            decimal number2 = 2;
            double number4 = 5.2;
            decimal number3 = 4.3m;
            float number6 = 5.3f;

            int deneme = 3;
            var deneme2 = 3;
            Console.WriteLine("deneme2" + (deneme));
            bool deneme333 = true;
            Console.WriteLine("deneme");
            //h Console.ReadLine(); //yazabilirsiniz
            Console.ReadKey(); // bir tuşa basar basmaz kapanır
            #endregion
            */

            // Klavyeden girilen iki sayının toplamını veren program.
            /* #region x+y
             int sayi1, sayi2,toplam;
             Console.Write("1.Sayıyı giriniz:");
             sayi1 = Convert.ToInt32(Console.ReadLine());
             Console.Write("2.Sayıyı giriniz:");
             sayi2 = Convert.ToInt32(Console.ReadLine());

             toplam = sayi1 + sayi2;
             Console.WriteLine("Sayılarımızın toplamı:"+toplam);
             #endregion
            */
            /*
            #region x+y
            // float convertte çalışmıyor parsede çalışıyor.
            float sayi1, sayi2, toplam;
            Console.Write("1.Sayıyı giriniz:");
            sayi1 = float.Parse(Console.ReadLine());
            Console.Write("2.Sayıyı giriniz:");
            sayi2 = float.Parse(Console.ReadLine());
            
            toplam = sayi1 + sayi2;
            Console.WriteLine("Sayılarımızın toplamı:" + toplam);
            #endregion*/
            /*
            #region char 
            // float convertte çalışmıyor parsede çalışıyor.
            char karakter,karakter2,karakter3;
            Console.Write("1 karakter giriniz:");
            karakter = Convert.ToChar(Console.ReadLine());
            Console.Write("1 karakter giriniz:");
            karakter2 = Convert.ToChar(Console.ReadLine()); 
            Console.WriteLine(karakter+karakter2);
            #endregion*/
            /*
            float number1=3.5f;
            float number2 = 3.7f;
            float total = number1 + number2;
            Console.WriteLine(total);
            Console.ReadLine();*/

            #region operatörler
            int sayi = 5;
            int sayi2 = 10;
            int toplam = 0;
          //  sayi = sayi + 1;
         //   Console.WriteLine(sayi);
            if (sayi > 9 || sayi==5)
            {
                Console.WriteLine("yanlış");
            }
            else {
                toplam = sayi + sayi2;
                Console.WriteLine(toplam);
            }
            
            Console.ReadLine();
            #endregion

        }
    }
}
