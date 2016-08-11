using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace CarManager.ApiSelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var plugins = Directory.GetFiles(Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "plugins"));
            foreach (var item in plugins)
            {
                Assembly.LoadFile(item);
            }

            var config = new HttpSelfHostConfiguration("http://127.0.0.1:8888");

            config.Routes.MapHttpRoute("default", "api/{controller}/{id}", new
            {
                id = RouteParameter.Optional
            });

            var server = new HttpSelfHostServer(config);

            server.OpenAsync().Wait();

            Console.WriteLine("http://127.0.0.1:8888 started");

            Console.ReadKey();
        }
    }
}
