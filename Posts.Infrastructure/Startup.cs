using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Posts.Domain.Entities;
using Posts.Infrastructure.Context;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Posts.Application.Interfaces.Repositories.Base;
using Posts.Infrastructure.Persistance.Base;
using Posts.Application.Interfaces.Repositories;
using Posts.Infrastructure.Persistance;

namespace Posts.Infrastructure
{
    public class Startup
    {
        public static class ConfigureServices
        {
            public static void AddApplicationServices(IServiceCollection services, string connectionString)
            {
                services.AddDbContext<PostsDbContext>(options =>
                        options.UseSqlServer(connectionString));
                services.AddIdentity<Author, IdentityRole>().AddEntityFrameworkStores<PostsDbContext>();
                
                #region Repositories
                services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
                services.AddTransient<ICategoryRepository, CategoryRepository>();
                services.AddTransient<IPostRepository, PostRepository>();
                services.AddTransient<IAuthorRepository, AuthorRepository>();
                #endregion
            }
        }
    }
}
