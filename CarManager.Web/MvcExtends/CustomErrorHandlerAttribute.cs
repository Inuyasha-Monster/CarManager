using CarManager.Core.Infrastructure;
using CarManager.Core.Log;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CarManager.Web.MvcExtends
{
    public class CustomErrorHandlerAttribute : HandleErrorAttribute
    {
        private readonly ILog logger = ServiceContainer.Resole<ILog>();

        public override void OnException(ExceptionContext filterContext)
        {
            if (filterContext == null) throw new ArgumentNullException(nameof(filterContext));
            filterContext.ExceptionHandled = true;
            var exp = filterContext.Exception;
            logger.Error("发现未处理异常", exp);
            filterContext.Result = new HttpStatusCodeResult(HttpStatusCode.InternalServerError);
            //filterContext.Result = new RedirectResult("/Views/Shared/Error.cshtml");
        }
    }
}