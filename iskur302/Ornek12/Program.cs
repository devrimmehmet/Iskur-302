using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ornek12
{
    internal class Program
    {
        public void dizi1Tanimla()
        {
            int dizi1satir = 0;
            int dizi1sutun = 0;
            bool state = true;
            while (state)
            {
                try
                {
                    Console.WriteLine("Lütfen 1.dizinin Satır Sayısını giriniz.");
                    dizi1satir = Convert.ToInt32(Console.ReadLine());
                    state = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Lütfen int türünde sayı giriniz.");
                }
            }
            state = true;
            while (state)
            {
                try
                {
                    Console.WriteLine("Lütfen 1.dizinin Sütun Sayısını giriniz.");
                    dizi1sutun = Convert.ToInt32(Console.ReadLine());


                    state = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Lütfen int türünde sayı giriniz.");
                }
            }
            int[,] dizi = new int[dizi1satir, dizi1sutun];
            state = true;
            for (int i = 0; i < dizi1satir; i++)
            {
                for (int k = 0; k < dizi1sutun; k++)
                {
                    try
                    {
                        Console.WriteLine("Lütfen 1.dizinin {0}x{1} Elemanını giriniz.", (i + 1), (k + 1));
                        dizi[i, k] = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Lütfen int türünde sayı giriniz.");
                        k--;
                    }
                }
            }
            int[,] dizi2 = new int[dizi1satir, dizi1sutun];
            int[,] dizi3 = new int[dizi1satir, dizi1sutun];
            for (int i = 0; i < dizi1satir; i++)
            {
                for (int k = 0; k < dizi1sutun; k++)
                {


                    try
                    {
                        Console.WriteLine("Lütfen 2.dizinin {0}x{1} Elemanını giriniz.", (i + 1), (k + 1));
                        dizi2[i, k] = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("Lütfen int türünde sayı giriniz.");
                        k--;
                    }
                }
            }
            for (int i = 0; i < dizi1satir; i++)
            {
                for (int k = 0; k < dizi1sutun; k++)
                {
                    dizi3[i, k] = dizi[i, k] + dizi2[i, k];
                }
            }
            Console.WriteLine();
            Console.WriteLine("1.Dizi Yazdırılıyor...");
            Console.WriteLine();
            for (int i = 0; i < dizi1satir; i++)
            {// edit by Devrim Mehmet
                for (int k = 0; k < dizi1sutun; k++)
                {
                    Console.Write(dizi[i, k] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("2.Dizi Yazdırılıyor...");
            Console.WriteLine();
            for (int i = 0; i < dizi1satir; i++)
            {
                for (int k = 0; k < dizi1sutun; k++)
                {
                    Console.Write(dizi2[i, k] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1.Dizi ve 2.Dizinin Toplamı olan 3.Dizi Yazdırılıyor...");
            Console.WriteLine();
            for (int i = 0; i < dizi1satir; i++)
            {
                for (int k = 0; k < dizi1sutun; k++)
                {
                    Console.Write(dizi3[i, k] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.dizi1Tanimla();
            Console.ReadLine();
        }
    }
}

