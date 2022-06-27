using MediatR;
using Posts.Application.DTO.PostDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posts.Application.Features.Posts.Queries.Get
{
    public class GetPostQuery : IRequest<PostDTO>
    {
        public int PostId { get; set; }
    }
}
