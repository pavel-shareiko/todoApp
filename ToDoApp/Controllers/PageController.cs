using NLog;
using System.Windows.Forms;
using ToDoApp.Utils;

namespace ToDoApp.Controllers
{
    public class PageController : ILoggable
    {
        private readonly TaskController _taskController;
        private readonly Control _pageControl;

        public bool IsLoggingEnabled { get; set; } = true;
        public Logger Logger => LogManager.GetCurrentClassLogger();

        public PageController(TaskController taskController, Control pageControl)
        {
            _taskController = taskController;
            _pageControl = pageControl;
        }

        public void IncreasePage()
        {
            _taskController.Page++;
            UpdatePageControl();
            this.Log(LogLevel.Debug, "Page increased");
        }

        public void DecreasePage()
        {
            _taskController.Page--;
            UpdatePageControl();
            this.Log(LogLevel.Debug, "Page decreased");
        }

        public void UpdatePageControl()
        {
            _pageControl.Text = $"Page {_taskController.Page} of {_taskController.TotalPages}";
        }
    }
}
