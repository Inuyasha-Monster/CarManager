using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager.Core.NoSql
{
    [Serializable]
    public sealed class LogMessage : BaseMongoDbObject
    {
        public LogMessage()
        {
            CreateTime = DateTime.Now;
            Message = string.Empty;
            InnerExceptionMessage = string.Empty;
        }
        public DateTime CreateTime { get; set; }
        public int ThreadId { get; set; }

        public LevelEnum LevelEnum { get; set; }

        public string Message { get; set; }

        public string InnerExceptionMessage { get; set; }
    }
}
