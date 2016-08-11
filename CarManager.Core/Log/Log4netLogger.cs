using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager.Core.Log
{
    public class Log4netLogger : ILog
    {
        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger("RollingLogFileAppender");

        public void Error(string message)
        {
            logger.Error(message);
        }

        public void Error(string message, Exception innerException)
        {
            logger.Error(message, innerException);
        }

        public void Fatal(string message)
        {
            logger.Fatal(message);
        }

        public void Fatal(string message, Exception innerException)
        {
            logger.Fatal(message, innerException);
        }

        public void Info(string message)
        {
            logger.Info(message);
        }

        public void Info(string message, Exception innerException)
        {
            logger.Info(message, innerException);
        }

        public void Warning(string message)
        {
            logger.Warn(message);
        }

        public void Warning(string message, Exception innerException)
        {
            logger.Warn(message, innerException);
        }
    }
}
