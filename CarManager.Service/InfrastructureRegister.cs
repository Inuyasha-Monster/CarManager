using CarManager.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using CarManager.Core.Cache;
using CarManager.Core.Log;
using CarManager.Core.NoSql;

namespace CarManager.Service
{
    public class InfrastructureRegister : IDependencyRegister
    {
        public void RegisterTypes(IUnityContainer unityContainer)
        {
            unityContainer.RegisterType<ICacheManager, RedisCacheManager>("RedisCacheManager");
            unityContainer.RegisterType<ICacheManager, MemcachedCacheManager>("MemcachedCacheManager");
            unityContainer.RegisterType<ICacheManager, NullCacheManager>("NullCacheManager");
            unityContainer.RegisterType<ICacheManager, MemoryCacheManager>("MemoryCacheManager");
            unityContainer.RegisterType<ILog, NullLogger>();
            unityContainer.RegisterType<ILog, Log4netLogger>("Log4netLogger");
            unityContainer.RegisterType<ILog, MongoDbLogger>("MongoDbLogger", new ContainerControlledLifetimeManager());
        }
    }
}
