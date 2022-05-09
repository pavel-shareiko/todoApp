using NLog;

namespace Logic.Utils
{
    public interface ILoggable
    {
        bool IsLoggingEnabled { get; set; }
        Logger Logger { get; }
    }
}