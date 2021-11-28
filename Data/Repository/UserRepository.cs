using Data.Context;
using Main.Domain.Interfaces;
using Main.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public UserRepository(ApplicationDbContext db, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> singInManager)
        {
            _signInManager = singInManager;
            _userManager = userManager;
            _db = db;
        }
        public async Task<ApplicationUser> GetUserAsync(string username) => (ApplicationUser)await _db.Users.Where(x => x.UserName == username).FirstOrDefaultAsync();
    }
}
