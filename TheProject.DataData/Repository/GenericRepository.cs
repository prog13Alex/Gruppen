using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace TheProject.DataData.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        protected DbSet<T> _objectsSet;

        public GenericRepository(TheProjectDBContext context)
        {
            _objectsSet = context.Set<T>();
        }

        public virtual IQueryable<T> FindAll()
        {
            return _objectsSet;
        }

        public virtual IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _objectsSet.Where(predicate);
        }

        public virtual void Add(T entity)
        {
            _objectsSet.Add(entity);
        }

        public virtual void Remove(T entity)
        {
            _objectsSet.Remove(entity);
        }

        public virtual void RemoveRange(IEnumerable<T> entities)
        {
            _objectsSet.RemoveRange(entities);
        }
    }
}
