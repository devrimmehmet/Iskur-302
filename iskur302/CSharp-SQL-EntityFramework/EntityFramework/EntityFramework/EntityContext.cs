using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace EntityFramework
{
    public class EntityContext:DbContext
    {
        public EntityContext() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EntityDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
