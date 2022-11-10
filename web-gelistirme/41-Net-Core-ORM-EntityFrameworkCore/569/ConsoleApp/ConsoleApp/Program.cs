using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp
{
    internal class Program
    {
        public class ShopContext : DbContext
        {
            public DbSet<Product> Products { get; set; }
            public DbSet<Category> Categories { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlite("Data Source=shop.db");
            }
        }
        public class Product
        {
            public int ProductId { get; set; } // primary key (Id,<type_name>Id) yani ProductId dersem kabul eder ama UrunId dersem kabul etmez bir başka yöntemde üstüne [Key] yazmak lazım
            [MaxLength(100)] // varchar100 olur bu
            [Required] // zorunlu oluyor bu yöntemlere data annotation denir
            public string Name { get; set; }
            public decimal? Price { get; set; } // zorunlu bir değerdir ? eklersekte zorunlu demiş oluruz 
        }

        public class Category
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
