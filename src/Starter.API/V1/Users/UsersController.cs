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
        private UserService _userService;
        
        public UsersController(ILogger<UsersController> logger, UserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpGet("GetUser")]
        public async Task<User> GetUser(int id)
        {
            var user = await _userService.GetUser(id);

            _logger.LogInformation("NEAT STUFF");

            return new User()
            {
                Name = user.Name
            };
        }
    }
}
