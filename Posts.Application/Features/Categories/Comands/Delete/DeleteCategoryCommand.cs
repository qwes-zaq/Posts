﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posts.Application.Features.Categories.Comands.Delete
{
    public class DeleteCategoryCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
