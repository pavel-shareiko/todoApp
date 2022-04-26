using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Logic.Repositories;
using Microsoft.Win32;
using NLog;
using Tasks;
using ToDoApp.UI;
using ToDoApp.UI.Controls;
using ToDoApp.UI.Themes;
using static ToDoApp.Properties.Settings;

namespace ToDoApp.Forms
{
    public partial class MainForm : Form, ILoggable
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        public static Diary Diary { get; private set; }
        public static IColorPalette ColorPalette { get; } = ColorPaletteFactory.Instance.GetColorPalette();
        [Category("Logging")] public bool LogEnabled { get; set; } = true;

        private readonly UserPreferenceChangedEventHandler _userPreferenceChanged;

        public MainForm()
        {
            InitializeComponent();

            ApplyTheme();
            _userPreferenceChanged = SystemEvents_UserPreferenceChanged;
            SystemEvents.UserPreferenceChanged += _userPreferenceChanged;
            Disposed += MainForm_Disposed;

            Log(LogLevel.Debug, "Main form initialized successfully");
        }

        #region Methods

        private void ApplyTheme()
        {
            var themeAccentColor = ColorPalette.GetAccentColor();
            var themeSecondaryColor = ColorPalette.GetSecondaryColor();
            var themeThirdColor = ColorPalette.GetThirdColor();
            var themeBackgroundColor = ColorPalette.GetBackgroundColor();

            menuPanel.BackColor = themeAccentColor;
            contentPanel.BackColor = themeBackgroundColor;

            foreach (var button in menuPanel.Controls.OfType<RoundButton>())
            {
                button.BackColor = themeAccentColor;
                button.ForeColor = themeAccentColor.ContrastColor();

                button.BorderColor = themeThirdColor;
            }
        }

        public void Log(LogLevel level, string message)
        {
            if (LogEnabled)
            {
                Logger.Log(level, message);
            }
        }

        #endregion

        #region Event handlers

        private void MainForm_Load(object sender, EventArgs e)
        {
            var repository = new DiaryFileRepository(Default.DiarySaveFileName);
            Diary = repository.Read();
        }

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
            var repository = new DiaryFileRepository(Default.DiarySaveFileName);
            repository.Save(Diary);

            Log(LogLevel.Info, "Application closed");
            Application.Exit();
        }

        private void tasksButton_Click(object sender, EventArgs e)
        {
            new TasksForm().ApplyToPanel(contentPanel);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            new SettingsForm(contentPanel).ApplyToPanel(contentPanel);
        }

        #endregion
    }
}