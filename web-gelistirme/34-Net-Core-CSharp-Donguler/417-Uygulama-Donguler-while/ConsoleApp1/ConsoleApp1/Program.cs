using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sınırsız sayıda ürün ismini bir dizi içinde saklayın
            //ürün adetini kullanıcı belirlesin
            //eklenen ürünler listelensin.

            //while, array
            //string[]=>5
            //class=>name,price,description

            Console.Write("adet : ");
            int adet  = int.Parse(Console.ReadLine());
            string[] urunler = new string[adet];
            int i = 0;
            do
            {
                Console.Write("ürün adı: ");
                urunler[i] = Console.ReadLine();
                i++;
            } while (i!=adet);

            Console.WriteLine("ürünler listeleniyor");
            for (int a = 0; a < urunler.Length; a++)
            {
                Console.WriteLine("ürün adı: {0}", urunler[a]);
            }
        }
    }
}
