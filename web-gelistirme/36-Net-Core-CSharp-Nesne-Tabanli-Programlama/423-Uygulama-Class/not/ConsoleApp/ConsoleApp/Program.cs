using System;
using System.Globalization;

namespace ConsoleApp
{

    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }   

    class Program
    {
        static void Main(string[] args)
        {
           // Product class => name, price, description
           // Sınırsız sayıda ürün bilgisini alıp bir dizi içinde saklayınız.
           // Ürün adetini kullanıcı belirtsin.
           // Eklenen ürünler listelensin.

            Console.Write("adet: ");
            int adet = int.Parse(Console.ReadLine());

            Product[] products = new Product[adet];

            int i=0;
            Product prd;

            do
            {
                prd = new Product();

                Console.Write("ürün adı: ");
                prd.Name = Console.ReadLine();

                Console.Write("ürün fiyat: ");
                prd.Price = double.Parse(Console.ReadLine());

                Console.Write("açıklama: ");
                prd.Description = Console.ReadLine();

                products[i] = prd;
                i++;

            } while (adet>i);

            Console.WriteLine("*******************");

            // for (int a = 0; a < products.Length; a++)
            // {
            //     Console.WriteLine($"ürün adı: {products[a].Name} ürün fiyat: {products[a].Price} açıklama: {products[a].Description}");
            // }

            foreach (var urun in products)
            {
                 Console.WriteLine($"ürün adı: {urun.Name} ürün fiyat: {urun.Price} açıklama: {urun.Description}");
            }

        }
    }
}
