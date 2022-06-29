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
        public string Title { get; set; }
        public string UpdatedById { get; set; }
    }
}
