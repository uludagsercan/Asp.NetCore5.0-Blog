using DataAccessLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class BlogRepository<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context= new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using(TContext context = new TContext())
            {
                var removedEntity = context.Entry(entity);
                removedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(predicate);
            }
        }

        public ICollection<TEntity> GetAll()
        {
            using (var context = new TContext())
            {
                return  context.Set<TEntity>().ToList();
            }
        }

        public ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().Where(predicate).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
