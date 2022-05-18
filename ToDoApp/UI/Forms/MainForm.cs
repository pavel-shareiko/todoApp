using Logic.Utils;
using Microsoft.Toolkit.Uwp.Notifications;
using Microsoft.Win32;
using NLog;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using ToDoApp.UI;
using ToDoApp.UI.Controls;
using ToDoApp.UI.Forms;

namespace ToDoApp.Forms
{
    public partial class MainForm : Form, ILoggable
    {
        public Logger Logger { get; } = LogManager.GetCurrentClassLogger();
        [Category("Logging")] public bool IsLoggingEnabled { get; set; } = true;
        public UserControl CurrentScreen { get; private set; }

        private readonly UserPreferenceChangedEventHandler _userPreferenceChanged;
        private TasksUserControl _tasksScreen;
        private HomeUserControl _homeScreen;

        public MainForm()
        {
            InitializeComponent();

            ApplyTheme();

            if (Properties.Settings.Default.Theme == UI.Themes.Theme.Windows)
            {
                _userPreferenceChanged = SystemEvents_UserPreferenceChanged;
                SystemEvents.UserPreferenceChanged += _userPreferenceChanged;
                Disposed += MainForm_Disposed;
            }

            ShowHomeScreen();

            this.Log(LogLevel.Debug, "Main form initialized successfully");
        }

        #region Methods

        private void ApplyTheme()
        {
            menuPanel.BackColor = ApplicationStyle.ThirdColor;
            contentPanel.BackColor = ApplicationStyle.BackgroundColor;

            foreach (var button in menuPanel.Controls.OfType<RoundButton>())
            {
                button.BackGroundColor = ApplicationStyle.ThirdColor;
                button.TextColor = button.BackGroundColor.GetContrastColor();
                button.IconColor = button.TextColor;
            }
        }

        private void ShowHomeScreen()
        {
            if (_homeScreen == null)
            {
                _homeScreen = new HomeUserControl();
            }

            CurrentScreen = _homeScreen;
            _homeScreen.ApplyToPanel(contentPanel);
        }

        private void ShowTasksScreen()
        {
            if (_tasksScreen == null)
            {
                _tasksScreen = new TasksUserControl();
            }

            CurrentScreen = _tasksScreen;
            _tasksScreen.ApplyToPanel(contentPanel);
        }

        private void ShowSettingsScreen()
        {
            var settingsScreen = new SettingsUserControl();
            CurrentScreen = settingsScreen;
            settingsScreen.ApplyToPanel(contentPanel);
        }

        #endregion

        #region Event handlers

        private void MainForm_Disposed(object sender, EventArgs e)
        {
            SystemEvents.UserPreferenceChanged -= _userPreferenceChanged;
        }

        private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            if (e.Category == UserPreferenceCategory.General || e.Category == UserPreferenceCategory.VisualStyle)
            {
                ApplyTheme();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            var args = new FormClosingEventArgs(CloseReason.ApplicationExitCall, false);
            OnFormClosing(args);

            Application.Exit();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            if (CurrentScreen is HomeUserControl)
            {
                return;
            }

            ShowHomeScreen();
        }

        private void tasksButton_Click(object sender, EventArgs e)
        {
            if (CurrentScreen is TasksUserControl)
            {
                return;
            }

            ShowTasksScreen();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            if (CurrentScreen is SettingsUserControl)
            {
                return;
            }

            ShowSettingsScreen();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TaskManager.Save();
            ToastNotificationManagerCompat.History.Clear();
        }
        #endregion
    }
}