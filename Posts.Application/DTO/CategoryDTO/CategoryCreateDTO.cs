using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posts.Application.DTO.CategoryDTO
{
    public class CategoryCreateDTO
    {
        public string Title { get; set; }
        public int Status { get; set; } = (int)Domain.Enums.Status.Active;

        public string AddedById { get; set; }
    }
}
