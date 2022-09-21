using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, total, extraction, multiplication, division; //toplam çıkarma çarpma bölme
            Console.Write("Sayı 1: ");
            number1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Sayı 2: ");
            number2 = Convert.ToInt16(Console.ReadLine());
            total = number1 + number2;
            extraction = number1 - number2;
            multiplication = number1 * number2;
            division = number1 / number2;
            Console.WriteLine("Toplam: " + total);
            Console.WriteLine("Fark: " + extraction);
            Console.WriteLine("Çarpım: " + multiplication);
            Console.WriteLine("Bölüm: " + division);
            Console.ReadLine();
        }
    }
}
