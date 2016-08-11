using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager.Core.Config
{
    [ConfigurationCollection(typeof(MemcachedCacheElement))]
    public class MemcachedCacheElementCollection : ConfigurationElementCollection
    {
        private const string MemcachedCacheConfigElementName = "memcachedConfig";

        protected override string ElementName
        {
            get
            {
                return MemcachedCacheConfigElementName;
            }
        }

        public override string ToString()
        {
            var items = base.GetEnumerator();
            var str = string.Empty;
            while (items.MoveNext())
            {
                var memcachedElement = items.Current as MemcachedCacheElement;
                //str = str + redisElement.ConnectionString + ":" + redisElement.Port + ",";
                str = $"{str}{memcachedElement.ConnectionString}:{memcachedElement.Port},";
            }
            if (str.EndsWith(",", StringComparison.CurrentCulture))
            {
                str = str.TrimEnd(new char[] { ',' });
            }
            return str;
        }

        public override bool IsReadOnly()
        {
            return false;
        }

        public override ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return ConfigurationElementCollectionType.BasicMap;
            }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new MemcachedCacheElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            var obj = ((MemcachedCacheElement)element).Port;
            return obj;
        }

        protected override bool IsElementName(string elementName)
        {
            if (string.IsNullOrWhiteSpace(elementName)) return false;
            return elementName.Equals(MemcachedCacheConfigElementName,
              StringComparison.CurrentCulture);
        }

        public MemcachedCacheElement this[int idx]
        {
            get { return (MemcachedCacheElement)base.BaseGet(idx); }
        }
    }
}
