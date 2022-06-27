using MediatR;
using Posts.Application.DTO.CategoryDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posts.Application.Features.Categories.Queries.Get
{
    public class GetCategoryQuery : IRequest<CategoryDTO>
    {
        public int CategoryId { get; set; }
    }
}
