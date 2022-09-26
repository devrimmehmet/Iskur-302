using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Döngüler: break - continue

            //string name = "Devrim Mehmet Pattabanoğlu";
            //for (int i = 0; i < name.Length; i++)
            //{
            //    if (name[i]=='h')
            //    {
            //        break;//döngüyü bitirir.
            //        //continue; döngü o turdan çıkar ve tekrara devam eder.
            //    }
            //    Console.WriteLine(name[i]);
            //}
            //Console.WriteLine("döngüden çıkış");
            //int x = 0;

            //while (x<5)
            //{
            //    x++;
            //    if (x==2)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(x);
            //}

            //100e kadarki tek sayıların toplamı
            int x = 1;
            int toplam = 0;
            while (x<100)
            {
                x++;
                if (x % 2 == 0)
                    continue;
                toplam += x;
            }
            Console.WriteLine("toplam: "+toplam);

        }
    }
}
