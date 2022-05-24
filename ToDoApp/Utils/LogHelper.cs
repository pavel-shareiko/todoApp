using NLog;
using System;
using System.Runtime.CompilerServices;

namespace ToDoApp.Utils
{
    public static class LogHelper
    {
        public static void Log(this ILoggable loggable, LogLevel level, string message, [CallerMemberName] string method = "Main")
        {
            ValidateLoggable(loggable);

            if (loggable.IsLoggingEnabled && loggable.Logger.IsEnabled(level))
            {
                loggable.Logger.Log(level, $"[{loggable.Logger.Name}.{method}]: {message}");
            }
        }

        public static void LogException(this ILoggable loggable, Exception e)
        {
            ValidateLoggable(loggable);

            if (loggable.IsLoggingEnabled && loggable.Logger.IsEnabled(LogLevel.Error))
            {
                loggable.Logger.Error(e);
            }
        }

        private static void ValidateLoggable(ILoggable loggable)
        {
            if (loggable is null)
            {
                throw new ArgumentNullException(nameof(loggable));
            }

            if (loggable.Logger is null)
            {
                throw new ArgumentException("The logger is not set in the loggable instance", nameof(loggable));
            }
        }
    }
}
