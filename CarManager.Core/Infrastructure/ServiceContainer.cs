using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager.Core.Infrastructure
{
    public class ServiceContainer
    {
        private static Lazy<IUnityContainer> Container = new Lazy<IUnityContainer>(() => new UnityContainer());



        //private static IUnityContainer Container = new UnityContainer();

        static ServiceContainer()
        {

        }

        private ServiceContainer()
        {

        }

        public static IUnityContainer CurrentContainer
        {
            get
            {
                return Container.Value;
            }
        }

        public static T Resole<T>() where T : class
        {
            return CurrentContainer.Resolve<T>();
        }

        public static T Resole<T>(string registerName) where T : class
        {
            return CurrentContainer.Resolve<T>(registerName);
        }

        public static IEnumerable<T> ResoleAll<T>() where T : class
        {
            return CurrentContainer.ResolveAll<T>();
        }

        public static bool IsRegisted<T>() where T : class
        {
            return CurrentContainer.IsRegistered<T>();
        }
    }
}
