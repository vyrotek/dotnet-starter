using Microsoft.AspNetCore.Mvc;
using Starter.Core.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Starter.API.V1
{
    public class UsersController : APIController
    {
        private UserService _userService;

        public UsersController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet("get")]
        public async Task<User> Get()
        {
            return await _userService.GetUser(1);
        }

        [HttpGet("list")]
        public IEnumerable<Object> List()
        {
            return new List<Object>()
            {
                new { Name = "Jason" }
            };
        }
    }
}
