using CarManager.Web.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarManager.Web.MvcExtends
{
    public class CustomModelMetadataProvider : DataAnnotationsModelMetadataProvider
    {
        protected override ModelMetadata CreateMetadata(IEnumerable<Attribute> attributes, Type containerType, Func<object> modelAccessor, Type modelType, string propertyName)
        {
            var metedata = base.CreateMetadata(attributes, containerType, modelAccessor, modelType, propertyName);
            if (containerType != null)
            {
                var key = containerType.Name.Replace(".", string.Empty) + propertyName + nameof(metedata.DisplayName);
                var disPlayName = Resources.ResourceManager.GetString(key);
                if (!string.IsNullOrWhiteSpace(disPlayName))
                {
                    metedata.DisplayName = disPlayName;
                }
            }
            return metedata;
        }
    }
}