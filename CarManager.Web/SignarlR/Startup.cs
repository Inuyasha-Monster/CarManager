using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin;
using Owin;
using CarManager.Web.SignarlR;

[assembly: OwinStartup(typeof(Startup))]
namespace CarManager.Web.SignarlR
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}