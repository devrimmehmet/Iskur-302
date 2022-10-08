using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example027
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte number1, number2, total;
            Console.Write("Sayı1: ");
            number1 = Convert.ToSByte(Console.ReadLine());
            Console.Write("Sayı2: ");
            number2 = Convert.ToSByte(Console.ReadLine());
            total = Convert.ToSByte(number1 + number2);
            Console.Write("Toplam: "+total);
            Console.ReadLine();

        }
    }
}
