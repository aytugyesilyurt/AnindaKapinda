using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business
{
    public interface IService<T>
    {
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        T GetById(int id);
        ICollection<T> GetAll();
    }
}
