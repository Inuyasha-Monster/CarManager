using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager.Core.Log
{
    public class NullLogger : ILog
    {
        public void Warning(string message)
        {
        }

        public void Warning(string message, Exception innerException)
        {
        }

        public void Error(string message)
        {

        }

        public void Error(string message, Exception innerException)
        {

        }

        public void Fatal(string message)
        {

        }

        public void Fatal(string message, Exception innerException)
        {

        }

        public void Info(string message)
        {

        }

        public void Info(string message, Exception innerException)
        {

        }
    }
}
