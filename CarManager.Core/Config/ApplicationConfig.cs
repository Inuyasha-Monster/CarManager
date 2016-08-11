using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager.Core.Config
{
    public class ApplicationConfig : ConfigurationSection
    {
        private const string RedisCacheConfigListPropertyName = "redisConfigList";

        private const string MemcachedConfigListPropertyName = "memcachedConfigList";

        private const string PageConfigPropertyName = "pageConfig";

        private const string MongoDbConfigPropertyName = "mongoDbConfig";

        [ConfigurationProperty(RedisCacheConfigListPropertyName, IsRequired = true)]
        public RedisCacheElementCollection RedisCacheConfigList
        {
            get { return ((RedisCacheElementCollection)(base[RedisCacheConfigListPropertyName])); }
        }

        [ConfigurationProperty(MemcachedConfigListPropertyName, IsRequired = true)]
        public MemcachedCacheElementCollection MemcachedCacheConfigList
        {
            get
            {
                return ((MemcachedCacheElementCollection)base[MemcachedConfigListPropertyName]);
            }
        }

        [ConfigurationProperty(PageConfigPropertyName, IsRequired = true)]
        public PageConfig PageConfig
        {
            get
            {
                return (PageConfig)base[PageConfigPropertyName];
            }
        }


        [ConfigurationProperty(MongoDbConfigPropertyName, IsRequired = true)]
        public MongoDbConfig MongoDbConfig
        {
            get
            {
                return (MongoDbConfig)base[MongoDbConfigPropertyName];
            }
        }
    }
}
