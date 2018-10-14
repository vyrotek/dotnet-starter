using Starter.Core.Data.Database;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using LinqToDB.Data;
using LinqToDB;

namespace Starter.Core.Services.Users
{
    public class UserService
    {
        private StarterDB _db { get; }

        public UserService(StarterDB db)
        {
            _db = db;
        }        

        public async Task<List<User>> GetUsers()
        {
            using (var conn = _db.GetConnection())
            {
                return await conn.Users.ToListAsync();
            }
        }

        public async Task<User> GetUser(int id)
        {
            using (var conn = _db.GetConnection())
            {
                return await conn.Users.FirstAsync();
            }
        }
    }
}
