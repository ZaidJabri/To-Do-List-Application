using Microsoft.AspNetCore.Mvc;
using To_Do_List_Application.Services.Interfaces;

namespace To_Do_List_Application.Controllers
{
    public class TaskController : Controller
    {
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        public ActionResult Index()
        {
            var pendingTasks = _taskService.GetPendingTasks();
            var completedTasks = _taskService.GetCompletedTasks();

            ViewBag.PendingTasks = pendingTasks;
            ViewBag.CompletedTasks = completedTasks;

            return View();
        }

        [HttpPost]
        public ActionResult Add(string title)
        {
            if (!string.IsNullOrWhiteSpace(title))
            {
                _taskService.AddTask(title);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Status(int id)
        {
            _taskService.TaskStatus(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            _taskService.DeleteTask(id);
            return RedirectToAction("Index");
        }
    }
}
