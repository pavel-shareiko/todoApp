using System;

namespace ToDoApp.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class HiddenAttribute : Attribute
    {

    }
}
