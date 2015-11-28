using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Data.Entity;


namespace DataAccessLayer.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext aContext;
        
        public GenericRepository(DbContext pContext)
        {
            aContext= pContext;
        }
        
        TEntity Get (int id)
        {
            return aContext.Set<TEntity>().Find(id);
        }
        IEnumerable<TEntity> GetAll()
        {
            return aContext.Set<TEntity>().ToList();
        }
          public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return aContext.Set<TEntity>().Where(predicate);
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return aContext.Set<TEntity>().SingleOrDefault(predicate);
        }

        public void Add(TEntity entity)
        {
            aContext.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            aContext.Set<TEntity>().AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
            aContext.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            aContext.Set<TEntity>().RemoveRange(entities);
        }
    }
}
