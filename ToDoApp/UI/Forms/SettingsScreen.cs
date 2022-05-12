using Logic.Utils;
using NLog;
using System;
using System.Windows.Forms;
using ToDoApp.UI;
using ToDoApp.UI.Themes;

namespace ToDoApp.Forms
{
    public partial class SettingsScreen : UserControl, ILoggable
    {
        public bool IsLoggingEnabled { get; set; } = true;
        public Logger Logger => LogManager.GetCurrentClassLogger();

        private readonly SettingUpdateCollection _updates = new SettingUpdateCollection();

        public SettingsScreen()
        {
            InitializeComponent();

            themeSelector.SelectedItem = Properties.Settings.Default.Theme;

            ApplyTheme();
        }

        private void ApplyTheme()
        {
            headerLabel.ForeColor = ApplicationStyle.TextColor;
            themeLabel.ForeColor = ApplicationStyle.TextColor;

            saveButton.BackColor = ApplicationStyle.AccentColor;
            saveButton.ForeColor = saveButton.BackColor.GetContrastColor();
            saveButton.IconColor = saveButton.ForeColor;
        }

        #region Event handlers
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (_updates.Count == 0)
            {
                this.Log(LogLevel.Debug, "Save button has been clicked, but no changes have been made.");
                return;
            }

            SaveChanges();
        }

        private void themeSelector_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                this.Log(LogLevel.Debug, $"Selected theme: {themeSelector.SelectedItem}, Current theme: {Properties.Settings.Default.Theme}");
                var newTheme = (Theme)themeSelector.SelectedItem;

                if (!Enum.IsDefined(typeof(Theme), newTheme))
                {
                    throw new ArgumentException($"{newTheme} is not a valid theme");
                }

                var settingUpdate = new SettingUpdate(themeSelector,
                    Properties.Settings.Default.Theme,
                    newTheme,
                    () => Properties.Settings.Default.Theme = newTheme);

                _updates.Add(settingUpdate);
            }
            catch (Exception ex)
            {
                this.LogException(ex);
            }
        }
        #endregion

        private void SaveChanges()
        {
            try
            {
                foreach (var update in _updates)
                {
                    update.Save();
                    this.Log(LogLevel.Debug, $"{update.OldValue} -> {update.NewValue}");
                }

                Properties.Settings.Default.Save();
            }
            catch (Exception ex)
            {
                this.LogException(ex);
                MessageBox.Show("An error occured while saving your changes.", "Error!");
                return;
            }

            this.Log(LogLevel.Debug, $"{_updates.Count} changes were found. Settings have been successfully updated");
            _updates.Clear();

            var result = MessageBox.Show(
                "Your changes have been successfully saved! New settings will be applied after the application restart. Restart now?",
                "Success!",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }
    }

}
