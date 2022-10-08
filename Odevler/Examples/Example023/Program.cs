using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte number1, number2, total;
            number1 = 24;
            number2 = 36;
            total = Convert.ToByte(number1 + number2);
            Console.Write(total);
            Console.ReadLine();

        }
    }
}
