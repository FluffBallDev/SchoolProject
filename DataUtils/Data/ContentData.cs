using System.Collections.Generic;
using System.Threading.Tasks;
using DataUtils.Models;

namespace DataUtils.Data
{
    public class ContentData : IContentData
    {
        private readonly ISqlDataManager _db;

        public ContentData(ISqlDataManager db)
        {
            _db = db;
        }

        public Task<List<Content>> GetContent()
        {
            string sql = "select * from dome.sitecontent";

            return _db.LoadData<Content, dynamic>(sql, new { });
        }

        public Task InsertContent(Content content)
        {
            string sql = @"insert into dome.sitecontent (Id, Name, Content) values (@Id, @Name, @Content";
            return _db.SaveData(sql, content);
        }
        
    }
}