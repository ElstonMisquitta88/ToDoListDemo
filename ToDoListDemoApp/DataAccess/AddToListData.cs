using DataAccess.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AddToListData : IAddToListData
    {
        private readonly ISqlDataAccess _db;
        public AddToListData(ISqlDataAccess db)
        {
            _db = db;
        }

        public Task<List<ToDoListModel>> GetToDoList()
        {
            string sql = "Proc_GetList";
            return _db.LoadData<ToDoListModel, dynamic>(sql, new { });
        }

        public Task AddDataToList(ToDoListModel _param)
        {
           
            var sql = "EXEC Proc_AddList @TaskName";
            var values = new { TaskName = _param.TaskName  };

            return _db.SaveData(sql, values);
        }

    }
}
