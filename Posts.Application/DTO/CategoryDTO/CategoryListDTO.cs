using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posts.Application.DTO.CategoryDTO
{
    public class CategoryListDTO
    {
        public IEnumerable<CategoryDTO> List { get; set; }
    }
}
