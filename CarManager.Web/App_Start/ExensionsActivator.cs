using CarManager.Core.Infrastructure;
using CarManager.Web.FulentValidationModels;
using CarManager.Web.MvcExtends;
using CarManager.Web.Properties;
using FluentValidation;
using FluentValidation.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(CarManager.Web.App_Start.ExensionsActivator), "Start")]

namespace CarManager.Web.App_Start
{
    public static class ExensionsActivator
    {
        public static void Start()
        {
            System.Web.Mvc.DataAnnotationsModelValidatorProvider.AddImplicitRequiredAttributeForValueTypes = false;
            System.Web.Mvc.ModelValidatorProviders.Providers.Add(new FluentValidation.Mvc.FluentValidationModelValidatorProvider()
            {
                ValidatorFactory = new UnityValidatorFactory(UnityConfig.GetConfiguredContainer())
            });
            FluentValidationModelValidatorProvider.Configure();
            ValidatorOptions.ResourceProviderType = typeof(Resources);

            // 重置验证器本地化
            FluentValidation.ValidatorOptions.DisplayNameResolver = (type, memberInfo, lambdaExpression) =>
            {
                var key = type.Name + memberInfo.Name + "DisplayName";
                var displayName = Resources.ResourceManager.GetString(key);
                return displayName;
            };

            // 重写模型元数据本地化
            System.Web.Mvc.ModelMetadataProviders.Current = new CustomModelMetadataProvider();
        }
    }
}