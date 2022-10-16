using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Muhasebe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            // musteri.MusteriBilgileri();
            musteri.Getir();
            Console.ReadLine();
        }
    }
}
