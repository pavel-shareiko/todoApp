using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ToDoApp.Controls;

namespace ToDoApp.UI.Forms
{
    public partial class HomeScreen : UserControl
    {
        public TaskController AllTasksController { get; }
        public TaskController UpcomingTasksController { get; }
        private string username;
        public HomeScreen()
        {
            InitializeComponent();
            ApplyTheme();

            username = Environment.UserName;
            UpcomingTasksController = new TaskController(upcomingTasksPanel, true,
                task => !task.IsCompleted &&
                task.DeadLine.HasValue &&
                task.DeadLine.Value.Date <= DateTime.Today.Date.AddDays(7));

            AllTasksController = new TaskController(allTasksPanel, true, task => task.IsCompleted == false);

            UpdateGreetingsLabel();

            AllTasksController.ReloadTasksAsync();
            UpcomingTasksController.ReloadTasksAsync();
        }

        private void ApplyThemeForPanel(Panel panel)
        {
            panel.BackColor = ApplicationStyle.BackgroundColor;
            var controls = panel.Controls.Cast<Control>();

            controls.OfType<Label>().ToList().ForEach(x => x.ForeColor = ApplicationStyle.TextColor);
            controls.OfType<Button>().ToList().ForEach(x =>
            {
                x.BackColor = ApplicationStyle.AccentColor;
                x.ForeColor = x.BackColor.GetContrastColor();
            });
        }

        private void ApplyTheme()
        {
            ApplyThemeForPanel(upcomingTasksPanel);
            ApplyThemeForPanel(allTasksPanel);
            ApplyThemeForPanel(headerPanel);
            ApplyThemeForPanel(contentPanel);
            ApplyThemeForPanel(greetingsPanel);

            allTasksGroupBox.ForeColor = ApplicationStyle.BackgroundColor.GetContrastColor();
            upcomingTasksGroupBox.ForeColor = ApplicationStyle.BackgroundColor.GetContrastColor();
        }

        private void UpdateGreetingsLabel()
        {
            var tasksCount = UpcomingTasksController.GetTasksCount(t => !t.IsCompleted);

            if (tasksCount > 0)
                greetingsLabel.Text = $"Hi, {username}! You have {tasksCount} task(s) to do!";
            else
                greetingsLabel.Text = $"Hi, {username}! There is no work for you at the moment, you can take a rest! :)";
        }
    }
}
