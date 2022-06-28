using Microsoft.AspNetCore.Identity;
using Posts.Application.Interfaces.Repositories.Base;
using Posts.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posts.Application.Interfaces.Repositories
{
    public interface IAuthorRepository 
    {
        public Task<IdentityResult> Register(Author author, string password);
        public Task<SignInResult> PasswordSignInAsync(string userName, string password, bool isPersistent);
        public Task SignInAsync(Author author);
        public Task SignOutAsync();
    }
}
