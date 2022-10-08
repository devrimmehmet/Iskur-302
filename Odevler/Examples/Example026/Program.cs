using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte number;
            Console.Write("Sayıyı Giriniz: ");
            number = Convert.ToSByte(Console.ReadLine());
            Console.Write(number);
            Console.ReadLine();
        }
    }
}
