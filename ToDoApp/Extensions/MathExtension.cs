using System;

namespace ToDoApp.UI
{
    public static class MathExtension
    {
        public static T Clamp<T>(T min, T value, T max) where T : IComparable<T>
        {
            if (value.CompareTo(min) < 0)
                return min;

            return value.CompareTo(max) > 0 ? max : value;
        }

        public static T Clamp<T>(T min, T value) where T : IComparable<T>
        {
            return value.CompareTo(min) < 0
                ? min
                : value;
        }
    }
}