using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek4
{
    public class Deneme
    {
        public void CAGRI()
        {
            Console.WriteLine("metot");
            Program program = new Program();
            program.metot1 ();
        }
    }
    public class Program
    {
        public void metot1()
        {
            Console.WriteLine("metot");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
          //  System.ConsoleKeyInfo gelentus  = Console.ReadKey(true);
            ConsoleKeyInfo gelentus = default(ConsoleKeyInfo);
            if (gelentus.Key==ConsoleKey.Z)
            {
                Console.WriteLine(gelentus.Key + " basıldı");
                program.metot1();
            }
            else
            {
                Console.WriteLine("Yanlış tuşa basıldı");
            }
            Console.ReadLine();
        }
    }
}
