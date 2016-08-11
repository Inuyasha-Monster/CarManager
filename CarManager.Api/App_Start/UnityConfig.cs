using CarManager.Core.Config;
using CarManager.Core.Infrastructure;
using CarManager.WebCore;
using Microsoft.Practices.Unity;
using System;
using System.Configuration;
using System.Web.Http;
using Unity.WebApi;

namespace CarManager.Api
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = ServiceContainer.CurrentContainer;

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            RegisterTypes(container);

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }



        private static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below. Make sure to add a Microsoft.Practices.Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your types here
            // container.RegisterType<IProductRepository, ProductRepository>();

            // 为了在其他地方构造函数注入 UnityContainer 的时时候准备
            container.RegisterInstance<IUnityContainer>(container);

            ITypeFinder typeFinder = new WebAppTypeFinder();

            var applicationConfiguration = ConfigurationManager.GetSection("applicationConfig") as ApplicationConfig;

            container.RegisterInstance<ApplicationConfig>(applicationConfiguration);

            var types = typeFinder.FindClassesOfType<IDependencyRegister>();
            foreach (var item in types)
            {
                var register = (IDependencyRegister)Activator.CreateInstance(item);
                register.RegisterTypes(container);
            }
        }
    }
}