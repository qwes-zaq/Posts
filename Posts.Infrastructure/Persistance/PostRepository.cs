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
    }
}
