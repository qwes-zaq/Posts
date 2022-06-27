using MediatR;
using Posts.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Posts.Application.Features.Categories.Comands.Delete
{
    class DeleteCategoryCommandHandler
        : IRequestHandler<DeleteCategoryCommand, int>
    {
        private readonly ICategoryRepository _categoryRepository;
        public DeleteCategoryCommandHandler( ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<int> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = _categoryRepository.Get(x => x.Id == request.Id);
            _categoryRepository.Remove(category);
            _categoryRepository.SaveChanges();
            return category.Id;
        }
    }
}
