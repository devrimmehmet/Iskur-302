using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        class Product
        {
            public string Name { get; set; }
        }
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>();
            sayilar.Add(4);
            sayilar.Add(5);
            sayilar.Add(6);

            List<string> isimler = new List<string>();
            isimler.Add("Ali");
            isimler.Add("Veli");
            isimler.Add("Devrim");
            isimler.Add(null);

            List<Product> urunler = new List<Product>() 
            { 
                new Product() { Name = "Samsung" },
                new Product() { Name = "SamsungS7" },
                new Product() { Name = "SamsungS8" },
                new Product() { Name = "SamsungS9" }
            };
            List<Product> urunler2 = new List<Product>()
            {
                new Product() { Name = "Iphone" },
                new Product() { Name = "Iphone 5" },
                new Product() { Name = "Iphone 6" },
                new Product() { Name = "Iphone 7" }
            };
            urunler.AddRange(urunler2);
            foreach (var item in urunler)
            {
                Console.WriteLine(item.Name);
            }

            urunler.ForEach(p => Console.WriteLine( p.Name));

            Console.WriteLine(urunler.Count);
            Console.WriteLine(urunler[0].Name);
            for (int i = 0; i < urunler.Count; i++)
            {
                Console.WriteLine(urunler[i].Name);
            }

            sayilar.Insert(0,100);
            sayilar.ForEach(p => Console.WriteLine(p) );


        }
    }
}
