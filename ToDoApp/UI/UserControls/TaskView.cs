using Logic.Tasks;
using Logic.Utils;
using NLog;
using System;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ToDoApp.Controls;
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

        private Color _tmpColor;
        public bool IsActive
        {
            get => _isActive;

            set
            {
                if (value)
                {
                    this.taskLayout.Controls.OfType<Label>().ToList().ForEach(l => l.Font = new Font(l.Font, FontStyle.Regular));
                    this.taskLayout.Controls.OfType<Label>().ToList().ForEach(l => l.ForeColor = _tmpColor);
                }
                else
                {
                    _tmpColor = ForeColor;
                    this.taskLayout.Controls.OfType<Label>().ToList().ForEach(l => l.Font = new Font(l.Font, FontStyle.Strikeout | FontStyle.Italic));
                    this.taskLayout.Controls.OfType<Label>().ToList().ForEach(l => l.ForeColor = Color.Gray);
                }

                _isActive = value;
            }
        }

        public TaskView(Task task, TaskController controller)
        {
            InitializeComponent();

            this.Task = task ?? throw new ArgumentNullException(nameof(task));
            this._controller = controller ?? throw new ArgumentNullException(nameof(controller));
            this.IsActive = !task.IsCompleted;
            this.completedCheckBox.Checked = task.IsCompleted;

            foreach (var control in taskLayout.Controls)
            {
                ((Control)control).MouseClick += taskLayout_MouseClick;
                ((Control)control).DoubleClick += AllControls_MouseDoubleClick;
            }
            _task.StateChanged += OnStateUpdate;
        }

        private void BindValues(Task task)
        {
            try
            {
                this.nameLabel.Text = task.Name;
                this.descriptionLabel.Text = task.Description;
                this.importanceLabel.Text = task.Importance.ToString();
                this.IsActive = !task.IsCompleted;
                this.completedCheckBox.Checked = task.IsCompleted;

                if (!task.DeadLine.HasValue)
                {
                    this.deadlineLabel.Text = "Not set";
                }
                else
                {
                    this.deadlineLabel.Text = task.DeadLine.Value.ToString("ddddd, dd MMMM, yyyy");
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
            _controller.Select(this);
        }

        private void completedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.completedCheckBox.Checked)
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
                BindValues(task);
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
