using System;
using System.Runtime.CompilerServices;

namespace Logic.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class OrderAttribute : Attribute
    {
        private readonly int _order;
        public int Order => _order;
        public OrderAttribute([CallerLineNumber] int order = 0)
        {
            _order = order;
        }
    }
}
