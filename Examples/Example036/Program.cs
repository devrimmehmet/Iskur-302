using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example036
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal edge, area, perimeter;
            Console.Write("Kenarı Giriniz: ");
            edge = Convert.ToDecimal(Console.ReadLine());
            area = edge * edge;
            perimeter = edge * 4;
            Console.Write("Alan: " + area + " " + "Çevre: " + perimeter);
            Console.ReadLine();

        }
    }
}
