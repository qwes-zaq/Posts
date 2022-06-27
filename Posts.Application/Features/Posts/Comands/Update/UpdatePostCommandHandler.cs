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

namespace Posts.Application.Features.Posts.Comands.Update
{
    public class UpdatePostCommandHandler
        : IRequestHandler<UpdatePostCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IPostRepository _postRepository;
        public UpdatePostCommandHandler(IMapper mapper, IPostRepository postRepository)
        {
            _mapper = mapper;
            _postRepository = postRepository;
        }
        public async Task<int> Handle(UpdatePostCommand request, CancellationToken cancellationToken)
        {
            var oldPost = _postRepository.Get(x => x.Id == request.Id);
            var post = _mapper.Map<Post>(request);
            post.AddedBy = oldPost.AddedBy;
            post.AddedDate = oldPost.AddedDate;
            post.UpdatedDate = DateTime.Now;
            _postRepository.Update(post);
            _postRepository.SaveChanges();
            return post.Id;
        }
    }
}
