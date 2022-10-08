using ConsoleApp1.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.DataAccess.Abstract
{
    public interface IRepository<TEntity>
    {
        TEntity GetById(int id);

        void Update(TEntity entity);

        void Create(TEntity entity);

        void Delete(int id);
    }
}
