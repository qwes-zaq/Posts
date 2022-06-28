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
    public class CategoryRepository: Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(PostsDbContext db)
            : base(db)
        {
        }
    }
}
