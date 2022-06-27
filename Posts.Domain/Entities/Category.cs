using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posts.Domain.Entities
{
    public class Category
    {
        public Category()
        {
            Posts = new List<Post>();
        }
        public int Id { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public string AddedById { get; set; }
        public Author AddedBy { get; set; }
        public string UpdatedById { get; set; }
        public Author UpdatedBy { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
