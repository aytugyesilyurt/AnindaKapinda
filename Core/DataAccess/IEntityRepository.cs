using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> 
        where T : class, IEntity, new()
    {
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        T GetById(Expression<Func<T, bool>> filter);
        ICollection<T> GetAll(Expression<Func<T, bool>> filter = null);
    }
}
