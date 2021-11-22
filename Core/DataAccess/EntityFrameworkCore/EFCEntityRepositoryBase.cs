using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Core.DataAccess.EntityFrameworkCore
{
    public class EFCEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext
    {
        TContext _context;

        public EFCEntityRepositoryBase()
        {
            IServiceCollection services = new ServiceCollection();
            services.AddDbContext<TContext>(ServiceLifetime.Singleton);
            ServiceProvider provider = services.BuildServiceProvider();
            _context = provider.GetService<TContext>();
        }

        public bool Add(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Added;
            return _context.SaveChanges() > 0;
        }

        public bool Delete(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
            return _context.SaveChanges() > 0;
        }

        public ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null
                ? _context.Set<TEntity>().ToList()
                : _context.Set<TEntity>().Where(filter).ToList();
        }

        public TEntity GetById(Expression<Func<TEntity, bool>> filter)
        {
            return _context.Set<TEntity>().SingleOrDefault(filter);
        }

        public bool Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return _context.SaveChanges() > 0;
        }
    }
}
