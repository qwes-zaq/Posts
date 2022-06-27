using AutoMapper;
using MediatR;
using Posts.Application.DTO;
using Posts.Application.DTO.PostDTO;
using Posts.Application.Interfaces.Repositories;
using Posts.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Posts.Application.Features.Posts.Comands.Create
{
    public class CreatePostCommandHandler
        : IRequestHandler<CreatePostCommand, int >
    {
        private readonly IMapper _mapper;
        private readonly IPostRepository _postRepository;
        public CreatePostCommandHandler(IMapper mapper, IPostRepository postRepository)
        {
            _mapper = mapper;
            _postRepository = postRepository;
        }
        public async Task<int> Handle(CreatePostCommand request, CancellationToken cancellationToken)
        {
            var post = _mapper.Map<Post>(request);
            post.AddedDate = DateTime.Now;
            _postRepository.Add(post);
            _postRepository.SaveChanges();
            return post.Id;
        }
    }
}
