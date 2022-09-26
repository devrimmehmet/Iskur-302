using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int k = n-1; k > i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                for (int u = 0; u < i; u++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            int yen = 0;
            for (int i = 0; i < n; i++)
            {
                yen = yen + 2;
            }
            for (int i = 0; i < yen/3; i++)
            {
                for (int j = 0; j < yen / 3; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < yen / 3; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
