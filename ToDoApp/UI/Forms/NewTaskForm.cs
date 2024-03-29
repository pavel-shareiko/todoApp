﻿using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;
using ToDoApp.Extensions;
using ToDoApp.Tasks;
using ToDoApp.UI;
using ToDoApp.Utils;

namespace ToDoApp.Forms
{
    public partial class NewTaskForm : Form, ILoggable
    {
        public bool IsLoggingEnabled { get; set; } = true;
        public Logger Logger => LogManager.GetCurrentClassLogger();
        private readonly Task creatingTask;

        public NewTaskForm()
        {
            InitializeComponent();

            creatingTask = new Task();

            taskBindingSource.DataSource = creatingTask;

            var values = Enum.GetValues(typeof(TaskImportance));
            var items = new object[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                items[i] = values.GetValue(i);
            }

            importanceComboBox.Items.AddRange(items);
            importanceComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            deadLineDateTimePicker.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 59);
            deadLineDateTimePicker.MinDate = DateTime.Now;

            ApplyTheme();
        }

        private void ApplyTheme()
        {
            headerLabel.ForeColor = ApplicationStyle.TextColor;
            BackColor = ApplicationStyle.BackgroundColor;

            foreach (var label in contentPanel.Controls.OfType<Label>())
            {
                label.ForeColor = ApplicationStyle.TextColor;
            }

            createButton.BackColor = ApplicationStyle.AccentColor;
            createButton.ForeColor = createButton.BackColor.GetContrastColor();
            createButton.IconColor = createButton.ForeColor;
        }

        private void createButton_Click(object sender, EventArgs e)
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
                creatingTask.DeadLine = null;
            }
            else
            {
                // nullable types winforms bug
                creatingTask.DeadLine = deadLineDateTimePicker.Value;
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

            this.Log(LogLevel.Debug, $"New task has been successfully created. ID: {task.Id}");

            TaskManager.Diary.AddTask(task);
            MessageBox.Show("Task has been successfully created", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            taskBindingSource.Clear();
            System.Threading.Tasks.Task.Run(() => TaskManager.Save());

            Dispose();
            Close();
        }
    }
}
