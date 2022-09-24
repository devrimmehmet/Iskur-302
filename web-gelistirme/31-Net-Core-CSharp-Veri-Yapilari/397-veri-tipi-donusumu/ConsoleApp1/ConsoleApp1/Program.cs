using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //implicit casting (Automatically): smaller type to larger
            //int - long
            int a = 10;
            long b =a;
            float e = 10.5f;
            double f = e;
            //explicit casting (manually): larger type to smaller
            //int - long
            long aa = 10;
            int bb = (int)aa;
            
            double g = 10.6;
            float h = (float)g;
            
            double k = 10.5;
            float l = (float)k;
            
            double kz = 10.5;
            int lz= (int)kz;

            int m = 23654;
            byte n = (byte)m;
            Console.WriteLine(n);

            Console.Write("1.Sayı: ") ;
            int sayi1 =int.Parse(Console.ReadLine());
            Console.Write("2.Sayı: ");
            int sayi2 =int.Parse(Console.ReadLine());
            int toplam = sayi1 + sayi2;
            Console.WriteLine($"girilen toplam değer: {toplam}");

        }
    }
}
