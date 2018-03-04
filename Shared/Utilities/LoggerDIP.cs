using Shared.Utilities.Loggers;

namespace Shared.Utilities
{
    public class LoggerDIP
    {
        private readonly ILogger _log;
        public LoggerDIP(ILogger log)
        {
            _log = log;
        }

        public void LogError(string error)
        {
            _log.LogError(error);
        }
    }
}
