using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string province, district;
            Console.Write("Lütfen ili girin: ");
            province = Console.ReadLine();
            Console.Write("Lütfen ilçeyi girin: ");
            district = Console.ReadLine();
            Console.WriteLine("Girdiğiniz İl ve İlçe: " + province + "-" + district);
            Console.ReadLine();
        }
    }
}
