using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Config;

namespace Lib
{
    public class Logger
    {
        public Logger() => XmlConfigurator.Configure();
        
        public ILog logger = LogManager.GetLogger(typeof(object));

        public void LogError(string message, string ex, string stackTrace) => logger.ErrorFormat(message, ex, stackTrace);

        public void LogAudit(string message) => logger.WarnFormat(message);
    }

}
