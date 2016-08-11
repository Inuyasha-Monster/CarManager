using FluentValidation;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarManager.Web.FulentValidationModels
{
    public class UnityValidatorFactory : ValidatorFactoryBase
    {
        private IUnityContainer unityContainer;

        public UnityValidatorFactory(IUnityContainer unityContainer)
        {
            this.unityContainer = unityContainer;
        }

        public override IValidator CreateInstance(Type validatorType)
        {
            IValidator validator;
            try
            {
                validator = unityContainer.Resolve(validatorType, validatorType.GetGenericArguments().First().FullName) as IValidator;
            }
            catch
            {
                validator = null;
            }
            return validator;
        }
    }
}