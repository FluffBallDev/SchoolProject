using System.Collections.Generic;
using System.Threading.Tasks;
using DataUtils.Models;

namespace DataUtils.Data
{
    public interface IUserData
    {
        Task<List<User>> GetUsers();
        Task InsertUser(User user);
        Task<List<User>> GetUser(string? name);
    }
}