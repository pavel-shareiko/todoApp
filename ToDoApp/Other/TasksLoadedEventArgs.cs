using System;

namespace ToDoApp.Controls
{
    public class TasksLoadedEventArgs : EventArgs
    {
        public bool Successful { get; }
        public TasksLoadedEventArgs(bool isSuccessful)
        {
            Successful = isSuccessful;
        }
    }
}