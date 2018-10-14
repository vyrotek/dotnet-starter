using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Starter.Core.Services.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Starter.API.V1.Users
{
    public class UsersController : APIController
    {
        private ILogger _logger;
        private UserService _userSvc;

        public UsersController(ILogger<UsersController> logger, UserService userService)
        {
            _logger = logger;
            _userSvc = userService;
        }

        [HttpGet]
        public async Task<List<User>> GetUsers()
        {
            var users = await _userSvc.GetUsers();

            _logger.LogInformation("Retrieved Users");

            return users.Select(u => new User
            {
                Id = u.Id,
                Name = u.Name,
                Email = u.Email,
                CreatedAt = u.CreatedAt
            }).ToList();
        }
    }
}
