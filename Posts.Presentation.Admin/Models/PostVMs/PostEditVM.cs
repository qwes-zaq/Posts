using Microsoft.AspNetCore.Mvc.Rendering;
using Posts.Application.DTO.PostDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Posts.Presentation.Admin.Models.PostVMs
{
    public class PostEditVM
    {
        public PostUpdateDTO OldVersion { get; set; }
        public IEnumerable<SelectListItem> CategoryList { get; set; }
    }
}
