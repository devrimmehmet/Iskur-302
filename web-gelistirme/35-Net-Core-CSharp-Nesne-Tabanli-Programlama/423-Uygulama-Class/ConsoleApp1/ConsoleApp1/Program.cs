using System;

namespace ConsoleApp1
{
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }

    }
     class Program
    {

        static void Main(string[] args)
        {
            // Product class => name,price,description
            // Sınırsız sayıda ürün bilgisini alıp bir dizi içinde saklayınız.
            // Ürün adetini kullanıcı belirtsin.
            // Eklenen ürünler listelensin.
           
            Console.WriteLine("Kaç adet ürün girmek istiyorsunuz?");
            int adet=int.Parse(Console.ReadLine());
            Product[] product = new Product[adet];
            Product prd;
            for (int i = 0; i < adet; i++)
            {
                Console.WriteLine("Ürün Adını Giriniz: ");
                prd = new Product();
                prd.Name =Console.ReadLine();
                Console.WriteLine("Ürün Fiyatını Giriniz: ");
                prd.Price =int.Parse( Console.ReadLine());
                Console.WriteLine("Ürün Durumunu Giriniz: ");
                prd.Description = Console.ReadLine();
                product[i] = prd;
            }

            foreach (var item in product)
            {
                Console.WriteLine($"Ürün adı: {item.Name} Ürün Fiyatı: {item.Price} Ürün Durumu :{item.Description}");
            }

        }
    }
}
