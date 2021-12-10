using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        public GenericRepository()
        {
            using (Context context = new Context())
            {
                context.Set<T>().ToList();
            }
        }

        public void Add(T entity)
        {
            using (Context context = new Context())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (Context context = new Context())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            using (Context context = new Context())
            {
                return context.Set<T>().SingleOrDefault(filter);
            }
        }

        public List<T> List(Expression<Func<T, bool>> filter = null)
        {
            using (Context context = new Context())
            {
                return filter == null ? context.Set<T>().ToList()
                : context.Set<T>().Where(filter).ToList();
            }
             
        }

        public void Update(T entity)
        {
            using (Context context = new Context())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
