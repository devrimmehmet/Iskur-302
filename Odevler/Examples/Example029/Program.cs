using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example029
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float number1, number2, total;
            Console.Write("Sayı 1: ");
            number1 = float.Parse(Console.ReadLine());
            Console.Write("Sayı 2: ");
            number2 = float.Parse(Console.ReadLine());
            total = number1 + number2;
            Console.Write(total);
            Console.ReadLine();

        }
    }
}
