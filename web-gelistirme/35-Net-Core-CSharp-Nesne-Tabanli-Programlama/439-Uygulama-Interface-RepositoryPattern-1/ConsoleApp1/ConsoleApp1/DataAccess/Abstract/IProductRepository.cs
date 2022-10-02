using ConsoleApp1.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DataAccess.Abstract
{
    public interface IProductRepository:IRepository<Product>
    {
        Product[] GetProductsByCategory(int id);
        Product[] GetPopularProducts();
    } 
}
