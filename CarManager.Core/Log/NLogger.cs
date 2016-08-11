using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager.Core.Log
{
    public class NLogger : ILog
    {
        public void Error(string message)
        {
            throw new NotImplementedException();
        }

        public void Error(string message, Exception innerException)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string message)
        {
            throw new NotImplementedException();
        }

        public void Fatal(string message, Exception innerException)
        {
            throw new NotImplementedException();
        }

        public void Info(string message)
        {
            throw new NotImplementedException();
        }

        public void Info(string message, Exception innerException)
        {
            throw new NotImplementedException();
        }

        public void Warning(string message)
        {
            throw new NotImplementedException();
        }

        public void Warning(string message, Exception innerException)
        {
            throw new NotImplementedException();
        }
    }
}
