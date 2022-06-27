using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posts.Application.DTO.CategoryDTO
{
    public class CategoryUpdateDTO
    {
        public int Id { get; set; }
        public int Status { get; set; } = (int)Domain.Enums.Status.Active;
        public string Title { get; set; }
        public string Body { get; set; }
        public string UpdatedById { get; set; }
    }
}
