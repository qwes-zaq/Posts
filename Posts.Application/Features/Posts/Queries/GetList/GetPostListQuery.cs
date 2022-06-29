using MediatR;
using Posts.Application.DTO.PostDTO;
using Posts.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Posts.Application.Features.Posts.Queries.GetList
{
    public class GetPostListQuery : IRequest<PostListDTO>
    {
       public Expression<Func<Post, bool>> Predicate { get; set; }
    }
}
