using To_Do_List_Application.Models;

namespace To_Do_List_Application.Services.Interfaces
{
    public interface ITaskService
    {
        List<TaskItem> GetAllTasks();
        List<TaskItem> GetPendingTasks();
        List<TaskItem> GetCompletedTasks();
        TaskItem AddTask(string title);
        void TaskStatus(int id);
        void DeleteTask(int id);
    }
}
