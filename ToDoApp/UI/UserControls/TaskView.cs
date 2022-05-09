using Logic.Tasks;
using Logic.Utils;
using NLog;
using System;
using System.Drawing;
using System.Windows.Forms;
using ToDoApp.Controls;
using ToDoApp.Forms;

namespace ToDoApp.UI.Controls
{
    public partial class TaskView : UserControl, ILoggable
    {
        private Task _task;
        private readonly TaskController controller;

        public bool IsLoggingEnabled { get; set; } = true;
        public Logger Logger => LogManager.GetCurrentClassLogger();
        public Task Task
        {
            get => _task;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                _task = value;
                BindValues(value);
            }
        }

        public TaskView(Task task, TaskController controller)
        {
            InitializeComponent();

            this.Task = task ?? throw new ArgumentNullException(nameof(task));
            this.controller = controller ?? throw new ArgumentNullException(nameof(controller));

            foreach (var control in taskLayout.Controls)
            {
                ((Control)control).MouseClick += taskLayout_MouseClick;
                ((Control)control).DoubleClick += AllControls_MouseDoubleClick;
            }
        }

        private void BindValues(Task task)
        {
            try
            {
                this.nameLabel.Text = task.Name;
                this.descriptionLabel.Text = task.Description;
                this.importanceLabel.Text = task.Importance.ToString();
                this.createdOnLabel.Text = task.CreationDate.ToString();

                if (!task.DeadLine.HasValue)
                {
                    this.deadlineLabel.Text = "Not set";
                }
                else
                {
                    this.deadlineLabel.Text = task.DeadLine.Value.ToString();
                }
            }
            catch (Exception e)
            {
                this.LogException(e);
            }
        }
        private void taskLayout_MouseClick(object sender, MouseEventArgs e)
        {
            controller.Select(this);
        }

        private Color savedBackColor;
        private Color savedForeColor;
        public void Unhighlight()
        {
            this.BackColor = savedBackColor;
            this.ForeColor = savedForeColor;
        }

        public void Hightlight()
        {
            savedBackColor = this.BackColor;
            savedForeColor = this.ForeColor;
            this.BackColor = GetHightlightColorFor(BackColor);
        }

        private Color GetHightlightColorFor(Color color)
        {
            switch (Properties.Settings.Default.Theme)
            {
                case Themes.Theme.Light:
                    return Color.AliceBlue;
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
            new TaskInfoForm(this.Task).ShowDialog();
            controller.Select(this);
        }
    }
}
