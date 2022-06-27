using Posts.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posts.Application.DTO.CategoryDTO
{
    public class CategoryDTO 
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Status { get; set; } = (int)Domain.Enums.Status.Active;

        public DateTime AddedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string AddedById { get; set; }
        public Author AddedBy { get; set; }
        public string UpdatedById { get; set; }
        public Author UpdatedBy { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
