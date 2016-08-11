using CarManager.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using CarManager.Service.Cars;

namespace CarManager.Service
{
    public class ServiceRegister : IDependencyRegister
    {
        public void RegisterTypes(IUnityContainer unityContainer)
        {
            unityContainer.RegisterType<ICarService, CarService>();
        }
    }
}
