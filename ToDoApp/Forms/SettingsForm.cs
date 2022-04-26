using System.Windows.Forms;

namespace ToDoApp.Forms
{
    public partial class SettingsForm
    {
        public Control ParentControl { get; }
        public SettingsForm(Control panel)
        {
            ParentControl = panel;
            InitializeComponent();
        }
    }
}