﻿using Logic.Utils;
using NLog;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoApp.UI;
using ToDoApp.UI.Controls;
using ToDoApp.UI.UserControls;

namespace ToDoApp.Controls
{
    public class TaskController : ILoggable
    {
        private const int TasksPerPage = 10;
        private readonly Panel tasksPanel;
        private int _page = 1;

        public event EventHandler TasksLoading;
        public event EventHandler<TasksLoadedEventArgs> TasksLoaded;

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

        public async void ReloadTasksAsync(Func<Logic.Tasks.Task, bool> selector = null)
        {
            var tasksToShowTask = TaskManager.GetTasksAsync((Page - 1) * TasksPerPage, TasksPerPage, new TaskComparer(), selector);
            tasksPanel.Controls.Clear();
            var tasksToShow = await tasksToShowTask;

            if (tasksToShow.Count == 0)
            {
                ShowNoTasksLabel();
                return;
            }

            if (_page == 0)
            {
                _page = 1;
            }

            var controls = tasksPanel.Controls;
            OnTasksLoading();

            await Task.Run(() =>
            {
                try
                {
                    // Tasks are being displayed in reversed order, so to display them in the correct order, we iterate the list from the end
                    for (int i = tasksToShow.Count - 1; i >= 0; --i)
                    {
                        var view = new TaskView(tasksToShow[i], this)
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
                    OnTasksLoaded(new TasksLoadedEventArgs(false));
                }
            });

            OnTasksLoaded(new TasksLoadedEventArgs(true));
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
                ForeColor = ApplicationStyle.BackgroundColor.GetContrastColor()
            };

            noTasksLabel.Font = new Font(noTasksLabel.Font.FontFamily, noTasksLabel.Font.Size + 2, FontStyle.Bold);
        }

        #region Events
        private Spinner spinner;
        protected virtual void OnTasksLoading()
        {
            var bgColor = Color.Black;
            spinner = new Spinner()
            {
                BackColor = Color.FromArgb(30, bgColor.R, bgColor.G, bgColor.B),
                Size = tasksPanel.Size,
                Visible = true
            };
            tasksPanel.Controls.Add(spinner);

            IsLoading = true;
            TasksLoading?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnTasksLoaded(TasksLoadedEventArgs args)
        {
            tasksPanel.Controls.Remove(spinner);
            spinner.Visible = false;

            spinner.Dispose();
            spinner = null;


            IsLoading = false;
            TasksLoaded?.Invoke(this, args);
        }
        #endregion
    }
}