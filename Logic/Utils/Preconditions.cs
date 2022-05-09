using System;

namespace Logic.Utils
{

    public static class Preconditions
    {
        public static void RequireNonNull(object obj)
        {
            if (obj is null)
            {
                throw new ArgumentNullException(nameof(obj), "obj cannot be null");
            }
        }

        public static void RequireNonEmptyString(string s)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s))
            {
                throw new ArgumentException("Input string cannot be null or empty or whitespace");
            }
        }
    }
}