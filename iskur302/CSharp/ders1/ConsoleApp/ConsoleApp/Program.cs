using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 7; i=i+2)
            {
                for (int k = 5; k > i; k=k-2)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }         
                Console.WriteLine();
            }
            for (int i = 0; i < 7; i = i + 2)
            {
                for (int k = 0; k <= i; k = k+2)
                {
                    Console.Write(" ");
                }
                for (int j = 5; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
