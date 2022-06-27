using AutoMapper;
using MediatR;
using Posts.Application.DTO.CategoryDTO;
using Posts.Application.Features.Categories.Queries.Get;
using Posts.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Posts.Application.Features.Categories.Queries.Get
{
    public class GetCategoryQueryHandler
        : IRequestHandler<GetCategoryQuery, CategoryDTO>
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;
        public GetCategoryQueryHandler(IMapper mapper, ICategoryRepository categoryRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public async Task<CategoryDTO> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
        {
            var category = _categoryRepository.Get(x => x.Id == request.CategoryId);
            return _mapper.Map<CategoryDTO>(category);
        }
    }
}
