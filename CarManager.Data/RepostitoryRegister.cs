using CarManager.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using CarManager.Core.Data;

namespace CarManager.Data
{
    public class RepostitoryRegister : IDependencyRegister
    {
        public void RegisterTypes(IUnityContainer unityContainer)
        {
            unityContainer.RegisterType<IDbContext, CarDbContext>(new PerThreadLifetimeManager());
            unityContainer.RegisterType(typeof(IRepository<>), typeof(EfRepository<>));
        }
    }
}
