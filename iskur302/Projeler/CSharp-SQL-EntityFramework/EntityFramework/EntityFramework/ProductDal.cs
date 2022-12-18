using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (EntityContext context = new EntityContext())
            {
                return context.Products.ToList();
            }

        }
        public void Add(Product product)
        {
            using (EntityContext context = new EntityContext())
            {
                var products = context.Entry(product);
                products.State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }

        }
        public void Update(Product product)
        {
            using (EntityContext context = new EntityContext())
            {
                var products = context.Entry(product);
                products.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();

            }

        }
        public void Delete(Product product)
        {
            using (EntityContext context = new EntityContext())
            {
                var products = context.Entry(product);
                products.State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();

            }

        }
        public List<Product> Search(string text)
        {

            using (EntityContext context = new EntityContext())
            {
                return context.Products.Where(x => x.Name.ToLower().Contains(text.ToLower())).ToList();
            }
        }
    }
}
