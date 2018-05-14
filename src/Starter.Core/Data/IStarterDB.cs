using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Starter.Core.Data
{
    public interface IStarterDB : IDapperDB
    {
        SqlConnection GetConnection();
        Task<SqlConnection> GetConnectionAsync();
    }
}