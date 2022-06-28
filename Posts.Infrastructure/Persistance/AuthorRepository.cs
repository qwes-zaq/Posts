using Microsoft.AspNetCore.Identity;
using Posts.Application.Interfaces.Repositories;
using Posts.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Posts.Infrastructure.Persistance
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly UserManager<Author> _userManager;
        private readonly SignInManager<Author> _signInManager;
        public AuthorRepository(UserManager<Author> userManager, SignInManager<Author> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<SignInResult> PasswordSignInAsync(string userName, string password, bool isPersistent) 
            => await _signInManager.PasswordSignInAsync(userName, password, isPersistent, false);

        public async Task<IdentityResult> Register(Author author, string password) 
            => await _userManager.CreateAsync(author, password);

        public async Task SignInAsync(Author author) => await _signInManager.SignInAsync(author, false);

        public async Task SignOutAsync() => await _signInManager.SignOutAsync();
    }
}
