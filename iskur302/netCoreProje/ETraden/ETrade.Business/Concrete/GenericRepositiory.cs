using ETrade.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETrade.Data.Models.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ETrade.Business.Concrete
{
    public class GenericRepositiory<Tentity, Tcontext> : IGenericRepository<Tentity>
        where Tentity : class, new()
        where Tcontext : DbContext, new()
    {


        public void Add(Tentity entity)
        {
            using (var db = new Tcontext())
            {
                db.Set<Tentity>().Add(entity);
                db.SaveChanges();
                
            }
        }

        public void Delete(int id)
        {
            using (var db = new Tcontext())
            {
                var tentity = db.Set<Tentity>().Find(id);
                db.Set<Tentity>().Remove(tentity);  
                db.SaveChanges();

            }
        }

        public void Delete(Tentity entity)
        {
            using (var db = new Tcontext())
            {
               
               db.Entry(entity).State= EntityState.Detached;
                db.SaveChanges();
            }
        }

        public Tentity Get(int id)
        {
            using (var db = new Tcontext())
            {
                var entity = db.Set<Tentity>().Find(id);
                return entity;

            }
        }

        public Tentity Get(Expression<Func<Tentity, bool>> filter)
        {
            using (var db = new Tcontext())
            {
                var entity = db.Set<Tentity>().Find(filter);
                return entity;
            }
        }

        public List<Tentity> GetAll(Expression<Func<Tentity, bool>> filter = null)
        {
            using (var db = new Tcontext())
            {
                return filter == null ? db.Set<Tentity>().ToList():db.Set<Tentity>().Where(filter).ToList();    
            }
        }

        public void Update(Tentity entity)
        {
            using (var db = new Tcontext())
            {
               db.Entry(entity).State= EntityState.Modified; db.SaveChanges();
            }
        }
    }
}

