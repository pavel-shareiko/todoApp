using FontAwesome.Sharp;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ToDoApp.Controls;
using ToDoApp.UI;
using ToDoApp.UI.Controls;

namespace ToDoApp.Forms
{
    public partial class TasksForm : UserControl
    {
        public TaskController TaskViewController { get; }
        public TasksForm()
        {
            InitializeComponent();

            TaskViewController = new TaskController(dataViewPanel);
            TaskViewController.LoadTasksAsync();

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
            controls.OfType<IconPictureBox>().ToList().ForEach(x => x.ForeColor = ApplicationStyle.AccentColor);
        }

        private void newButton_Click(object sender, System.EventArgs e)
        {
            new NewTaskForm().ShowDialog();
            TaskViewController.LoadTasksAsync();
        }
        private void editButton_Click(object sender, System.EventArgs e)
        {
            if (TaskViewController.SelectedItem == null)
            {
                return;
            }

            var editTaskForm = new EditTaskForm(TaskViewController.SelectedItem.Task);

            editTaskForm.ShowDialog();
            TaskViewController.LoadTasksAsync();
        }

        private void deleteButton_Click(object sender, System.EventArgs e)
        {
            if (TaskViewController.SelectedItem == null)
            {
                return;
            }

            var dialogResult = MessageBox.Show("Are you sure you want to delete this task?", "Delete Task", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                TaskManager.Diary.RemoveTask(TaskViewController.SelectedItem.Task);
                TaskViewController.LoadTasksAsync();
            }
        }

        private void detailsButton_Click(object sender, System.EventArgs e)
        {
            if (TaskViewController.SelectedItem == null)
            {
                return;
            }

            new TaskInfoForm(TaskViewController.SelectedItem.Task).ShowDialog();
        }

        private void nextPageButton_Click(object sender, System.EventArgs e)
        {
            TaskViewController.Page++;
            UpdatePagesLabel();
        }

        private void prevPageButton_Click(object sender, System.EventArgs e)
        {
            TaskViewController.Page--;
            UpdatePagesLabel();
        }

        private void UpdatePagesLabel()
        {
            pagesLabel.Text = $"Page {TaskViewController.Page} of {TaskViewController.TotalPages}";
        }

    }
}
