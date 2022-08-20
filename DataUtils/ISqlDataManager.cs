using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataUtils
{
    public interface ISqlDataManager
    {
        Task<List<T>> LoadData<T, TU>(string sql, TU parameters);
        Task SaveData<T>(string sql, T parameters);
    }
}