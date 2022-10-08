using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char selection;
            Console.Write("Lütfen seçiminizi yapınız: ");
            selection = Convert.ToChar(Console.ReadLine());
            Console.Write("Seçiminiz: " + selection);
            Console.ReadLine();
        }
    }
}
