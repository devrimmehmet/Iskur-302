using ETrade.Data.Models.Entites;
using ETrade.Data.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETrade.Data.Context 
{
    public class ETradeContext:IdentityDbContext<AppUser,AppRole,int>
    {
     protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=.;Initial Catalog=EtradeDb;integrated security=True;");
        }
        public DbSet<Category> Category { get; set; }   
        public DbSet<Product> Products { get; set; }   
        public DbSet<Order> Order { get; set; }   
        public DbSet<OrderLine> OrderLines { get; set; }   
    }
}
