using System;

namespace ToDoApp.Other
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