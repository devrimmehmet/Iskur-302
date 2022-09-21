using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, total;
            Console.Write("Sayı 1: ");
            number1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Sayı 2: ");
            number2 = Convert.ToInt16(Console.ReadLine());
            total = number2 + number1;
            Console.Write("Toplam: "+total);
            Console.ReadLine();
        }
    }
}
