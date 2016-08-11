using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager.Core.Config
{
    public class MemcachedCacheElement : ConfigurationElement
    {
        private const string ConnectionStringPropertyName = "connectionString";

        private const string PortPorpertyName = "port";

        [ConfigurationProperty(ConnectionStringPropertyName, IsRequired = true, DefaultValue = "127.0.0.1", Options = ConfigurationPropertyOptions.IsRequired)]
        public string ConnectionString
        {
            get
            {
                return (string)base[ConnectionStringPropertyName];
            }
        }

        [ConfigurationProperty(PortPorpertyName, IsRequired = true, Options = ConfigurationPropertyOptions.IsRequired)]
        public string Port
        {
            get
            {
                return (string)base[PortPorpertyName];
            }
        }
    }
}
