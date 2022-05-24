using Microsoft.Toolkit.Uwp.Notifications;
using NLog;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using ToDoApp.Controllers;
using ToDoApp.Extensions;
using ToDoApp.Tasks;
using ToDoApp.UI;
using ToDoApp.UI.Controls;
using ToDoApp.UI.Forms;
using ToDoApp.Utils;

namespace ToDoApp.Forms
{
    public partial class MainForm : Form, ILoggable
    {
        public Logger Logger { get; } = LogManager.GetCurrentClassLogger();
        [Category("Logging")] public bool IsLoggingEnabled { get; set; } = true;

        private readonly MainFormController _controller;

        public MainForm()
        {
            InitializeComponent();

            _controller = new MainFormController(contentPanel);
            _controller.ShowHomeScreen();
            ApplyTheme();

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
        #endregion

        #region Event handlers

        private void OnExitButtonClicked(object sender, EventArgs e)
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

        private void OnHomeButtonClicked(object sender, EventArgs e)
        {
            _controller.ShowHomeScreen();
        }

        private void OnTasksButtonClicked(object sender, EventArgs e)
        {
            _controller.ShowTasksScreen();
        }

        private void OnSettingsButtonClicked(object sender, EventArgs e)
        {
            _controller.ShowSettingsScreen();
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            TaskManager.Save();
            ToastNotificationManagerCompat.History.Clear();
        }
        #endregion
    }
}