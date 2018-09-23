using LinqToDB;
using LinqToDB.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Starter.Core.Data.Database
{
    public class StarterDBConnection : DataConnection
    {
        public StarterDBConnection(string connectionString)
            : base("SqlServer", connectionString)
        {
        }

        public ITable<User> Users => GetTable<User>();
    }
}
