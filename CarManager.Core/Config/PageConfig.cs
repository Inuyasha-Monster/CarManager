using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager.Core.Config
{
    public class PageConfig : ConfigurationElement
    {
        private const string MaxPagePropertyName = "maxPage";
        private const string MinPagePropertyName = "minPage";

        [ConfigurationProperty(MaxPagePropertyName, IsRequired = true)]
        public int MaxPage { get { return (int)base[MaxPagePropertyName]; } }

        [ConfigurationProperty(MinPagePropertyName, IsRequired = true)]
        public int MinPage { get { return (int)base[MinPagePropertyName]; } }
    }
}
