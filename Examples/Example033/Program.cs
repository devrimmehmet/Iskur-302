using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example033
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ushort shortEdge, longEdge, area, perimeter;
            Console.Write("Kısa Kenarı Giriniz: ");
            shortEdge = ushort.Parse(Console.ReadLine());
            Console.Write("Uzun Kenarı Giriniz: ");
            longEdge = ushort.Parse(Console.ReadLine());
            area = (ushort)(shortEdge * longEdge);
            perimeter = (ushort)((shortEdge*2)+(longEdge*2));
            Console.Write("Alan: " + area + " " + "Çevre: " + perimeter);
            Console.ReadLine();

        }
    }
}
