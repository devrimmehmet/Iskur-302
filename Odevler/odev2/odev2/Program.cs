using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 111112222333445 çıktısını veren for döngüsü
            for (int i = 1; i < 6; i++)
            {
                for (int j = 6; j > i; j--)
                {
                    Console.Write(i);
                }
            }
            Console.ReadLine();
        }
    }
}
