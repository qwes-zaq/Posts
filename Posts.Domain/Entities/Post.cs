using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Posts.Domain.Enums;
namespace Posts.Domain.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string PhotoPath { get; set; }
        public int Status { get; set; } = (int)Enums.Status.Active;
        public string Title { get; set; }
        public string Body { get; set; }

        public string AddedById { get; set; }
        public Author AddedBy { get; set; }
        public string UpdatedById { get; set; }
        public Author UpdatedBy { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
