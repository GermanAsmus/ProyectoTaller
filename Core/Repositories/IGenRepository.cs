using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.Repositories
{
    /// <summary>
    /// Generic repository interface
    /// </summary>
    public interface IGenericRepository<TEntity> where TEntity : class
    {
         /// <summary>
        /// Gets an object from database by an specified id
        /// </summary>
        TEntity Get (int id);
        
         /// <summary>
        /// Gets all objects from database
        /// </summary>
        IEnumerable<TEntity> GetAll();
        
         /// <summary>
        /// Find an object by an specified expression.
        /// </summary>
        /// <param name="predicate"></param>
        IEnumerable<TEntity> Find(Expression<Func<TEntity,bool>> predicate);
        
        /// <summary>
        /// Obtains an object by an specified expression, if it doesn't exists retunrs default.
        /// </summary>
        /// <param name="predicate"></param>
        TEntity SingleOrDefault(Expression<Func<TEntity,bool>> predicate);
        
        /// <summary>
        /// Add an object to the database.
        /// </summary>
        /// <param name="entity">Specified a new object to add.</param>
        void Add(TEntity entity);
        
        /// <summary>
        /// Add objects to the database.
        /// </summary>
        /// <param name="entities"></param>
        void AddRange(IEnumerable<TEntity> entities);
        
        /// <summary>
        /// Removes an object on the database.
        /// </summary>
        /// <param name="entity">Specified an object to remove.</param>
        void Remove(TEntity entity);
        
                /// <summary>
        /// Removes objects on the database.
        /// </summary>
        /// <param name="entities"></param>
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}