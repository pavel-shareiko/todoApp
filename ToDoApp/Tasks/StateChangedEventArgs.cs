using System;

namespace ToDoApp.Tasks
{
    public class StateChangedEventArgs : EventArgs
    {
        public StatusUpdate State { get; private set; }
        public object OldValue { get; private set; }
        public object NewValue { get; private set; }

        public StateChangedEventArgs(StatusUpdate state, object oldValue, object newValue)
        {
            State = state;
            OldValue = oldValue;
            NewValue = newValue;
        }
    }

    public enum StatusUpdate
    {
        CompletionStatusChanged,
        NameChanged,
        DescriptionChanged,
        ImportanceChanged,
        DeadLineChanged,
        CreationDateChanged,
        CompletionDateChanged
    }
}