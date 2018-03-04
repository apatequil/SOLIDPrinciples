
using System;

namespace Shared.Utilities.Loggers
{
    public class FileLogger : BaseLogger
    {
        private readonly string _logFile = @"c:\logs\log.txt";

        public override void LogError(string error)
        {
            // Log error to file code
        }
    }
}
