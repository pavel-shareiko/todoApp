using FontAwesome.Sharp;
using Logic.Tasks;
using System;
using System.Linq;
using System.Windows.Forms;
using ToDoApp.Controls;
using ToDoApp.UI;
using ToDoApp.UI.Controls;

namespace ToDoApp.Forms
{
    public partial class TasksScreen : UserControl, IDisposable
    {
        public TaskController TaskController { get; }
        public TasksScreen()
        {
            InitializeComponent();

            TaskController = new TaskController(tasksDataGridViewPanel);
            TaskController.ReloadTasksAsync();
            TaskController.TasksLoaded += OnTasksLoaded;

            UpdatePagesLabel();
            SetupFilterCms();

            ApplyTheme();
        }

        private void SetupFilterCms()
        {
            resetToolStripMenuItem.Click += (s, e) => TaskController.Filter = null;

            filterToolStripMenuItem.Click += (s, e) => TaskController.ReloadTasksAsync();

            completionStatusToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem("Completed", null, (s, e) => TaskController.Filter += t => t.IsCompleted));
            completionStatusToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem("Not Completed", null, (s, e) => TaskController.Filter = t => !t.IsCompleted));

            deadLineToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem("Due today", null, (s, e) => TaskController.Filter += t => t.DeadLine?.Date <= DateTime.Now.Date));
            deadLineToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem("Due tomorrow", null, (s, e) => TaskController.Filter += t => t.DeadLine?.Date <= DateTime.Now.AddDays(1).Date));
            deadLineToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem("Due this week", null, (s, e) => TaskController.Filter += t => t.DeadLine?.Date <= DateTime.Now.AddDays(7).Date));
            deadLineToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem("Due this month", null, (s, e) => TaskController.Filter += t => t.DeadLine?.Date <= DateTime.Now.AddMonths(1).Date));

            foreach (var importance in Enum.GetValues(typeof(TaskImportance)).Cast<TaskImportance>())
            {
                importanceToolStripMenuItem.DropDownItems.Add(new ToolStripMenuItem(importance.ToString(), null, (s, e) => TaskController.Filter += t => t.Importance == importance));
            }
        }

        private void ApplyTheme()
        {
            var controls = this.Controls.OfType<Panel>().SelectMany(x => x.Controls.OfType<Control>());

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
            new NewTaskScreen().ShowDialog();
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
            TaskController.Page++;
            UpdatePagesLabel();
        }

        private void prevPageButton_Click(object sender, System.EventArgs e)
        {
            TaskController.Page--;
            UpdatePagesLabel();
        }

        private void UpdatePagesLabel()
        {
            pagesLabel.Text = $"Page {TaskController.Page} of {TaskController.TotalPages}";
        }

        private void OnTasksLoaded(object sender, TasksLoadedEventArgs args)
        {
            UpdatePagesLabel();
        }

        public new void Dispose()
        {
            TaskController.TasksLoaded -= OnTasksLoaded;
            base.Dispose();
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            TaskController.ReloadTasksAsync();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            filterButton.ContextMenuStrip?.Show(filterButton, new System.Drawing.Point(filterButton.Width / 2, filterButton.Height / 2));
        }
    }
}
