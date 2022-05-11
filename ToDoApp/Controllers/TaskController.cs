using Logic.Utils;
using NLog;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoApp.UI;
using ToDoApp.UI.Controls;

namespace ToDoApp.Controls
{
    public class TaskController : ILoggable
    {
        private const int TasksPerPage = 10;
        private readonly Panel tasksPanel;
        private int _page = 1;

        public bool IsLoggingEnabled { get; set; } = true;
        public bool IsLoading { get; private set; }
        public TaskView SelectedItem { get; set; }
        public int Page
        {
            get => _page;
            set
            {
                if (IsLoading)
                {
                    return;
                }
                
                var prevValue = _page;
                if (value < 1)
                {
                    _page = TotalPages == 0 ? 0 : 1;
                }
                else if (value >= TotalPages)
                {
                    _page = TotalPages;
                }
                else
                {
                    _page = value;
                }

                if (prevValue != _page)
                {
                    ReloadTasksAsync();
                }

            }
        }

        public int TotalPages => (int)Math.Ceiling(TaskManager.GetTasksCount() / (double)TasksPerPage);

        public Logger Logger => LogManager.GetCurrentClassLogger();

        public TaskController(Panel tasksPanel)
        {
            this.tasksPanel = tasksPanel ?? throw new ArgumentNullException("Tasks panel cannot be null");
        }

        public async void ReloadTasksAsync()
        {
            var tasksToShow = await TaskManager.GetTasksAsync((Page - 1) * TasksPerPage, TasksPerPage);
            if (tasksToShow.Count == 0)
            {
                tasksPanel.Controls.Clear();
                ShowNoTasksLabel();
                return;
            }

            if(tasksToShow.Count == 1 || _page == 0)
            {
                _page = 1;
            }

            tasksPanel.Controls.Clear();

            var controls = tasksPanel.Controls;
            IsLoading = true;

            await Task.Run(() =>
            {
                try
                {
                    foreach (var task in tasksToShow)
                    {
                        var view = new TaskView(task, this)
                        {
                            BackColor = ApplicationStyle.BackgroundColor,
                            ForeColor = ApplicationStyle.TextColor,
                            Dock = DockStyle.Top
                        };

                        while (!tasksPanel.InvokeRequired)
                        {
                            System.Threading.Thread.Sleep(10);
                        }

                        tasksPanel.Invoke((MethodInvoker)delegate
                        {
                            tasksPanel.Controls.Add(view);
                        });
                    }
                }
                catch (Exception e)
                {
                    this.LogException(e);
                    MessageBox.Show($"An error occurred while loading the tasks.\n Error: {e.Message}", "Warning", MessageBoxButtons.OK);
                    IsLoading = false;
                }
            });

            IsLoading = false;
        }

        private void ShowNoTasksLabel()
        {
            var noTasksLabel = new Label
            {
                Text = "No tasks to show",
                AutoSize = false,
                Parent = tasksPanel,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.TopCenter,
                ForeColor = tasksPanel.BackColor.GetContrastColor()
            };

            noTasksLabel.Font = new Font(noTasksLabel.Font.FontFamily, noTasksLabel.Font.Size + 2, FontStyle.Bold);
        }

        public void Select(TaskView taskView)
        {
            if (taskView == null)
            {
                throw new ArgumentNullException(nameof(taskView));
            }

            if (SelectedItem == taskView)
            {
                taskView.Unhighlight();
                SelectedItem = null;
                return;
            }

            if (SelectedItem == null)
            {
                SelectedItem = taskView;
                taskView.Hightlight();
                return;
            }

            SelectedItem.Unhighlight();
            SelectedItem = taskView;
            SelectedItem.Hightlight();
        }
    }
}

