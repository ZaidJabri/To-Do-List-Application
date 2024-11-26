using To_Do_List_Application.Models;
using To_Do_List_Application.Services.Interfaces;

namespace To_Do_List_Application.Services
{
    public class TaskService : ITaskService
    {
        private static List<TaskItem> _tasks = [];
        private static int _currentId = 0;

        public List<TaskItem> GetAllTasks() => _tasks;

        public List<TaskItem> GetPendingTasks() => _tasks.Where(t => !t.IsCompleted).ToList();

        public List<TaskItem> GetCompletedTasks() => _tasks.Where(t => t.IsCompleted).ToList();

        public TaskItem AddTask(string title)
        {
            var newTask = new TaskItem
            {
                Id = ++_currentId,
                Title = title,
            };
            _tasks.Add(newTask);
            return newTask;
        }

        public void TaskStatus(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                task.IsCompleted = !task.IsCompleted;
            }
        }
        public void DeleteTask(int id)
        {
            var task = _tasks.FirstOrDefault(t => t.Id == id);
            if (task != null)
            {
                _tasks.Remove(task);
            }
        }
    }
}
