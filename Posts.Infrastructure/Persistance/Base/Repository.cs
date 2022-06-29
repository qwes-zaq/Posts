using Microsoft.EntityFrameworkCore;
using Posts.Application.Interfaces.Repositories.Base;
using Posts.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Posts.Infrastructure.Persistance.Base
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected readonly PostsDbContext _db;

        protected DbSet<T> _dbSet;

        public Repository(PostsDbContext db)
        {
            _db = db;
            _dbSet = db.Set<T>();
        }

        public virtual void Add(T entity) => _dbSet.Add(entity);
        public virtual void AddRange(IEnumerable<T> entities) => _dbSet.AddRange(entities);
        public virtual void Remove(T entity) => _dbSet.Remove(entity);
        public virtual void RemoveRange(IEnumerable<T> entities) => _dbSet.RemoveRange(entities);
        public virtual int Count(Expression<Func<T, bool>> predicate) => _dbSet.Count(predicate);
        public virtual IQueryable<T> Find(Expression<Func<T, bool>> predicate) => _dbSet.Where(predicate);
        public virtual T Get(Expression<Func<T, bool>> predicate) => _dbSet.FirstOrDefault(predicate);
        public virtual IQueryable<T> GetAll() => _dbSet;
        public virtual int SaveChanges() => _db.SaveChanges();
        public virtual Task<int> SaveChangesAsync() => _db.SaveChangesAsync();

        public abstract void Update(T entity);
        public abstract void UpdateRange(IEnumerable<T> entities);
    }
}
