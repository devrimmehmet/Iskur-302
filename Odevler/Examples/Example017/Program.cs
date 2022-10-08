using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1;
            Console.Write("Sayıyı Giriniz: ");
            number1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Dönüştürdüğünüz değer: " + number1);
            Console.ReadLine();

        }
    }
}
