using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example030
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short number1, number2, total;
            number1 = 326;
            number2 = 366;
            total = (short)(number2 + number1);
            Console.Write(total);
            Console.ReadLine();
        }
    }
}
