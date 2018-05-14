using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Transactions;

namespace Starter.Core.Data
{
    public interface IDapperDB
    {
        Task ExecuteAsync(string sql, object param = null);
        SqlConnection GetConnection();
        Task<SqlConnection> GetConnectionAsync();
        TransactionScope GetTransaction();
        Task<TReturn> QueryFirstAsync<T1, T2, T3, T4, TReturn>(string sql, Func<T1, T2, T3, T4, TReturn> map, object param = null, string splitOn = null, CommandType? commandType = null);
        Task<TReturn> QueryFirstAsync<T1, T2, T3, TReturn>(string sql, Func<T1, T2, T3, TReturn> map, object param = null, string splitOn = null, CommandType? commandType = null);
        Task<TReturn> QueryFirstAsync<T1, T2, TReturn>(string sql, Func<T1, T2, TReturn> map, object param = null, string splitOn = null, CommandType? commandType = null);
        Task<TReturn> QueryFirstAsync<TReturn>(string sql, object param = null, CommandType? commandType = null);
        Task<List<TReturn>> QueryListAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TReturn>(string sql, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TReturn> map, object param = null, string splitOn = null, CommandType? commandType = null);
        Task<List<TReturn>> QueryListAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn>(string sql, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn> map, object param = null, string splitOn = null, CommandType? commandType = null);
        Task<List<TReturn>> QueryListAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, TReturn>(string sql, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TReturn> map, object param = null, string splitOn = null, CommandType? commandType = null);
        Task<List<TReturn>> QueryListAsync<T1, T2, T3, T4, T5, T6, T7, T8, TReturn>(string sql, Func<T1, T2, T3, T4, T5, T6, T7, T8, TReturn> map, object param = null, string splitOn = null, CommandType? commandType = null);
        Task<List<TReturn>> QueryListAsync<T1, T2, T3, T4, T5, T6, T7, TReturn>(string sql, Func<T1, T2, T3, T4, T5, T6, T7, TReturn> map, object param = null, string splitOn = null, CommandType? commandType = null);
        Task<List<TReturn>> QueryListAsync<T1, T2, T3, T4, T5, T6, TReturn>(string sql, Func<T1, T2, T3, T4, T5, T6, TReturn> map, object param = null, string splitOn = null, CommandType? commandType = null);
        Task<List<TReturn>> QueryListAsync<T1, T2, T3, T4, T5, TReturn>(string sql, Func<T1, T2, T3, T4, T5, TReturn> map, object param = null, string splitOn = null, CommandType? commandType = null);
        Task<List<TReturn>> QueryListAsync<T1, T2, T3, T4, TReturn>(string sql, Func<T1, T2, T3, T4, TReturn> map, object param = null, string splitOn = null, CommandType? commandType = null);
        Task<List<TReturn>> QueryListAsync<T1, T2, T3, TReturn>(string sql, Func<T1, T2, T3, TReturn> map, object param = null, string splitOn = null, CommandType? commandType = null);
        Task<List<TReturn>> QueryListAsync<T1, T2, TReturn>(string sql, Func<T1, T2, TReturn> map, object param = null, string splitOn = null, CommandType? commandType = null);
        Task<List<TReturn>> QueryListAsync<TReturn>(string sql, object param = null, CommandType? commandType = null);
    }
}