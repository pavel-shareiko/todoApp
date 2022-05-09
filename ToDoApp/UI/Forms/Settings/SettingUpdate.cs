using System;
using System.Windows.Forms;

namespace ToDoApp.Forms
{
    public class SettingUpdate : IEquatable<SettingUpdate>
    {
        private readonly Action _action;
        public Control Control { get; }
        public object OldValue { get; }
        public object NewValue { get; }

        public SettingUpdate(Control control, object oldValue, object newValue, Action action)
        {
            _action = action;
            Control = control;
            OldValue = oldValue;
            NewValue = newValue;
        }

        public void Save()
        {
            _action.Invoke();
        }

        public int GetHashCode(SettingUpdate obj)
        {
            return obj.Control.GetHashCode();
        }

        public bool Equals(SettingUpdate other)
        {
            if (ReferenceEquals(this, other)) return true;
            if (other is null) return false;

            return this.Control == other.Control;
        }
    }

}
