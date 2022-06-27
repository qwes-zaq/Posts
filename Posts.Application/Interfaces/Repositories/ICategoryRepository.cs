using Posts.Application.Interfaces.Repositories.Base;
using Posts.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Posts.Application.Interfaces.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {

    }
}
