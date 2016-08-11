using System;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using CarManager.Core.Infrastructure;
using CarManager.WebCore;
using System.Configuration;
using CarManager.Core.Config;

namespace CarManager.Web.App_Start
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public class UnityConfig
    {
        #region Unity Container
        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            RegisterTypes(ServiceContainer.CurrentContainer);
            return ServiceContainer.CurrentContainer;
        }
        #endregion

        /// <summary>Registers the type mappings with the Unity container.</summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to 
        /// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
        public static void RegisterTypes(IUnityContainer container)
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
