using CarManager.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;
using System.Reflection;
using AutoMapper;

namespace CarManager.Web.MvcExtends
{
    public class AutoMapperRegister : IDependencyRegister
    {
        public void RegisterTypes(IUnityContainer unityContainer)
        {
            var profiles = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.IsClass && t.IsSubclassOf(typeof(Profile)));

            var profileInstances = profiles.Select(x => Activator.CreateInstance(x)).Cast<Profile>();

            var mapperConfig = new MapperConfiguration(config => profileInstances.ToList().ForEach(p => config.AddProfile(p)));

            var mapper = mapperConfig.CreateMapper();

            unityContainer.RegisterInstance(mapperConfig);

            unityContainer.RegisterInstance<IMapper>(mapper);
        }
    }
}