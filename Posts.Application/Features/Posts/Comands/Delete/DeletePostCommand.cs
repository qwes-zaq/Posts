using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posts.Application.Features.Posts.Comands.Delete
{
    public class DeletePostCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
