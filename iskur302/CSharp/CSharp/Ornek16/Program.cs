using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string girilen = Console.ReadLine();
            for (int i = girilen.Length-1; i >= 0; i--)
            {
                Console.Write(girilen[i]);
            }
          
            Console.ReadLine();
        }
    }
}
