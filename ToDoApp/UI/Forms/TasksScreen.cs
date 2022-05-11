using FontAwesome.Sharp;
using System;
using System.Linq;
using System.Windows.Forms;
using ToDoApp.Controls;
using ToDoApp.UI;


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

            ApplyTheme();
        }

        private void ApplyTheme()
        {
            var controls = this.Controls.OfType<Panel>().SelectMany(x => x.Controls.OfType<Control>());

            controls.OfType<Label>().ToList().ForEach(x => x.ForeColor = ApplicationStyle.TextColor);
            controls.OfType<Button>().ToList().ForEach(x =>
            {
                x.BackColor = ApplicationStyle.AccentColor;
                x.ForeColor = x.BackColor.GetContrastColor();
            });
            controls.OfType<IconPictureBox>().ToList().ForEach(x => x.IconColor = ApplicationStyle.AccentColor);

            pagesLabel.ForeColor = ApplicationStyle.BackgroundColor.GetContrastColor();

            taskLayoutHeaders.Controls.OfType<Label>().ToList().ForEach(x => x.ForeColor = ApplicationStyle.BackgroundColor.GetContrastColor());
            tasksDataGridViewPanel.BackColor = ApplicationStyle.BackgroundColor;
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
    }
}
