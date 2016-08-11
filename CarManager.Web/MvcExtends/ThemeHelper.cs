using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarManager.Web.MvcExtends
{
    public static class ThemeHelper
    {
        public static void ChangeTheme(string themeName)
        {
            var engine = ViewEngines.Engines.Where(x => x is RazorViewEngine).Single() as RazorViewEngine;
            engine.ViewLocationFormats = engine.PartialViewLocationFormats = new string[]
            {
                "~/Views/Themes/"+themeName+"/{1}/{0}.cshtml",
                "~/Views/{1}/{0}.cshtml",
                "~/Views/Shared/{0}.cshtml"
            };
        }
    }
}