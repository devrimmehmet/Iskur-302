using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kısa kenar: ");
                int kisa = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Uzun kenar: ");
            int uzun = int.Parse(Console.ReadLine());
            int alan = kisa * uzun;
            int cevre = (kisa + uzun)*2;

            //Console.WriteLine("Alan: "+alan+" Çevre: "+cevre);
            Console.WriteLine($"Alan: {alan} Çevre: {cevre}");
        }
    }
}
