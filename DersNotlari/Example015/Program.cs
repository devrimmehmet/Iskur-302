using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ---- Klavyeden kısa ve uzun kenarı girilen dikdörtgenin çevresi ve alanını hesaplama ---- */
            int shortEdge, longEdge, area, perimeter;
            Console.Write("Kısa kenar: ");
            shortEdge = Convert.ToInt16(Console.ReadLine());
            Console.Write("Uzun kenar: ");
            longEdge = Convert.ToInt16(Console.ReadLine());
            area = shortEdge * longEdge;
            perimeter = (shortEdge * 2) + (longEdge * 2);
            Console.WriteLine("Alan: " + area);
            Console.WriteLine("Çevre: " + perimeter);
            Console.ReadLine();
        }
    }
}
