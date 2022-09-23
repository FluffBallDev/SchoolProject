using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DataUtils.Models;

namespace DataUtils.Data
{
    public class UserData : IUserData
    {
        private readonly ISqlDataManager _db;

        public UserData(ISqlDataManager db)
        {
            _db = db;
        }

        public Task<List<User>> GetUsers()
        {
            const string sql = "select * from dome.users";

            return _db.LoadData<User, dynamic>(sql, new { });
        }

        public Task<List<User>> GetUser(string? name)
        {
            var trimStr = Regex.Replace(name!, "[\\:\\;\\´\\/\'\"\\{\\(\\)\\}\\[\\]]", "_");

            var sql = $"select * from dome.users where username='{trimStr}'";
            
            return _db.LoadData<User, dynamic>(sql, new { });
        }
        
        public Task InsertUser(User user)
        {
            const string sql = @"insert into dome.users (Id, Username, Email, Password) values (null, @Username, @Email, @Password);";

            return _db.SaveData(sql, user);
        }
    }
}