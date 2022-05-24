using NLog;
using System;
using System.Linq;
using System.Windows.Forms;
using ToDoApp.Controllers;
using ToDoApp.Extensions;
using ToDoApp.UI;
using ToDoApp.Utils;

namespace ToDoApp.Forms
{
    public partial class SettingsUserControl : UserControl, ILoggable
    {
        public bool IsLoggingEnabled { get; set; } = true;
        public Logger Logger => LogManager.GetCurrentClassLogger();

        private readonly SettingsController settingsController;

        public SettingsUserControl()
        {
            InitializeComponent();

            themeSelector.SelectedItem = Properties.Settings.Default.Theme;
            notifyBeforeNumUD.Text = Properties.Settings.Default.NotifyBefore.ToString();
            scanPeriodNumUD.Text = (Properties.Settings.Default.ScanPeriod / 1000D).ToString();
            pageSizeNumUD.Text = Properties.Settings.Default.PageSize.ToString();

            settingsController = new SettingsController(themeSelector, scanPeriodNumUD, pageSizeNumUD, notifyBeforeNumUD);
            notifyBeforeNumUD.ValueChanged += settingsController.OnNotifyBeforeValueChanged;
            scanPeriodNumUD.ValueChanged += settingsController.OnScanPeriodValueChanged;
            pageSizeNumUD.ValueChanged += settingsController.OnPageSizeValueChanged;
            themeSelector.SelectionChangeCommitted += settingsController.OnThemeControlSelectionCommitted;

            ApplyTheme();
        }

        private void ApplyTheme()
        {
            var controls = Controls.OfType<Panel>().SelectMany(x => x.Controls.OfType<Control>());

            controls.OfType<Label>().ToList().ForEach(x => x.ForeColor = ApplicationStyle.BackgroundColor.GetContrastColor());
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            settingsController.SaveChanges();
        }

        public new void Dispose()
        {
            notifyBeforeNumUD.ValueChanged -= settingsController.OnNotifyBeforeValueChanged;
            scanPeriodNumUD.ValueChanged -= settingsController.OnScanPeriodValueChanged;
            pageSizeNumUD.ValueChanged -= settingsController.OnPageSizeValueChanged;
            themeSelector.SelectionChangeCommitted -= settingsController.OnThemeControlSelectionCommitted;

            base.Dispose();
        }
    }
}
