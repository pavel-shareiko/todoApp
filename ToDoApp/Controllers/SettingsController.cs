using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ToDoApp.UI.Themes;
using ToDoApp.Utils;

namespace ToDoApp.Controllers
{
    public class SettingsController : ILoggable
    {
        public ComboBox ThemeComboBox { get; }
        public NumericUpDown ScanPeriodControl { get; }
        public NumericUpDown PageSizeControl { get; }
        public NumericUpDown NotifyBeforeControl { get; }

        public bool IsLoggingEnabled { get; set; } = true;
        public Logger Logger => LogManager.GetCurrentClassLogger();

        private readonly SettingUpdateCollection _updates = new SettingUpdateCollection();

        public SettingsController(ComboBox themeComboBox, NumericUpDown scanPeriodNud, NumericUpDown pageSizeNud, NumericUpDown notifyBeforeNud)
        {
            ThemeComboBox = themeComboBox;
            ScanPeriodControl = scanPeriodNud;
            PageSizeControl = pageSizeNud;
            NotifyBeforeControl = notifyBeforeNud;
        }

        public void OnThemeControlSelectionCommitted(object sender, EventArgs e)
        {
            try
            {
                this.Log(LogLevel.Debug, $"Selected theme: {ThemeComboBox.SelectedItem}, Current theme: {Properties.Settings.Default.Theme}");
                var newTheme = (Theme)ThemeComboBox.SelectedItem;

                if (!Enum.IsDefined(typeof(Theme), newTheme))
                {
                    throw new ArgumentException($"{newTheme} is not a valid theme");
                }

                var settingUpdate = new SettingUpdate(
                    ThemeComboBox,
                    Properties.Settings.Default.Theme,
                    newTheme,
                    () => Properties.Settings.Default.Theme = newTheme);

                _updates.AddIfUnique(settingUpdate);
            }
            catch (Exception ex)
            {
                this.LogException(ex);
            }
        }

        public void SaveChanges()
        {
            if (_updates.Count == 0)
            {
                this.Log(LogLevel.Debug, "No settings to save");
                return;
            }

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

        public void OnPageSizeValueChanged(object sender, EventArgs e)
        {
            NumericUpDown control = (NumericUpDown)sender;
            var settingUpdate = new SettingUpdate(
                control,
                Properties.Settings.Default.PageSize,
                (int)control.Value,
                () => Properties.Settings.Default.PageSize = (int)control.Value);

            _updates.AddIfUnique(settingUpdate);
        }

        public void OnScanPeriodValueChanged(object sender, EventArgs e)
        {
            NumericUpDown control = (NumericUpDown)sender;
            var settingUpdate = new SettingUpdate(
                control,
                Properties.Settings.Default.ScanPeriod,
                (int)control.Value * 1000,
                () => Properties.Settings.Default.ScanPeriod = (int)control.Value * 1000);

            _updates.AddIfUnique(settingUpdate);
        }

        public void OnNotifyBeforeValueChanged(object sender, EventArgs e)
        {
            NumericUpDown control = (NumericUpDown)sender;
            var settingUpdate = new SettingUpdate(
                control,
                Properties.Settings.Default.NotifyBefore,
                (int)control.Value,
                () => Properties.Settings.Default.NotifyBefore = (int)control.Value);

            _updates.AddIfUnique(settingUpdate);
        }
    }


    public class SettingUpdate
    {
        public Control Control { get; }
        public object OldValue { get; }
        public object NewValue { get; }
        public Action SaveAction { get; }

        public SettingUpdate(Control control, object oldValue, object newValue, Action saveAction)
        {
            Control = control;
            OldValue = oldValue;
            NewValue = newValue;
            SaveAction = saveAction;
        }

        public void Save()
        {
            SaveAction?.Invoke();
        }
    }

    public class SettingUpdateCollection : IEnumerable<SettingUpdate>
    {
        private readonly List<SettingUpdate> _updates = new List<SettingUpdate>();
        public int Count => _updates.Count;

        public void Add(SettingUpdate update)
        {
            _updates.Add(update);
        }

        public bool AddIfUnique(SettingUpdate update)
        {
            if (_updates.Any(x => x.Control == update.Control))
            {
                _updates.RemoveAll(x => x.Control == update.Control);
                if (!EqualityComparer<object>.Default.Equals(update.NewValue, update.OldValue))
                {
                    _updates.Add(update);
                }
                return true;
            }

            if (EqualityComparer<object>.Default.Equals(update.NewValue, update.OldValue))
            {
                _updates.RemoveAll(x => x.Control == update.Control);
                return false;
            }

            _updates.Add(update);

            return true;
        }

        public void Clear()
        {
            _updates.Clear();
        }
        public void Save()
        {
            foreach (var update in _updates)
            {
                update.Save();
            }
        }

        public IEnumerator<SettingUpdate> GetEnumerator()
        {
            return _updates.GetEnumerator();
        }


        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _updates.GetEnumerator();
        }
    }
}
