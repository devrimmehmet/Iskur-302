using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1, number2, total;
            Console.Write("Sayı 1'i Giriniz: ");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sayı 2'yi Giriniz: ");
            number2 = Convert.ToDouble(Console.ReadLine());
            total = number1 + number2;
            Console.Write("Sonuç: " + total);
            Console.ReadLine();
        }
    }
}
