using Logic.Tasks;
using System;
using System.Linq;
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
