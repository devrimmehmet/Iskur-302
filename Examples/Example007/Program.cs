using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, multiplication, division, extraction,total; //çarpma bölme çıkarma toplama
            Console.WriteLine("***** Aritmetik İşlemler *****");
            Console.WriteLine();
            number1 = 18;
            number2 = 9;
            total = number2 + number1;
            extraction = number1 - number2;
            multiplication = number1 * number2;
            division = number1 / number2;
            Console.WriteLine("Toplam: " + total);
            Console.WriteLine("Fark: " + extraction);
            Console.WriteLine("Çarpım: " + multiplication);
            Console.WriteLine("Bölüm: " + division);
            Console.WriteLine();
            Console.WriteLine("***** Aritmetik İşlemler *****");
            Console.ReadLine();

        }
    }
}
