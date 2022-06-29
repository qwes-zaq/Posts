using Microsoft.EntityFrameworkCore;
using Posts.Application.Interfaces.Repositories;
using Posts.Domain.Entities;
using Posts.Infrastructure.Context;
using Posts.Infrastructure.Persistance.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posts.Infrastructure.Persistance
{
    public class PostRepository: Repository<Post>, IPostRepository
    {
        public PostRepository(PostsDbContext db)
            :base(db)
        {
        }
        public override IQueryable<Post> GetAll() => 
            _dbSet
                .Include(x => x.Category)
                .Include(x => x.AddedBy)
                .Include(x => x.UpdatedBy);

        public override void Update(Post entity)
        {
            var oldPost = _dbSet.FirstOrDefault(x => x.Id == entity.Id);
            Update(oldPost, entity);
        }

        public override void UpdateRange(IEnumerable<Post> entities)
        {
            foreach (var entity in entities)
            {
                Update(entity);
            }
        }

        private static void Update(Post oldPost, Post entity)
        {
            oldPost.Title = entity.Title;
            oldPost.CategoryId = entity.CategoryId;
            oldPost.Status = entity.Status;
            oldPost.PhotoPath = entity.PhotoPath;
            oldPost.UpdatedById = entity.UpdatedById;
            oldPost.UpdatedDate = DateTime.Now;
            oldPost.Body = entity.Body;
        }
    }
}
