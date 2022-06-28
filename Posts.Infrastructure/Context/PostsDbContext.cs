using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Posts.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posts.Infrastructure.Context
{
    public class PostsDbContext : IdentityDbContext<Author>
    {
        DbSet<Category> Categories { get; set; }
        DbSet<Post> Posts { get; set; }

        public PostsDbContext(DbContextOptions<PostsDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>().HasKey(sc => sc.Id);
            modelBuilder.Entity<Post>().HasKey(sc => sc.Id);

            modelBuilder.Entity<Post>()
               .HasOne(s => s.Category)
               .WithMany(g => g.Posts)
               .HasForeignKey(s => s.CategoryId);

            modelBuilder.Entity<Post>()
              .HasOne(s => s.AddedBy)
              .WithMany(g => g.AddedPosts)
              .HasForeignKey(s => s.AddedById);

            modelBuilder.Entity<Category>()
                .HasOne(s => s.AddedBy)
                .WithMany(g => g.AddedCategories)
                .HasForeignKey(s => s.AddedById);

            modelBuilder.Entity<Post>()
              .HasOne(s => s.UpdatedBy)
              .WithMany(g => g.UpdatedPosts)
              .HasForeignKey(s => s.UpdatedById);

            modelBuilder.Entity<Category>()
              .HasOne(s => s.UpdatedBy)
              .WithMany(g => g.UpdatedCategories)
              .HasForeignKey(s => s.UpdatedById);


            base.OnModelCreating(modelBuilder);
        }
    }
}