using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace ETrade.Business.Abstract
{
    public interface IGenericRepository<Tentity>//listleme classları için bu işlemler
        where Tentity : class, new()
    {
        List<Tentity> GetAll(Expression<Func<Tentity, bool>> filter = null);
        Tentity Get(int id);
        Tentity Get(Expression<Func<Tentity, bool>> filter);
        void Add(Tentity entity);   
        void Update(Tentity entity);    
        void Delete(int id);
        void Delete(Tentity tentity);

    }
}
