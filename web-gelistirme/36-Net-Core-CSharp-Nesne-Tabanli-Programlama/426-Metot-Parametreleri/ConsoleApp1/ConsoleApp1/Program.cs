using System;

namespace ConsoleApp1
{
    class Islem
    {
        public int X { get; set; }
        public int Y { get; set; }
        //public int Toplama(int X,int Y)
        //{
        //    return X+Y;
        //}
        public int Toplama(params int[] sayilar)
        {
            int sonuc = 0;
            foreach (var sayi in sayilar)
            {
                sonuc += sayi;
            }
            return sonuc;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var islem = new Islem();
        //    islem.X = 10;
        //    islem.Y = 20;
            
            Console.WriteLine(islem.Toplama(10,15));
            Console.WriteLine(islem.Toplama(10, 15,12));
            Console.WriteLine(islem.Toplama(10, 15,16,17));
        }
    }
}
