using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev15
{
    public class Program
    {
       public string secim = "";
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Cafe cafe = new Cafe();
            cafe.AnaMenu();

        }
        
    }
}
