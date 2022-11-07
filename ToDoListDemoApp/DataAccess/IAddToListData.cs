using DataAccess.DataModels;

namespace DataAccess
{
    public interface IAddToListData
    {
        Task AddDataToList(ToDoListModel _param);
        Task<List<ToDoListModel>> GetToDoList();
    }
}