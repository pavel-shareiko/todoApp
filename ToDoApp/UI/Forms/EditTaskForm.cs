using Logic.Tasks;
using Logic.Utils;
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;
using ToDoApp.UI;

namespace ToDoApp.Forms
{
    public partial class EditTaskForm : Form, ILoggable
    {
        private Task _originTask;
        private Task _currentTask;

        public bool IsLoggingEnabled { get; set; }
        public Logger Logger => LogManager.GetCurrentClassLogger();

        public EditTaskForm(Task task)
        {
            if (task == null)
            {
                throw new ArgumentNullException(nameof(task));
            }
            _originTask = task;

            _currentTask = new Task(_originTask);

            InitializeComponent();

            importanceComboBox.DataSource = Enum.GetValues(typeof(TaskImportance));

            taskBindingSource.DataSource = _currentTask;
            deadLineDateTimePicker.MinDate = DateTime.Now.Date;
            importanceComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            deadLineDateTimePicker.Checked = task.DeadLine.HasValue;

            ApplyTheme();
        }

        private void ApplyTheme()
        {
            var panels = this.Controls.OfType<Panel>();

            panels.ToList().ForEach(p => p.BackColor = ApplicationStyle.BackgroundColor);

            var controls = panels.SelectMany(x => x.Controls.OfType<Control>());

            controls.OfType<Label>().ToList().ForEach(x => x.ForeColor = ApplicationStyle.TextColor);
            controls.OfType<Button>().ToList().ForEach(x =>
            {
                x.BackColor = ApplicationStyle.AccentColor;
                x.ForeColor = x.BackColor.GetContrastColor();
            });
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            taskBindingSource.EndEdit();

            if (!(taskBindingSource.Current is Task))
            {
                this.Log(LogLevel.Info, "Create button has been clicked, but current task is null");
                return;
            }

            var context = new ValidationContext(_currentTask, null, null);
            var errors = new List<ValidationResult>();

            if (!deadLineDateTimePicker.Checked)
            {
                _currentTask.DeadLine = null;
            }

            if (!Validator.TryValidateObject(_currentTask, context, errors, true))
            {
                foreach (ValidationResult result in errors)
                {
                    this.Log(LogLevel.Info, $"Validation failed: {result.ErrorMessage}");
                    MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return;
            }

            this.Log(LogLevel.Debug, "Validation succeeded");
            _currentTask.CopyTo(ref _originTask);

            MessageBox.Show("Task has been successfully updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            taskBindingSource.Clear();
            Dispose();
            Close();
        }
    }
}
