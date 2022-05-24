using System;
using System.Windows.Forms;
using ToDoApp.Extensions;
using ToDoApp.Forms;
using ToDoApp.UI.Forms;

namespace ToDoApp.Controllers
{
    public class MainFormController
    {
        public UserControl CurrentScreen { get; private set; }
        
        private TasksUserControl _tasksScreen;
        private HomeUserControl _homeScreen;

        private readonly Panel _contentPanel;

        public MainFormController(Panel contentPanel)
        {
            _contentPanel = contentPanel ?? throw new ArgumentNullException(nameof(contentPanel));
        }

        public void ShowHomeScreen()
        {
            if (CurrentScreen is HomeUserControl)
            {
                return;
            }
            
            if (_homeScreen == null)
            {
                _homeScreen = new HomeUserControl();
            }

            CurrentScreen = _homeScreen;
            _homeScreen.ApplyToPanel(_contentPanel);
        }

        public void ShowTasksScreen()
        {
            if (CurrentScreen is TasksUserControl)
            {
                return;
            }

            if (_tasksScreen == null)
            {
                _tasksScreen = new TasksUserControl();
            }

            CurrentScreen = _tasksScreen;
            _tasksScreen.ApplyToPanel(_contentPanel);
        }

        public void ShowSettingsScreen()
        {
            if (CurrentScreen is SettingsUserControl)
            {
                return;
            }

            var settingsScreen = new SettingsUserControl();
            CurrentScreen = settingsScreen;
            settingsScreen.ApplyToPanel(_contentPanel);
        }
    }
}
