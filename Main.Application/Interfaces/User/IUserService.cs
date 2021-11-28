using Main.Application.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Application.Interfaces.User
{
    public interface IUserService
    {
        Task<UserViewModel> GetUserAsync(string username);
    }
}
