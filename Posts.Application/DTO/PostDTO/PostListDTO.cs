using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posts.Application.DTO.PostDTO
{
    public class PostListDTO
    {
        public IEnumerable<PostDTO> List { get; set; }
    }
}
