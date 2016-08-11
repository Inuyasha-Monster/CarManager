using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarManager.Web.MvcExtends
{
    public static class MvcHelperExtend
    {
        public static MvcHtmlString MyDisplayName(this HtmlHelper htmlHelper, string name)
        {
            return new MvcHtmlString(name);
        }
    }
}