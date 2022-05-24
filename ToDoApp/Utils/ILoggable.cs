using NLog;

namespace ToDoApp.Utils
{
    public interface ILoggable
    {
        bool IsLoggingEnabled { get; set; }
        Logger Logger { get; }
    }
}