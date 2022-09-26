using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 555554444333221 çıktısını veren for döngüsü
            for (int i = 5; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
            }
            Console.ReadLine();
        }
    }
}
