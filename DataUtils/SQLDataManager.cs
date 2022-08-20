using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;

namespace DataUtils
{
    public class SqlDataManager : ISqlDataManager
    {
        private readonly IConfiguration _config;

        public string ConnStringName { get; set; } = "Default";
        
        public SqlDataManager(IConfiguration config)
        {
            _config = config;
        }

        public async Task<List<T>> LoadData<T, TU>(string sql, TU parameters)
        {
            string? connString = _config.GetConnectionString(ConnStringName);
            using (IDbConnection connection = new MySqlConnection(connString))
            {
                var rows = await connection.QueryAsync<T>(sql, parameters);

                return rows.ToList();
            }
        }

        public Task SaveData<T>(string sql, T parameters)
        {
            string? connString = _config.GetConnectionString(ConnStringName);
            using (IDbConnection connection = new MySqlConnection(connString))
            {
                connection.Open();
                return connection.ExecuteAsync(sql, parameters);
            }
        }
    }
}