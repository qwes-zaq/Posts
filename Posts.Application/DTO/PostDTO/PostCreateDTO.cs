using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posts.Application.DTO.PostDTO
{
    public class PostCreateDTO
    {
        public string PhotoPath { get; set; }
        public int Status { get; set; } = (int)Domain.Enums.Status.Active;
        public string Title { get; set; }
        public string Body { get; set; }

        public string AddedById { get; set; }

        public int CategoryId { get; set; }
    }
}
