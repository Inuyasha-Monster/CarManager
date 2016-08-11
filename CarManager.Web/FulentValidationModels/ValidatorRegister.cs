using CarManager.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices.Unity;
using System.Reflection;
using FluentValidation;

namespace CarManager.Web.FulentValidationModels
{
    public class ValidatorRegister : IDependencyRegister
    {
        public void RegisterTypes(IUnityContainer unityContainer)
        {
            var validatorTypes = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IValidator<>)));
            foreach (var item in validatorTypes)
            {
                unityContainer.RegisterType(typeof(IValidator<>), item, item.BaseType.GetGenericArguments().First().FullName, new ContainerControlledLifetimeManager());
            }
        }
    }
}