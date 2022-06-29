using Microsoft.EntityFrameworkCore;
using Posts.Application.Interfaces.Repositories;
using Posts.Domain.Entities;
using Posts.Infrastructure.Context;
using Posts.Infrastructure.Persistance.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Posts.Infrastructure.Persistance
{
    public class CategoryRepository: Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(PostsDbContext db)
            : base(db)
        {
        }
        public override IQueryable<Category> Find(Expression<Func<Category, bool>> predicate) 
            => _dbSet
            .Include(x => x.Posts)
            .Include(x => x.AddedBy)
            .Where(predicate);

        public override Category Get(Expression<Func<Category, bool>> predicate) 
            => _dbSet
            .Include(x => x.Posts)
            .Include(x => x.AddedBy)
            .FirstOrDefault(predicate);

        public override IQueryable<Category> GetAll() 
            => _dbSet
            .Include(x=>x.Posts)
            .Include(x=>x.AddedBy);

        public override void Update(Category entity)
        {
            Category oldCategory = _dbSet.FirstOrDefault(x => x.Id == entity.Id);
            Update(entity, oldCategory);
        }

        public override void UpdateRange(IEnumerable<Category> entities)
        {
            foreach (var entity in entities)
            { 
                Update(entity);
            }
        }

        private static void Update(Category entity, Category oldCategory)
        { 
            
            oldCategory.Title = entity.Title;
            oldCategory.Posts = entity.Posts;
            oldCategory.UpdatedDate = DateTime.Now;
            oldCategory.UpdatedById = entity.UpdatedById;
        }
    }
}
