using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek39
{
    internal class Program
    {
        public void CarpimTablosu(int a, int b)
        {
            int sonuctek = 0;
            int sonuccift = 0;
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j <= b; j++)
                {
                    if (i * j < 10)
                    {
                        Console.Write($"{j} x {i} =  {i * j}      ");
                    }
                    else
                    {

                        Console.Write($"{j} x {i} = {i * j}      ");
                    }
                    if ((i*j)%2==0)
                    {
                        sonuccift += i * j;
                    }
                    else if ((i * j) % 2 == 1)
                    {
                        sonuctek += i * j;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Tek Sonuçların Toplamı: {0}",sonuctek);
            Console.WriteLine("Çift Sonuçların Toplamı: {0}", sonuccift);
        }
    
    //void SayiAl()
    //    {
    //        //bool durum = true;
    //        //while (durum)
    //        //{
    //        //    try
    //        //    {
    //        //        Console.WriteLine("Lütfen Sayı Giriniz");
    //        //        int a = Convert.ToInt32(Console.ReadLine());
    //        //        Console.WriteLine("Lütfen Sayı Giriniz");
    //        //        int b = Convert.ToInt32(Console.ReadLine());
    //        //        durum = false;
    //        //        Program program = new Program();
    //        //        program.CarpimTablosu(a, b);
    //        //    }
    //        //    catch (Exception)
    //        //    {

    //        //        Console.WriteLine("(İNT) Lütfen Sayı Girin (İNT)");
    //        //    }
    //        //}

    //    }

    static void Main(string[] args)
    {
        Program program = new Program();
        program.CarpimTablosu(9, 9);
        Console.ReadLine();
    }
}
}

