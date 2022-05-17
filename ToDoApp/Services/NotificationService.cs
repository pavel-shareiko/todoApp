using Humanizer;
using Logic.Tasks;
using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Windows;
using ToDoApp.Forms;

namespace ToDoApp.Services
{
    // The class that should iterate over every task periodically.
    // And notifies the user if the deadline of the task is approaching.
    // Scan period and notification period are configurable.
    // Class shouldn't send notifications for the same task twice.
    public class NotificationService
    {
        private readonly List<Task> _alreadyNotified = new List<Task>();
        private Timer _timer;
        private static NotificationService _instance;
        public static NotificationService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new NotificationService();
                }
                return _instance;
            }
        }

        private NotificationService()
        {
            ToastNotificationManagerCompat.OnActivated += OnNotificationClicked;
        }

        public void Start()
        {
            _timer = new Timer(CheckDeadlinesAsync, null, 5000, Properties.Settings.Default.ScanPeriod);
        }

        public void Stop()
        {
            if (_timer != null)
            {
                _timer.Dispose();
                _timer = null;
            }
        }

        private async void CheckDeadlinesAsync(object state)
        {
            var tasks = await TaskManager.GetTasksAsync(0, int.MaxValue,
                selector: task => task.DeadLine != null &&
                          task.DeadLine.Value > DateTime.Now &&
                          !_alreadyNotified.Contains(task));

            int notifyBefore = Properties.Settings.Default.NotifyBefore;
            foreach (var task in tasks)
            {
                if (DateTime.Now.Subtract(task.DeadLine.Value).TotalHours <= notifyBefore)
                {
                    Notify(task);
                }
            }
        }

        private void Notify(Task task)
        {
            var deadlineHumanized = (task.DeadLine.Value - DateTime.Now).Humanize(
                maxUnit: Humanizer.Localisation.TimeUnit.Week,
                minUnit: Humanizer.Localisation.TimeUnit.Second,
                culture: new System.Globalization.CultureInfo("en-EN"));

            new ToastContentBuilder()
                .AddText($"Don't miss the '{task.Name.Humanize()}' task deadline!")
                .AddText($"The deadline is in {deadlineHumanized}")

                .AddArgument("task", task.Id.ToString())

                .AddButton(new ToastButton()
                    .SetContent("OK")
                    .AddArgument("dontShowInfo")
                    .SetBackgroundActivation())
                .AddButton(new ToastButton()
                    .SetContent("Details")
                    .SetBackgroundActivation())

                .SetToastScenario(ToastScenario.Alarm)

                .Show(toast => toast.ExpirationTime = task.DeadLine.Value);

            lock (_alreadyNotified)
                _alreadyNotified.Add(task);
        }

        private void OnNotificationClicked(ToastNotificationActivatedEventArgsCompat e)
        {
            if (e.Argument.Contains("dontShowInfo"))
            {
                return;
            }

            ToastArguments args = ToastArguments.Parse(e.Argument);
            var hasValue = args.TryGetValue("task", out var taskIdString);
            if (!hasValue)
            {
                return;
            }

            var taskId = Guid.Parse(taskIdString);

            var task = TaskManager.GetTaskById(taskId);
            if (task == null)
            {
                return;
            }

            new TaskInfoForm(task).ShowDialog();
        }
    }
}
