using MediatR;
using Posts.Application.DTO.CategoryDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posts.Application.Features.Categories.Queries.GetList
{
    public class GetCategoryListQuery : IRequest<CategoryListDTO>
    {
    }
}
