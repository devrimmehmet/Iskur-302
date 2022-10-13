using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaKredi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kredi kredi = new Kredi();
            kredi.Menu();
            Console.ReadLine();
        }
    }
}
