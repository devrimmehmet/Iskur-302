using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example035
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal number1, number2, extraction;
            number1 = 32;
            number2 = 25;
            extraction = number1 - number2;
            Console.Write("Sonuç: "+ extraction);
            Console.ReadLine();
        }
    }
}
