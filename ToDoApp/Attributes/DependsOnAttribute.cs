using System;

namespace ToDoApp.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class DependsOnAttribute : Attribute
    {
        public string DependsOn { get; }
        public DependsOnAttribute(string parent)
        {
            DependsOn = parent;
        }
    }
}
