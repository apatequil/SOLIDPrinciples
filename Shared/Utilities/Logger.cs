
namespace Shared.Utilities
{
    public enum LoggerType { File = 0, Database = 1 }
    public static class Logger
    {
        private static readonly string _logPath = @"c:\log.txt";
        private static LoggerType _logType = LoggerType.File;

        public static void LogError(string error)
        {
            switch(_logType)
            {
                case LoggerType.File:

                    // file logging code

                    break;
                case LoggerType.Database:

                    // database logging code

                    break;
            }
        }

        #region Notes
        // OCP: The logger isn't extensible without modification. New types of loggers will require
        //      modification to the logger
        #endregion
    }
}
