using AutoMapper;
using MediatR;
using Posts.Application.DTO.PostDTO;
using Posts.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Posts.Application.Features.Posts.Queries.Get
{
    public class GetPostQueryHandler
        : IRequestHandler<GetPostQuery, PostDTO>
    {
        private readonly IMapper _mapper;
        private readonly IPostRepository _postRepository;
        public GetPostQueryHandler(IMapper mapper, IPostRepository postRepository)
        {
            _mapper = mapper;
            _postRepository = postRepository;
        }

        public async Task<PostDTO> Handle(GetPostQuery request, CancellationToken cancellationToken)
        {
            var post = _postRepository.Get(x => x.Id == request.PostId);
            return _mapper.Map<PostDTO>(post);
        }
    }
}
