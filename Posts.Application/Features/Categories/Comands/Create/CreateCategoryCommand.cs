using MediatR;
using Posts.Application.DTO.CategoryDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posts.Application.Features.Categories.Comands.Create
{
    public class CreateCategoryCommand: CategoryCreateDTO, IRequest<int>
    {
    }
}
