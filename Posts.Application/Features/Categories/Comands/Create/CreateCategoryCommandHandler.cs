using AutoMapper;
using MediatR;
using Posts.Application.Interfaces.Repositories;
using Posts.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Posts.Application.Features.Categories.Comands.Create
{
    public class CreateCategoryCommandHandler
        : IRequestHandler<CreateCategoryCommand, int >
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;
        public CreateCategoryCommandHandler(IMapper mapper, ICategoryRepository categoryRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }
        public async Task<int> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = _mapper.Map<Category>(request);
            category.AddedDate = DateTime.Now;
            _categoryRepository.Add(category);
            _categoryRepository.SaveChanges();
            return category.Id;
        }
    }
}
