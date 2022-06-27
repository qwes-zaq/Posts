using MediatR;
using Posts.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Posts.Application.Features.Posts.Comands.Delete
{
    class DeletePostCommandHandler
        : IRequestHandler<DeletePostCommand, int>
    {
        private readonly IPostRepository _postRepository;
        public DeletePostCommandHandler( IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public async Task<int> Handle(DeletePostCommand request, CancellationToken cancellationToken)
        {
            var post = _postRepository.Get(x => x.Id == request.Id);
            _postRepository.Remove(post);
            _postRepository.SaveChanges();
            return post.Id;
        }
    }
}
