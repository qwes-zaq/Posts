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
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly PostsDbContext _db;

        protected DbSet<T> _dbSet;

        public Repository(PostsDbContext db)
        {
            _db = db;
            _dbSet = db.Set<T>();
        }

        public void Add(T entity) => _dbSet.Add(entity);
        public void AddRange(IEnumerable<T> entities) => _dbSet.AddRange(entities);
        public int Count(Expression<Func<T, bool>> predicate) => _dbSet.Count(predicate);
        public IQueryable<T> Find(Expression<Func<T, bool>> predicate) => _dbSet.Where(predicate);
        public T Get(Expression<Func<T, bool>> predicate) => _dbSet.FirstOrDefault(predicate);
        public IQueryable<T> GetAll() => _dbSet;
        public void Remove(T entity) => _dbSet.Remove(entity);
        public void RemoveRange(IEnumerable<T> entities) => _dbSet.RemoveRange(entities);
        public void Update(T entity) => _dbSet.Update(entity);
        public void UpdateRange(IEnumerable<T> entities) => _dbSet.UpdateRange(entities);
        public int SaveChanges() => _db.SaveChanges();

    }
}
