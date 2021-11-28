using ClientWeb.Models;
using Main.Application.Interfaces.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ClientWeb.Controllers
{
    public class AccountController : Controller
    {
        private IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<IActionResult> GetUserByUsername(string username)
        {

            var user = await _userService.GetUserAsync(username: username);
            return View();
        }

    }
}
