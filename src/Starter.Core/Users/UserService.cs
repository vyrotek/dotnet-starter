using Starter.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Starter.Core.Users
{
    public class UserService
    {
        private IStarterDB _db;

        public UserService(IStarterDB db)
        {
            _db = db;
        }

        public async Task<User> GetUser(int id)
        {
            return new User() { Id = 1, DisplayName = "Jason" };
            //return await _db.QueryFirstAsync<User>("SELECT * FROM [User] WHERE [Id] = @Id", new { Id = id });
        }
    }
}
