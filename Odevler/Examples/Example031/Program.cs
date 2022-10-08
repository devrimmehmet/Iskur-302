using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example031
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short number1, number2, total;
            Console.Write("A: ");
            number1 = short.Parse(Console.ReadLine());
            Console.Write("B: ");
            number2 = short.Parse(Console.ReadLine());
            total = (short)(number1 + number2);
            Console.Write(total);
            Console.ReadLine();

        }
    }
}
