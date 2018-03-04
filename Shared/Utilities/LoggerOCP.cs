using Shared.Utilities.Loggers;

namespace Shared.Utilities
{
    public static class LoggerOCP
    {
        private static LoggerType _logType = LoggerType.File;

        public static BaseLogger log { get; set; }

        public static void LogError(string error)
        {
            log.LogError(error);
        }
    }
}
