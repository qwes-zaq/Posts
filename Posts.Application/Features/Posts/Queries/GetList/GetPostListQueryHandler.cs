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

namespace Posts.Application.Features.Posts.Queries.GetList
{
    public class GetPostListQueryHandler 
        : IRequestHandler<GetPostListQuery, PostListDTO>
    {
        private readonly IMapper _mapper;
        private readonly IPostRepository _postRepository;
        public GetPostListQueryHandler(IMapper mapper, IPostRepository postRepository)
        {
            _mapper = mapper;
            _postRepository = postRepository;
        }

        public async Task<PostListDTO> Handle(GetPostListQuery request, CancellationToken cancellationToken)
        {

            PostListDTO postList = new() {};

             postList.List =request.Predicate == null ? 
                _mapper.Map<IEnumerable<PostDTO>>(_postRepository.GetAll()) : 
                _mapper.Map<IEnumerable<PostDTO>>(_postRepository.Find(request.Predicate));

            return postList;
        }
    }
}
