using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Utilities;
using Shared.Utilities.Loggers;

namespace DependencyInversionPrinciple
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // This uses a concrete implementation of ILogger resulting in a tight coupling with the implementation
            //var logger = new LoggerDIP(new DbLogger());

            #region Fix
            // This uses a service locator pattern to retrieve an instance of a logger. We're specifying DbLogger
            // but what we're getting from the locator can be any ILogger meaning we don't know about the implementation
            // here and the actual logger's property is set to what the locator returns. Thus, both ends are programming
            // against abstractions and meet the DIP requirements
            var serviceLocator = new ServiceLocator();
            var logger = new LoggerDIP(serviceLocator.GetLogger<DbLogger>());
            #endregion

            logger.LogError("This is an error");

        }
    }
}
