using AutoMapper;
using MediatR;
using Posts.Application.DTO.CategoryDTO;
using Posts.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Posts.Application.Features.Categories.Queries.GetList
{
    public class GetCategoryListQueryHandler 
        : IRequestHandler<GetCategoryListQuery, CategoryListDTO>
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;
        public GetCategoryListQueryHandler(IMapper mapper, ICategoryRepository categoryRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public async Task<CategoryListDTO> Handle(GetCategoryListQuery request, CancellationToken cancellationToken)
        {
            CategoryListDTO categoryList = new() {
                List = _mapper.Map<IEnumerable<CategoryDTO>>(_categoryRepository.GetAll())
        };
            return categoryList;
        }
    }
}
