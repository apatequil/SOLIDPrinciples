using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Shared.Utilities;
using Shared.Utilities.Loggers;

namespace DependencyInversionPrinciple
{
    public class ServiceLocator
    {
        private readonly Dictionary<string, ILogger> _loggers;// = new Dictionary<string, ILogger>();

        internal ServiceLocator()
        {
            // Ideally this would be driven from a config file. This is how DI frameworks like AutoFaq and Prism work
            _loggers = new Dictionary<string, ILogger>
            {
                { typeof(DbLogger).Name, new DbLogger() },
                { typeof(DbLogger).Name, new FileLogger() }
            };

        }

        public T GetLogger<T>() where T : ILogger, new()
        {
            var typeName = typeof(T).Name;
            if (_loggers.ContainsKey(typeName))
            {
                return (T)_loggers[typeName];
            }

            throw new ArgumentException($"{typeof(T).Name} is not a known type");
        }
    }
}
