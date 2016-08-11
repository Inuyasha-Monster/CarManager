using CarManager.Core.Config;
using CarManager.Core.Log;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CarManager.Core.NoSql
{
    public class MongoDbLogger : ILog
    {
        private readonly IMongoCollection<LogMessage> collection;

        public MongoDbLogger(ApplicationConfig applicationConfig)
        {
            if (applicationConfig == null) throw new ArgumentNullException(nameof(applicationConfig));
            var mongoDbConfig = applicationConfig.MongoDbConfig;
            if (mongoDbConfig == null) throw new ArgumentNullException(nameof(mongoDbConfig));
            if (mongoDbConfig.ConnnectionString == null) throw new ArgumentNullException(nameof(mongoDbConfig.ConnnectionString));
            var conStr = mongoDbConfig.ConnnectionString;
            var client = new MongoClient(conStr);
            var database = client.GetDatabase(mongoDbConfig.Database);
            collection = database.GetCollection<LogMessage>(mongoDbConfig.Collection);
        }

        public void Error(string message)
        {
            var log = new LogMessage()
            {
                LevelEnum = LevelEnum.Error,
                ThreadId = Thread.CurrentThread.ManagedThreadId,
                Message = message
            };
            collection.InsertOne(log);
        }

        public void Error(string message, Exception innerException)
        {
            var log = new LogMessage()
            {
                LevelEnum = LevelEnum.Error,
                ThreadId = Thread.CurrentThread.ManagedThreadId,
                Message = message,
                InnerExceptionMessage = innerException.Message
            };
            collection.InsertOne(log);
        }

        public void Fatal(string message)
        {
            var log = new LogMessage()
            {
                LevelEnum = LevelEnum.Fatal,
                ThreadId = Thread.CurrentThread.ManagedThreadId,
                Message = message
            };
            collection.InsertOne(log);
        }

        public void Fatal(string message, Exception innerException)
        {
            var log = new LogMessage()
            {
                LevelEnum = LevelEnum.Fatal,
                ThreadId = Thread.CurrentThread.ManagedThreadId,
                Message = message,
                InnerExceptionMessage = innerException.Message
            };
            collection.InsertOne(log);
        }

        public void Info(string message)
        {
            var log = new LogMessage()
            {
                LevelEnum = LevelEnum.Info,
                ThreadId = Thread.CurrentThread.ManagedThreadId,
                Message = message
            };
            collection.InsertOne(log);
        }

        public void Info(string message, Exception innerException)
        {
            var log = new LogMessage()
            {
                LevelEnum = LevelEnum.Info,
                ThreadId = Thread.CurrentThread.ManagedThreadId,
                Message = message,
                InnerExceptionMessage = innerException.Message
            };
            collection.InsertOne(log);
        }

        public void Warning(string message)
        {
            var log = new LogMessage()
            {
                LevelEnum = LevelEnum.Warning,
                ThreadId = Thread.CurrentThread.ManagedThreadId,
                Message = message
            };
            collection.InsertOne(log);
        }

        public void Warning(string message, Exception innerException)
        {
            var log = new LogMessage()
            {
                LevelEnum = LevelEnum.Warning,
                ThreadId = Thread.CurrentThread.ManagedThreadId,
                Message = message,
                InnerExceptionMessage = innerException.Message
            };
            collection.InsertOne(log);
        }
    }
}
