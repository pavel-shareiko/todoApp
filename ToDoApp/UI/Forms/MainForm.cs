using Logic.Utils;
using Microsoft.Win32;
using NLog;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using ToDoApp.UI;
using ToDoApp.UI.Controls;

namespace ToDoApp.Forms
{
    public partial class MainForm : Form, ILoggable
    {
        public Logger Logger { get; } = LogManager.GetCurrentClassLogger();
        [Category("Logging")] public bool IsLoggingEnabled { get; set; } = true;

        private readonly UserPreferenceChangedEventHandler _userPreferenceChanged;
        private TasksForm _tasksForm;

        public MainForm()
        {
            InitializeComponent();

            ApplyTheme();
            _userPreferenceChanged = SystemEvents_UserPreferenceChanged;
            SystemEvents.UserPreferenceChanged += _userPreferenceChanged;
            Disposed += MainForm_Disposed;

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
            }
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

        private void tasksButton_Click(object sender, EventArgs e)
        {
            if (_tasksForm == null)
            {
                _tasksForm = new TasksForm();
            }

            _tasksForm.ApplyToPanel(contentPanel);
        }

        private void settingsButton_Click(object sender, EventArgs e) => new SettingsForm().ApplyToPanel(contentPanel);

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) => TaskManager.Save();

        #endregion
    }
}