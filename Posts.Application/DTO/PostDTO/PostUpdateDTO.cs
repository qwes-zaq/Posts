using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posts.Application.DTO.PostDTO
{
    public class PostUpdateDTO
    {
        public int Id { get; set; }
        public string PhotoPath { get; set; }
        public int Status { get; set; } = (int)Domain.Enums.Status.Active;
        public string Title { get; set; }
        public string Body { get; set; }
        public string UpdatedById { get; set; }

        public int CategoryId { get; set; }
    }
}
