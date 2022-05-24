using FontAwesome.Sharp;
using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ToDoApp.Controllers;
using ToDoApp.Extensions;
using ToDoApp.Other;
using ToDoApp.Tasks;
using ToDoApp.UI;
using ToDoApp.UI.Controls;

namespace ToDoApp.Forms
{
    public partial class TasksUserControl : UserControl, IDisposable
    {
        public TaskController TaskController { get; }
        public PageController PageController { get; }
        public TasksUserControl()
        {
            InitializeComponent();

            TaskController = new TaskController(tasksDataGridViewPanel);
            TaskController.ReloadTasksAsync();
            TaskController.TasksLoaded += OnTasksLoaded;

            PageController = new PageController(TaskController, pagesLabel);

            SetupFilterCms();

            ApplyTheme();
        }

        private FilterBuilder filterBuilder;
        private void SetupFilterCms()
        {
            filterBuilder = new FilterBuilder(TaskController);
            resetToolStripMenuItem.Click += (s, e) =>
            {
                filterBuilder.Reset();
                TaskController.Filter = null;
                TaskController.ReloadTasksAsync();
            };

            filterToolStripMenuItem.Click += (s, e) =>
            {
                var filter = filterBuilder.Build();
                TaskController.Filter = filter;
                TaskController.ReloadTasksAsync();
            };

            currentFilterToolStripMenuItem.Click += (s, e) => MessageBox.Show(filterBuilder.ToString(), "Info");

            completionStatusToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem("All", null,
                (s, e) => filterBuilder.RemoveConditionGroup("Status")));
            completionStatusToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem("Completed", null,
                (s, e) => filterBuilder.AddCondition("Status", t => t.IsCompleted, "Task is completed")));
            completionStatusToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem("Not Completed", null,
                (s, e) => filterBuilder.AddCondition("Status", t => !t.IsCompleted, "Task is not completed")));

            deadLineToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem("All", null,
                (s, e) => filterBuilder.RemoveConditionGroup("DeadLine")));
            deadLineToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem("Not set", null,
                (s, e) => filterBuilder.AddCondition("DeadLine", t => !t.DeadLine.HasValue, "Task has no deadline")));
            deadLineToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem("Set", null,
                (s, e) => filterBuilder.AddCondition("DeadLine", t => t.DeadLine.HasValue, "Task has a deadline")));
            deadLineToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem("Overdue", null,
                (s, e) => filterBuilder.AddCondition("DeadLine", t => t.DeadLine.HasValue && t.DeadLine.Value < DateTime.Now, "Task overdue")));
            deadLineToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem("Due Today", null,
                (s, e) => filterBuilder.AddCondition("DeadLine", t => t.DeadLine?.Date <= DateTime.Today, "Task is due today")));
            deadLineToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem("Due Tomorrow", null,
                (s, e) => filterBuilder.AddCondition("DeadLine", t => t.DeadLine?.Date <= DateTime.Today.AddDays(1), "Task is due tomorrow")));
            deadLineToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem("Due this week", null,
                (s, e) => filterBuilder.AddCondition("DeadLine", t => t.DeadLine?.Date <= DateTime.Today.AddDays(7), "Task is due this week")));
            deadLineToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem("Due this month", null,
                (s, e) => filterBuilder.AddCondition("DeadLine", t => t.DeadLine?.Date <= DateTime.Today.AddDays(30), "Task is due this month")));

            importanceToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem("All", null,
                (s, e) => filterBuilder.RemoveConditionGroup("Importance")));
            foreach (var importnace in Enum.GetValues(typeof(TaskImportance)).Cast<TaskImportance>())
            {
                importanceToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem(importnace.Humanize(), null,
                    (s, e) => filterBuilder.AddCondition("Importance", t => t.Importance == importnace, "Task importance is " + importnace.Humanize())));
            }
        }

        private void ApplyTheme()
        {
            var controls = Controls.OfType<Panel>().SelectMany(x => x.Controls.OfType<Control>());

            controls.OfType<Label>().ToList().ForEach(x => x.ForeColor = ApplicationStyle.TextColor);
            controls.OfType<RoundButton>().ToList().ForEach(x =>
            {
                x.BackColor = ApplicationStyle.AccentColor;
                x.ForeColor = x.BackColor.GetContrastColor();
                x.IconColor = x.ForeColor;
            });

            pagesLabel.ForeColor = ApplicationStyle.BackgroundColor.GetContrastColor();

            taskLayoutHeaders.Controls.OfType<Label>().ToList().ForEach(x => x.ForeColor = ApplicationStyle.BackgroundColor.GetContrastColor());
            tasksDataGridViewPanel.BackColor = ApplicationStyle.BackgroundColor;

            paginationPanel.Controls.OfType<IconPictureBox>().ToList().ForEach(x => x.IconColor = ApplicationStyle.AccentColor);
        }

        private void newButton_Click(object sender, System.EventArgs e)
        {
            new NewTaskForm().ShowDialog();
            TaskController.ReloadTasksAsync();
        }
        private void editButton_Click(object sender, System.EventArgs e)
        {
            if (TaskController.SelectedItem == null)
            {
                return;
            }

            var editTaskForm = new EditTaskForm(TaskController.SelectedItem.Task);

            editTaskForm.ShowDialog();
            TaskController.ReloadTasksAsync();
        }

        private void deleteButton_Click(object sender, System.EventArgs e)
        {
            if (TaskController.SelectedItem == null)
            {
                return;
            }

            var dialogResult = MessageBox.Show("Are you sure you want to delete this task?", "Delete Task", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                TaskController.Delete(TaskController.SelectedItem);
            }
        }

        private void detailsButton_Click(object sender, System.EventArgs e)
        {
            if (TaskController.SelectedItem == null)
            {
                return;
            }

            new TaskInfoForm(TaskController.SelectedItem.Task).ShowDialog();
        }

        private void nextPageButton_Click(object sender, System.EventArgs e)
        {
            PageController.IncreasePage();
        }

        private void prevPageButton_Click(object sender, System.EventArgs e)
        {
            PageController.DecreasePage();
        }

        private void OnTasksLoaded(object sender, TasksLoadedEventArgs args)
        {
            PageController.UpdatePageControl();
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            TaskController.ReloadTasksAsync();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            filterButton.ContextMenuStrip?.Show(filterButton, new System.Drawing.Point(filterButton.Width / 2, filterButton.Height / 2));
        }

        public new void Dispose()
        {
            TaskController.TasksLoaded -= OnTasksLoaded;
            base.Dispose();
        }

        private class FilterBuilder
        {
            private readonly Dictionary<string, (Func<Task, bool> Condition, string Description)> conditions = new Dictionary<string, (Func<Task, bool>, string)>(StringComparer.OrdinalIgnoreCase);
            private readonly TaskController _controller;

            public FilterBuilder(TaskController controller)
            {
                _controller = controller;
            }

            public void AddCondition(string group, Func<Task, bool> condition, string description, bool autoApply = true)
            {
                if (conditions.ContainsKey(group))
                {
                    conditions[group] = (condition, description);
                }
                else
                {
                    conditions.Add(group, (condition, description));
                }

                if (autoApply)
                {
                    ApplyFilter();
                }
            }

            private void ApplyFilter()
            {
                _controller.Filter = Build();
                _controller.ReloadTasksAsync();
            }

            public Func<Task, bool> Build()
            {
                var conditions = this.conditions.Values.Select(x => x.Condition).ToArray();
                return (task) => conditions.All(x => x(task));
            }

            public void Reset()
            {
                conditions?.Clear();
            }

            public void RemoveConditionGroup(string group, bool autoApply = true)
            {
                conditions.Remove(group);
                if (autoApply)
                {
                    ApplyFilter();
                }
            }

            public override string ToString()
            {
                if (conditions == null)
                {
                    return "No filter criteria are set";
                }

                if (conditions.Count == 0)
                {
                    return "No filter criteria are set";
                }

                return string.Join("\n", conditions.Select(x => x.Value.Description));
            }
        }
    }
}