using CarManager.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CarManager.WebCore
{
    public class WebAppTypeFinder : AppDomainFinder
    {
        private bool binFolderAssembliesLoaded = false;

        public virtual string GetBinDiectory()
        {
            if (System.Web.Hosting.HostingEnvironment.IsHosted)
            {
                return System.Web.HttpRuntime.BinDirectory;
            }
            var dectory = AppDomain.CurrentDomain.BaseDirectory;
            return dectory;
        }

        public override IList<Assembly> GetAssemblies()
        {
            if (!binFolderAssembliesLoaded)
            {
                binFolderAssembliesLoaded = true;
                LoadMatchingAssemblies(GetBinDiectory());
            }
            return base.GetAssemblies();
        }
    }
}
