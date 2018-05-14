using Dapper;
using Starter.Core.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Starter.Infrastructure.Data
{
    public abstract class DapperDB : IDapperDB
    {
        private const int TIMEOUT = 300;
        
        public DapperDB()
        {
        }

        public abstract SqlConnection GetConnection();

        public abstract Task<SqlConnection> GetConnectionAsync();

        public TransactionScope GetTransaction()
        {
            var transactionOptions = new TransactionOptions();
            transactionOptions.IsolationLevel = System.Transactions.IsolationLevel.ReadUncommitted; //Allows reads
            transactionOptions.Timeout = TransactionManager.MaximumTimeout;

            return new TransactionScope(TransactionScopeOption.Required, transactionOptions, TransactionScopeAsyncFlowOption.Enabled);
        }


        public async Task ExecuteAsync(string sql, object param = null)
        {
            using (var conn = GetConnection())
            {
                await conn.ExecuteAsync(sql, param: param, commandTimeout: TIMEOUT);
            }
        }
        

        public async Task<List<TReturn>> QueryListAsync<TReturn>(string sql, object param = null, CommandType? commandType = null)
        {
            using (var conn = await GetConnectionAsync())
            {
                return (await conn.QueryAsync<TReturn>(sql, param: param, commandTimeout: TIMEOUT, commandType: commandType)).ToList();
            }
        }

        public async Task<List<TReturn>> QueryListAsync<T1, T2, TReturn>(string sql, Func<T1, T2, TReturn> map, object param = null, string splitOn = null, CommandType? commandType = null)
        {
            using (var conn = await GetConnectionAsync())
            {
                return (await conn.QueryAsync(sql, map, param: param, commandTimeout: TIMEOUT, splitOn: splitOn, commandType: commandType)).ToList();
            }
        }

        public async Task<List<TReturn>> QueryListAsync<T1, T2, T3, TReturn>(string sql, Func<T1, T2, T3, TReturn> map, object param = null, string splitOn = null, CommandType? commandType = null)
        {
            using (var conn = await GetConnectionAsync())
            {
                return (await conn.QueryAsync(sql, map, param: param, commandTimeout: TIMEOUT, splitOn: splitOn, commandType: commandType)).ToList();
            }
        }

        public async Task<List<TReturn>> QueryListAsync<T1, T2, T3, T4, TReturn>(string sql, Func<T1, T2, T3, T4, TReturn> map, object param = null, string splitOn = null, CommandType? commandType = null)
        {
            using (var conn = await GetConnectionAsync())
            {
                return (await conn.QueryAsync(sql, map, param: param, commandTimeout: TIMEOUT, splitOn: splitOn, commandType: commandType)).ToList();
            }
        }

        public async Task<List<TReturn>> QueryListAsync<T1, T2, T3, T4, T5, TReturn>(string sql, Func<T1, T2, T3, T4, T5, TReturn> map, object param = null, string splitOn = null, CommandType? commandType = null)
        {
            using (var conn = await GetConnectionAsync())
            {
                return (await conn.QueryAsync(sql, map, param: param, commandTimeout: TIMEOUT, splitOn: splitOn, commandType: commandType)).ToList();
            }
        }

        public async Task<List<TReturn>> QueryListAsync<T1, T2, T3, T4, T5, T6, TReturn>(string sql, Func<T1, T2, T3, T4, T5, T6, TReturn> map, object param = null, string splitOn = null, CommandType? commandType = null)
        {
            using (var conn = await GetConnectionAsync())
            {
                return (await conn.QueryAsync(sql, map, param: param, commandTimeout: TIMEOUT, splitOn: splitOn, commandType: commandType)).ToList();
            }
        }

        public async Task<List<TReturn>> QueryListAsync<T1, T2, T3, T4, T5, T6, T7, TReturn>(string sql, Func<T1, T2, T3, T4, T5, T6, T7, TReturn> map, object param = null, string splitOn = null, CommandType? commandType = null)
        {
            using (var conn = await GetConnectionAsync())
            {
                return (await conn.QueryAsync(sql, map, param: param, commandTimeout: TIMEOUT, splitOn: splitOn, commandType: commandType)).ToList();
            }
        }

        public async Task<List<TReturn>> QueryListAsync<T1, T2, T3, T4, T5, T6, T7, T8, TReturn>(string sql, Func<T1, T2, T3, T4, T5, T6, T7, T8, TReturn> map, object param = null, string splitOn = null, CommandType? commandType = null)
        {
            var types = new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5),
                typeof(T6), typeof(T7), typeof(T8) };

            var mapWrapper = new Func<object[], TReturn>(objects => map((T1)objects[0], (T2)objects[1], (T3)objects[2], (T4)objects[3], (T5)objects[4],
                (T6)objects[5], (T7)objects[6], (T8)objects[7]));

            using (var conn = await GetConnectionAsync())
            {
                return (await conn.QueryAsync(sql, types, mapWrapper, param: param, commandTimeout: TIMEOUT, splitOn: splitOn, commandType: commandType)).ToList();
            }
        }

        public async Task<List<TReturn>> QueryListAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, TReturn>(string sql, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TReturn> map, object param = null, string splitOn = null, CommandType? commandType = null)
        {
            var types = new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5),
                typeof(T6), typeof(T7), typeof(T8), typeof(T9) };

            var mapWrapper = new Func<object[], TReturn>(objects => map((T1)objects[0], (T2)objects[1], (T3)objects[2], (T4)objects[3], (T5)objects[4],
                (T6)objects[5], (T7)objects[6], (T8)objects[7], (T9)objects[8]));

            using (var conn = await GetConnectionAsync())
            {
                return (await conn.QueryAsync(sql, types, mapWrapper, param: param, commandTimeout: TIMEOUT, splitOn: splitOn, commandType: commandType)).ToList();
            }
        }

        public async Task<List<TReturn>> QueryListAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn>(string sql, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TReturn> map, object param = null, string splitOn = null, CommandType? commandType = null)
        {
            var types = new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5),
                typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10) };

            var mapWrapper = new Func<object[], TReturn>(objects => map((T1)objects[0], (T2)objects[1], (T3)objects[2], (T4)objects[3], (T5)objects[4],
                (T6)objects[5], (T7)objects[6], (T8)objects[7], (T9)objects[8], (T10)objects[9]));

            using (var conn = await GetConnectionAsync())
            {
                return (await conn.QueryAsync(sql, types, mapWrapper, param: param, commandTimeout: TIMEOUT, splitOn: splitOn, commandType: commandType)).ToList();
            }
        }

        public async Task<List<TReturn>> QueryListAsync<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TReturn>(string sql, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TReturn> map, object param = null, string splitOn = null, CommandType? commandType = null)
        {
            var types = new Type[] { typeof(T1), typeof(T2), typeof(T3), typeof(T4), typeof(T5),
                typeof(T6), typeof(T7), typeof(T8), typeof(T9), typeof(T10), typeof(T11) };

            var mapWrapper = new Func<object[], TReturn>(objects => map((T1)objects[0], (T2)objects[1], (T3)objects[2], (T4)objects[3], (T5)objects[4],
                (T6)objects[5], (T7)objects[6], (T8)objects[7], (T9)objects[8], (T10)objects[9], (T11)objects[10]));

            using (var conn = await GetConnectionAsync())
            {
                return (await conn.QueryAsync(sql, types, mapWrapper, param: param, commandTimeout: TIMEOUT, splitOn: splitOn, commandType: commandType)).ToList();
            }
        }


        public async Task<TReturn> QueryFirstAsync<TReturn>(string sql, object param = null, CommandType? commandType = null)
        {
            using (var conn = await GetConnectionAsync())
            {
                return (await conn.QueryAsync<TReturn>(sql, param: param, commandTimeout: TIMEOUT, commandType: commandType)).FirstOrDefault();
            }
        }

        public async Task<TReturn> QueryFirstAsync<T1, T2, TReturn>(string sql, Func<T1, T2, TReturn> map, object param = null, string splitOn = null, CommandType? commandType = null)
        {
            using (var conn = await GetConnectionAsync())
            {
                return (await conn.QueryAsync(sql, map, param: param, commandTimeout: TIMEOUT, splitOn: splitOn, commandType: commandType)).FirstOrDefault();
            }
        }

        public async Task<TReturn> QueryFirstAsync<T1, T2, T3, TReturn>(string sql, Func<T1, T2, T3, TReturn> map, object param = null, string splitOn = null, CommandType? commandType = null)
        {
            using (var conn = await GetConnectionAsync())
            {
                return (await conn.QueryAsync(sql, map, param: param, commandTimeout: TIMEOUT, splitOn: splitOn, commandType: commandType)).FirstOrDefault();
            }
        }

        public async Task<TReturn> QueryFirstAsync<T1, T2, T3, T4, TReturn>(string sql, Func<T1, T2, T3, T4, TReturn> map, object param = null, string splitOn = null, CommandType? commandType = null)
        {
            using (var conn = await GetConnectionAsync())
            {
                return (await conn.QueryAsync(sql, map, param: param, commandTimeout: TIMEOUT, splitOn: splitOn, commandType: commandType)).FirstOrDefault();
            }
        }
    }
}
