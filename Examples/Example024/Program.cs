using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte number1, number2, multiplication;
            Console.Write("1.Sayı: ");
            number1 = Convert.ToByte(Console.ReadLine());
            Console.Write("2.Sayı: ");
            number2 = Convert.ToByte(Console.ReadLine());
            multiplication = Convert.ToByte(number1 * number2);
            Console.Write(multiplication);
            Console.Read();
        }
    }
}
