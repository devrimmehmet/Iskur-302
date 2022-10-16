using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek11
{
    internal class Program
    {
        void SelamunAleykum()
        {
            int[] a = { 1, 2, 3, 4, 5 ,6};
            int[] b = new int[a.Length];
            int[] c = new int[a.Length];
            Console.WriteLine("A dizisi ");
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[i] * a[i];
                c[i] = a[i] * b[i];
                Console.Write(a[i] +" ");
            }
            Console.WriteLine();
            
            Console.WriteLine();
            Console.WriteLine("B dizisi ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("["+b[i]+"]"+ " ");
            }
            Console.WriteLine();
            Console.WriteLine("C dizisi ");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("[" + c[i] + "]" + " ");
            }
            Program selamlasma = new Program();
            selamlasma.AleykumSelam();
        }
        void AleykumSelam()
        {
            Console.WriteLine();
            Console.WriteLine("Tebrikler...");
        }
        static void Main(string[] args)
        {
            
            Program selamlasma = new Program();
            selamlasma.SelamunAleykum();

            
            Console.ReadLine();
        }
    }
}
