using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarManager.Web.MvcExtends
{
    public class LanguageFilterAttribute : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {

        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext == null) throw new ArgumentNullException(nameof(filterContext));
            var language = filterContext.RouteData.Values["language"].ToString();
            if (string.IsNullOrWhiteSpace(language))
            {
                language = "zh-cn";
            }
            System.Threading.Thread.CurrentThread.CurrentUICulture = new
                 System.Globalization.CultureInfo(language);
            System.Threading.Thread.CurrentThread.CurrentCulture = new
                 System.Globalization.CultureInfo(language);
        }
    }
}