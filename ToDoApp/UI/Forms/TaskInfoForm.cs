using Humanizer;
using Logic.Attributes;
using Logic.Tasks;
using System;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using ToDoApp.UI;

namespace ToDoApp.Forms
{
    public partial class TaskInfoForm : Form
    {
        public TaskInfoForm(Task task)
        {
            if (task == null)
            {
                throw new ArgumentNullException(nameof(task));
            }

            InitializeComponent();
            taskBindingSource.DataSource = task;
            AutoScroll = true;
            BackColor = ApplicationStyle.BackgroundColor;
            infoPanel.BackColor = ApplicationStyle.BackgroundColor;
            infoPanel.Padding = new Padding(10);

            ApplyTheme();
            ShowInfo();
        }

        private void ShowInfo()
        {
            var task = taskBindingSource.Current as Task;
            if (task == null)
            {
                return;
            }

            var properties = task.GetType()
                .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .OrderByDescending(prop => prop.GetCustomAttribute<OrderAttribute>()?.Order ?? int.MaxValue);
            var index = 0;

            foreach (var property in properties)
            {
                if (!property.CanRead)
                {
                    continue;
                }

                if (!IsPropertyVisible(property, task))
                {
                    continue;
                }

                var label = GetLabelForString(property.Name.Humanize());
                var value = GetLabelForString(property.GetValue(task)?.ToString() ?? "Not set");

                var splitContainer = new SplitContainer
                {
                    Dock = DockStyle.Top,
                    Height = Math.Max(label.Height, value.Height),
                    IsSplitterFixed = true,
                    BorderStyle = BorderStyle.None,
                    SplitterWidth = 1
                };

                splitContainer.SplitterDistance = splitContainer.Width / 3;
                splitContainer.Panel1.Controls.Add(label);
                splitContainer.Panel2.Controls.Add(value);

                infoPanel.Controls.Add(splitContainer);
                index++;
            }
        }

        private bool IsPropertyVisible(PropertyInfo property, object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException();
            }

            if (property.GetCustomAttribute<HiddenAttribute>() != null)
            {
                return false;
            }

            var dependsOnAttribute = property.GetCustomAttribute<DependsOnAttribute>();
            if (dependsOnAttribute != null)
            {
                var dependsOnProperty = obj.GetType().GetProperty(dependsOnAttribute.DependsOn);
                if (dependsOnProperty == null)
                {
                    return true;
                }

                var dependsOnValue = dependsOnProperty.GetValue(obj);
                if (dependsOnValue == null)
                {
                    return false;
                }

                if (dependsOnValue is bool boolValue)
                {
                    return boolValue;
                }

                if (dependsOnValue is string stringValue)
                {
                    return !string.IsNullOrEmpty(stringValue);
                }
            }

            return true;
        }

        private Label GetLabelForString(string s)
        {
            var value = new Label
            {
                Text = s,
                Dock = DockStyle.Top,
                AutoSize = false,
                Width = 495,
                Font = ApplicationStyle.Font,
                ForeColor = ApplicationStyle.BackgroundColor.GetContrastColor(),
            };

            value.Size = value.GetPreferredSize(new Size(value.Width, 0));
            return value;
        }

        private void ApplyTheme()
        {
            var panels = Controls.OfType<Panel>();

            panels.ToList().ForEach(p => p.BackColor = ApplicationStyle.BackgroundColor);

            var controls = panels.SelectMany(x => x.Controls.OfType<Control>());

            controls.OfType<Label>().ToList().ForEach(x => x.ForeColor = ApplicationStyle.TextColor);
            controls.OfType<Button>().ToList().ForEach(x =>
            {
                x.BackColor = ApplicationStyle.AccentColor;
                x.ForeColor = x.BackColor.GetContrastColor();
            });
            controls.OfType<RichTextBox>().ToList().ForEach(x =>
            {
                x.BackColor = ApplicationStyle.BackgroundColor;
                x.ForeColor = x.BackColor.GetContrastColor();
            });
        }

        private void descriptionTextBox_Enter(object sender, EventArgs e)
        {
            ActiveControl = null;
        }
    }
}
