using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posts.Infrastructure.Context
{
    public class PostsDbContextFactory : IDesignTimeDbContextFactory<PostsDbContext>
    {
        public PostsDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PostsDbContext>();
            builder.UseSqlServer(
                "Server = QWERTY; Database = Postsdb; Trusted_Connection = True; MultipleActiveResultSets = true"
                );
            return new PostsDbContext(builder.Options);
        }
    }
}
