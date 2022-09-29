using System;

namespace ConsoleApp1
{
    class Ogrenci
    {
        public int OgrNo { get; set; }
        public string Ad { get; set; }
        public string Sube { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ogrno = { 100, 200, 300 };
            string[] ad = { "Çınar", "Ada", "Yiğit" };
            string[] sube = { "10A", "10B", "11A" };

            Console.WriteLine($"no: {ogrno[0]} ad: {ad[0]} sube: {sube[0]}");
            Console.WriteLine($"no: {ogrno[1]} ad: {ad[1]} sube: {sube[1]}");
            Console.WriteLine($"no: {ogrno[2]} ad: {ad[2]} sube: {sube[2]}");
        }
    }
}
