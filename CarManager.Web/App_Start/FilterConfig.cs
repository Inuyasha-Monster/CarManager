using CarManager.Web.MvcExtends;
using System.Web;
using System.Web.Mvc;

namespace CarManager.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new HandleErrorAttribute());
            filters.Add(new CustomErrorHandlerAttribute());
            filters.Add(new LanguageFilterAttribute());
        }
    }
}
