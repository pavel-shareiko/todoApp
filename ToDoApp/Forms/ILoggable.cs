using NLog;

namespace ToDoApp.Forms
{
    public interface ILoggable
    {
        bool LogEnabled { get; set; }
        void Log(LogLevel level, string message);
    }
}