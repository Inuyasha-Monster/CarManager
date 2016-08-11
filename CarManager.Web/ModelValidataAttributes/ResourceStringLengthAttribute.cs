using CarManager.Web.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarManager.Web.ModelValidataAttributes
{
    public class ResourceStringLengthAttribute : StringLengthAttribute
    {
        public ResourceStringLengthAttribute(int maximumLength = 10, int minimumLength = 1) : base(maximumLength)
        {
            if (minimumLength <= 0) throw new ArgumentOutOfRangeException(nameof(minimumLength));
            this.MinimumLength = minimumLength;
            base.ErrorMessageResourceName = "StringLengthErrorMessage";
            base.ErrorMessageResourceType = typeof(Resources);
        }
    }
}