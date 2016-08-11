using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;

namespace CarManager.Api.CustomFilters
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
    public class CustomExceptionFilterAttribute : System.Web.Http.Filters.ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            actionExecutedContext.Response = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError);
        }
    }
}