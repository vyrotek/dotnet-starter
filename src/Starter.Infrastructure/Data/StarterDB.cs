using Starter.Core.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Starter.Infrastructure.Data
{
    public class StarterDB : DapperDB, IStarterDB
    {
        private Settings _settings;

        public StarterDB(Settings settings)
        {
            _settings = settings;
        }
        
        public override SqlConnection GetConnection()
        {
            var conn = InitConnection();
            conn.Open();
            return conn;
        }

        public async override Task<SqlConnection> GetConnectionAsync()
        {
            var conn = InitConnection();
            await conn.OpenAsync();
            return conn;
        }

        private SqlConnection InitConnection()
        {
            return new SqlConnection(_settings.ConnectionString);
        }
    }
}
