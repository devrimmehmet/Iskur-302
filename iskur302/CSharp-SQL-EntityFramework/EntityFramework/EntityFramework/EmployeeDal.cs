using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class EmployeeDal
    {
        public List<Employee> GetAll()
        {
            using (EntityContext context = new EntityContext())
            {
                return context.Employees.ToList();
            }

        }
        public void Add(Employee employee)
        {
            using (EntityContext context = new EntityContext())
            {
                var employees = context.Entry(employee);
                employees.State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();
            }

        }
        //public void Update(Employee employee)
        //{
        //    using (EntityContext context = new EntityContext())
        //    {
        //        var products = context.Entry(employee);
        //        products.State = System.Data.Entity.EntityState.Modified;
        //        context.SaveChanges();

        //    }

        //}
        //public void Delete(Employee employee)
        //{
        //    using (EntityContext context = new EntityContext())
        //    {
        //        var products = context.Entry(employee);
        //        products.State = System.Data.Entity.EntityState.Deleted;
        //        context.SaveChanges();

        //    }

        //}
        //public List<Employee> Search(string text)
        //{

        //    using (EntityContext context = new EntityContext())
        //    {
        //        return context.Employees.Where(x => x.Name.ToLower().Contains(text.ToLower())).ToList();
        //    }
        //}
    }
}
