using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // uygulama: asal sayı
            // girilen bir sayının asal olup olmadığını konrol ediniz.
            // Bir sayı, sadece 1'e ve kendisine tam bölünebiliyorsa asal sayıdır.

            Console.WriteLine("Lütfen bir sayı giriniz: ");
            bool isPrime = true;
            int number = int.Parse(Console.ReadLine());
            if (number == 1)
            {
                isPrime = false;
            }

            if (number == 2)
            {
                isPrime = true;
            }
            for (int i = 2; i < number; i++)
            {
               if(number % i == 0)
                {
                    isPrime = false;
                    break;
                }
                
            }
            if (isPrime)
            {
                
                Console.WriteLine("Sayı asaldır.");
            }
            else
            {
                Console.WriteLine("Sayı asal değil");
            }
            

        }
    }
}
