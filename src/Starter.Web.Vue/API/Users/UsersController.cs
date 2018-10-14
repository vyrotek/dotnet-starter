using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Starter.Core.Data.Database;
using Microsoft.AspNetCore.Mvc;
using Starter.Core.Services.Users;

namespace Starter.Web.API.Users
{
    [Route("api/users")]
    public class UsersController : Controller
    {
        private UserService _userSvc;

        public UsersController(UserService userSvc)
        {
            _userSvc = userSvc;
        }

        [HttpGet]
        public async Task<object> GetUsers()
        {
            var users = await _userSvc.GetUsers();

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
