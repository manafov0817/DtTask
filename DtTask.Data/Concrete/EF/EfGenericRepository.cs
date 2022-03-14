using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;

namespace DtTask.Data.Concrete.EF
{
    public class EfGenericRepository<TEntity, TContext>
         where TEntity : class
         where TContext : DbContext, new()
    {
        public bool Create(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Add(entity);
                return context.SaveChanges() > 0 ? true : false;
            }
        }

        public bool Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Set<TEntity>().Remove(entity);
                return context.SaveChanges() == 1 ? true : false;
            }
        }

        public ICollection<TEntity> GetAll()
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().ToList();
            }
        }

        public TEntity GetById(int id)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().Find(id);
            }
        }

        public bool Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                return context.SaveChanges() > 1 ? true : false;
            }
        }
    }
}
