using Main.Application.Interfaces.User;
using Main.Application.Mapper;
using Main.Application.ViewModels.User;
using Main.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Application.Services.User
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<UserViewModel> GetUserAsync(string username)
        {
            var model = await _userRepository.GetUserAsync(username);
            var mapped = ObjectMapper.Mapper.Map<UserViewModel>(model);
            return mapped;
        }
    }
}
