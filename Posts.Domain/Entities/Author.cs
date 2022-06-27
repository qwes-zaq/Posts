using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posts.Domain.Entities
{
    public class Author :IdentityUser
    {
        public Author()
        {
            AddedPosts = new List<Post>();
            UpdatedPosts = new List<Post>();
            AddedCategories = new List<Category>();
            UpdatedCategories = new List<Category>();
        }
        
        public virtual ICollection<Post> AddedPosts { get; set; }
        public virtual ICollection<Post> UpdatedPosts { get; set; }
        public virtual ICollection<Category> AddedCategories { get; set; }
        public virtual ICollection<Category> UpdatedCategories { get; set; }
    }
}
