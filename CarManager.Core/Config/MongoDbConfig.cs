using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager.Core.Config
{
    public class MongoDbConfig : ConfigurationElement
    {
        private const string ConnnectionStringPropertyName = "connectionString";
        private const string DatabasePropertyName = "database";
        private const string CollectionPropertyName = "collection";

        [ConfigurationProperty(name: ConnnectionStringPropertyName, DefaultValue = "mongodb://127.0.0.1:27017", IsRequired = true)]
        public string ConnnectionString { get { return (string)base[ConnnectionStringPropertyName]; } }

        [ConfigurationProperty(DatabasePropertyName, IsRequired = true, DefaultValue = "logs")]
        public string Database { get { return (string)base[DatabasePropertyName]; } }

        [ConfigurationProperty(CollectionPropertyName, IsRequired = true, DefaultValue = "log")]
        public string Collection { get { return (string)base[CollectionPropertyName]; } }

    }
}
