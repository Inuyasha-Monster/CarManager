using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager.Core.Infrastructure
{
    public interface IDependencyRegister
    {
        void RegisterTypes(IUnityContainer unityContainer);
    }
}
