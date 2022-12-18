using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(" ");
                for (int j = 3-i; j >0 ; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < (2*i)+1; j++)
                {
                    Console.Write("*");
                }
            }
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine();
                for (int j =0; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 5-(i*2); j > 0; j--)
                {
                    Console.Write("*");
                }
            }
            Console.ReadLine();
        }
    }
}
