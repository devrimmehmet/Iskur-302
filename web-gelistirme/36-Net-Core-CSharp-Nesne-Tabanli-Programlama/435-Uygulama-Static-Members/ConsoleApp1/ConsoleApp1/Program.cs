using System;

namespace ConsoleApp1
{
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public bool IsApproved { get; set; }
    }
    static class ProductManager
    {
        static Product[] Products;
        static ProductManager()
        {
            Products = new Product[5];

            Products[0] = new Product { ProductId = 1, ProductName = "Iphone5", Price = 2000, IsApproved = false };
            Products[1] = new Product { ProductId = 2, ProductName = "Iphone6", Price = 3000, IsApproved = false };
            Products[2] = new Product { ProductId = 3,      ProductName = "Iphone7", Price = 4000,            IsApproved = false
            };
            Products[3] = new Product { ProductId = 4, ProductName = "IphoneX", Price = 5000, IsApproved = false };
            Products[4] = new Product { ProductId = 5, ProductName = "IphoneT", Price = 6000, IsApproved = false };
        }
        public static Product[] GetProducts()
        {
            return Products;
        }
        public static Product GetProductById(int id)
        {
            Product product = null;
            foreach (var p in Products)
            {
                if (p.ProductId==id)
                {
                    product = p;
                }
            }
            return product;
        }
        public static Product GetProductByName(string name)
        {
            Product product = null;
            foreach (var p in Products)
            {
                if (p.ProductName.Contains(name.ToLower()))
                    product = p;
                break;
            }
            return product;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //     var products = ProductManager.GetProducts();
            //var product = ProductManager.GetProductById(2);
            //Console.WriteLine($"name: {product.ProductName} price={product.Price}");
            //foreach (var p in products)
            //{
            //    Console.WriteLine($"name: {p.ProductName} price={p.Price}");
            //}

            var product = ProductManager.GetProductByName("Phone");
            Console.WriteLine($"name: {product.ProductName} price={product.Price}");
        }
    }
}
