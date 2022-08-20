using System.Collections.Generic;
using System.Threading.Tasks;
using DataUtils.Models;

namespace DataUtils.Data
{
    public interface IContentData
    {
        Task<List<Content>> GetContent();
        Task InsertContent(Content content);
    }
}