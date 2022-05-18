﻿using Logic.Tasks;
using Logic.Utils;
using NLog;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ToDoApp.Controllers;
using ToDoApp.Forms;

namespace ToDoApp.UI.Controls
{
    public partial class TaskView : UserControl, ILoggable, IDisposable
    {
        private Task _task;
        private readonly TaskController _controller;
        private bool _isActive;

        public bool IsLoggingEnabled { get; set; } = true;
        public Logger Logger => LogManager.GetCurrentClassLogger();
        public Task Task
        {
            get => _task;
            set
            {
                _task = value ?? throw new ArgumentNullException(nameof(value));
                BindValues(value);
            }
        }

        public bool IsActive
        {
            get => _isActive;

            set
            {
                if (value)
                {
                    taskLayout.Controls.OfType<Label>().ToList().ForEach(l => l.Font = new Font(l.Font, FontStyle.Regular));
                    taskLayout.Controls.OfType<Label>().ToList().ForEach(l => l.ForeColor = ApplicationStyle.BackgroundColor.GetContrastColor());
                }
                else
                {
                    taskLayout.Controls.OfType<Label>().ToList().ForEach(l => l.Font = new Font(l.Font, FontStyle.Strikeout | FontStyle.Italic));
                    taskLayout.Controls.OfType<Label>().ToList().ForEach(l => l.ForeColor = Color.Gray);
                }

                _isActive = value;
            }
        }

        public TaskView(Task task, TaskController controller)
        {
            InitializeComponent();

            _controller = controller ?? throw new ArgumentNullException(nameof(controller));

            // causes BindValues()
            Task = task ?? throw new ArgumentNullException(nameof(task));
            ApplyTheme();

            foreach (var control in taskLayout.Controls.Cast<Control>())
            {
                control.MouseClick += taskLayout_MouseClick;
                control.DoubleClick += AllControls_MouseDoubleClick;
            }
            _task.StateChanged += OnStateUpdate;
        }

        private void ApplyTheme()
        {
            if (IsActive)
            {
                if (Task.DeadLine < DateTime.Now)
                {
                    deadlineLabel.ForeColor = Color.Red;
                }
                else
                {
                    deadlineLabel.ForeColor = ApplicationStyle.BackgroundColor.GetContrastColor();
                }
            }
        }

        private void BindValues(Task task)
        {
            try
            {
                nameLabel.Text = task.Name;
                descriptionLabel.Text = task.Description;
                importanceLabel.Text = task.Importance.ToString();
                IsActive = !task.IsCompleted;
                completedCheckBox.Checked = task.IsCompleted;

                if (!task.DeadLine.HasValue)
                {
                    deadlineLabel.Text = "Not set";
                }
                else
                {
                    deadlineLabel.Text = task.DeadLine.Value.ToString("dddd, dd.MM.yyyy HH:mm");
                }
            }
            catch (Exception e)
            {
                this.LogException(e);
            }
        }
        private void taskLayout_MouseClick(object sender, MouseEventArgs e)
        {
            _controller.Select(this);
        }

        private Color savedBackColor;
        private Color savedForeColor;
        public void Unhighlight()
        {
            BackColor = savedBackColor;
            ForeColor = savedForeColor;
        }

        public void Hightlight()
        {
            savedBackColor = BackColor;
            savedForeColor = ForeColor;
            BackColor = GetHightlightColorFor(BackColor);
        }

        private Color GetHightlightColorFor(Color color)
        {
            switch (Properties.Settings.Default.Theme)
            {
                case Themes.Theme.Light:
                    return Color.FromArgb(20, 125, 249, 255);
                case Themes.Theme.Dark:
                    return Color.DarkSlateBlue;
                default:
                    return CalculateHightlightColorFor(color);
            }
        }

        private Color CalculateHightlightColorFor(Color color)
        {
            var red = color.R;
            var green = color.G;
            var blue = color.B;

            var newRed = (int)(red * 0.95);
            var newGreen = (int)(green * 0.95);
            var newBlue = (int)(blue * 0.95);

            return Color.FromArgb(newRed, newGreen, newBlue);
        }

        private void taskLayout_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AllControls_MouseDoubleClick(sender, e);
        }

        private void AllControls_MouseDoubleClick(object sender, EventArgs e)
        {
            new TaskInfoForm(Task).ShowDialog();
            _controller.Select(this);
        }

        private void completedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (completedCheckBox.Checked)
            {
                _task.Complete();
            }
            else
            {
                _task.Uncomplete();
            }
        }

        private void OnStateUpdate(object sender, StateChangedEventArgs args)
        {
            if (sender is Task task)
            {
                BindValues(task);
            }
        }

        public void Rebind()
        {
            BindValues(_task);
        }

        public new void Dispose()
        {
            foreach (var control in taskLayout.Controls)
            {
                ((Control)control).MouseClick -= taskLayout_MouseClick;
                ((Control)control).DoubleClick -= AllControls_MouseDoubleClick;
            }

            _task.StateChanged -= OnStateUpdate;

            base.Dispose();
        }
    }
}
