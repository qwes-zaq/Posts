using Microsoft.EntityFrameworkCore;
using Posts.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posts.Application.Interfaces.Data
{
    interface IPostDbContext: IDisposable
    {
        DbSet<Category> Categories { get; set; }
        DbSet<Post> Posts { get; set; }
        DbSet<Author> Users { get; set; }
        public int SaveChanges();
    }
}
