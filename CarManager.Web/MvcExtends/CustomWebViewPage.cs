using CarManager.Web.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarManager.Web.MvcExtends
{
    public abstract class CustomWebViewPage<TModel> : System.Web.Mvc.WebViewPage<TModel>
    {
        public string T(string localizationKey)
        {
            return Resources.ResourceManager.GetString(localizationKey);
        }
    }
}