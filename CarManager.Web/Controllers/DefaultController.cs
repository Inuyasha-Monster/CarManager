using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarManager.WebCore.MVC;
using CarManager.Core.Infrastructure;
using MongoDB.Driver;
using CarManager.Core.NoSql;

namespace CarManager.Web.Controllers
{
    public class DefaultController : BaseController
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
    }
}