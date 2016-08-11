using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager.Core.Config
{
    [ConfigurationCollection(typeof(RedisCacheElement))]
    public class RedisCacheElementCollection : ConfigurationElementCollection
    {
        private const string RedisCacheConfigElementName = "redisConfig";

        public override ConfigurationElementCollectionType CollectionType
        {
            get
            {
                return ConfigurationElementCollectionType.BasicMap;
            }
        }

        protected override string ElementName
        {
            get
            {
                return RedisCacheConfigElementName;
            }
        }

        protected override bool IsElementName(string elementName)
        {
            if (string.IsNullOrWhiteSpace(elementName)) return false;
            return elementName.Equals(RedisCacheConfigElementName,
              StringComparison.CurrentCulture);
        }

        public override bool IsReadOnly()
        {
            return false;
        }

        public override string ToString()
        {
            var items = base.GetEnumerator();
            var str = string.Empty;
            while (items.MoveNext())
            {
                var redisElement = items.Current as RedisCacheElement;
                //str = str + redisElement.ConnectionString + ":" + redisElement.Port + ",";
                str = $"{str}{redisElement.ConnectionString}:{redisElement.Port},";
            }
            if (str.EndsWith(",", StringComparison.CurrentCulture))
            {
                str = str.TrimEnd(new char[] { ',' });
            }
            return str;
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new RedisCacheElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((RedisCacheElement)element).Port;
        }

        public RedisCacheElement this[int idx]
        {
            get { return (RedisCacheElement)base.BaseGet(idx); }
        }
    }
}
