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
            var panels = this.Controls.OfType<Panel>().ToList();

            panels.ForEach(p => p.BackColor = ApplicationStyle.BackgroundColor);

            panels.ForEach(p => p.Controls.OfType<Label>().ToList()
                .ForEach(l => l.ForeColor = ApplicationStyle.TextColor));

            panels.ForEach(p => p.Controls.OfType<Button>().ToList()
                .ForEach(b =>
                {
                    b.BackColor = ApplicationStyle.AccentColor;
                    b.ForeColor = b.BackColor.GetContrastColor();
                }));

            panels.ForEach(p => p.Controls.OfType<RichTextBox>().ToList()
                .ForEach(b =>
                {
                    b.BackColor = ApplicationStyle.BackgroundColor;
                    b.ForeColor = b.BackColor.GetContrastColor();
                }));
        }
    }
}
