using Logic.Tasks;
using Logic.Utils;
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;
using ToDoApp.UI;
using ToDoApp.UI.Controls;

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
            deadLineDateTimePicker.MinDate = DateTime.Now;
            importanceComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            ApplyTheme();
        }

        private void ApplyTheme()
        {
            var panels = this.Controls.OfType<Panel>().ToList();

            panels.ForEach(p => p.BackColor = ApplicationStyle.BackgroundColor);

            panels.ForEach(p => p.Controls.OfType<Label>().ToList()
                .ForEach(l => l.ForeColor = ApplicationStyle.TextColor));

            panels.ForEach(p => p.Controls.OfType<RoundButton>().ToList()
                .ForEach(b =>
                {
                    b.BackColor = ApplicationStyle.AccentColor;
                    b.ForeColor = b.BackColor.GetContrastColor();
                }));
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            taskBindingSource.EndEdit();

            if (!(taskBindingSource.Current is Task task))
            {
                this.Log(LogLevel.Info, "Create button has been clicked, but current task is null");
                return;
            }

            var context = new ValidationContext(task, null, null);
            var errors = new List<ValidationResult>();

            if (!deadLineDateTimePicker.Checked)
            {
                _currentTask.DeadLine = null;
            }

            if (!Validator.TryValidateObject(task, context, errors, true))
            {
                foreach (ValidationResult result in errors)
                {
                    this.Log(LogLevel.Info, $"Validation failed: {result.ErrorMessage}");
                    MessageBox.Show(result.ErrorMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return;
            }

            this.Log(LogLevel.Debug, "Validation succeeded");
            _currentTask.CopyTo(_originTask);

            MessageBox.Show("Task has been successfully updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            taskBindingSource.Clear();
            Dispose();
            Close();
        }
    }
}
