
namespace Shared.Utilities.Loggers
{
    public abstract class BaseLogger : ILogger
    {
        public abstract void LogError(string error);
    }
}
