using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region devrim_mehmet_pattabanoglu-odev4
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i =1; i < 6; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                if (i==5) {
                    for (int k = 0; k < 24; k++)
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 1; i < 6; i++)
            {
                for (int k = 5; k > i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
               
            }
            Console.ReadLine();
            #endregion
        }
    }
}
