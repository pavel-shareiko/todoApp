﻿using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ToDoApp.Controllers;
using ToDoApp.Extensions;
using ToDoApp.Tasks;

namespace ToDoApp.UI.Forms
{
    public partial class HomeUserControl : UserControl
    {
        public TaskController AllTasksController { get; }
        public TaskController UpcomingTasksController { get; }
        public HomeUserControl()
        {
            InitializeComponent();
            ApplyTheme();
            UpcomingTasksController = new TaskController(upcomingTasksPanel,
                task => !task.IsCompleted &&
                task.DeadLine.HasValue &&
                task.DeadLine.Value.Date <= DateTime.Today.Date.AddDays(7));

            AllTasksController = new TaskController(allTasksPanel, task => !task.IsCompleted);

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
            ApplyThemeForPanel(controlsPanel);

            allTasksGroupBox.ForeColor = ApplicationStyle.BackgroundColor.GetContrastColor();
            upcomingTasksGroupBox.ForeColor = ApplicationStyle.BackgroundColor.GetContrastColor();
        }

        private void UpdateGreetingsLabel()
        {
            var tasksCount = TaskManager.GetTasksCount(t => !t.IsCompleted);

            if (tasksCount > 0)
            {
                greetingsLabel.Text = $"Hi, {Environment.UserName}! You have {tasksCount} task(s) to do!";
            }
            else
            {
                greetingsLabel.Text = $"Hi, {Environment.UserName}! There is no work for you at the moment, you can take a rest! :)";
            }
        }

        private void OnReloadButtonClicked(object sender, EventArgs e)
        {
            UpdateGreetingsLabel();
            AllTasksController.ReloadTasksAsync();
            UpcomingTasksController.ReloadTasksAsync();
        }
    }
}
