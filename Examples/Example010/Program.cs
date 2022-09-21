using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1, number2, average;
            number1 = 78.3;
            number2 = 85.5;
            average = (number1 + number2) / 2;
            Console.WriteLine("Ortalama: "+ average);
            Console.ReadLine();
        }
    }
}
