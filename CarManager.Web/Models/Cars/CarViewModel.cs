using CarManager.Web.FulentValidationModels;
using CarManager.Web.ModelValidataAttributes;
using CarManager.Web.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarManager.Web.Models.Cars
{
    //[FluentValidation.Attributes.Validator(typeof(CarValidator))]
    public class CarViewModel
    {

        //[DisplayName("车名字")]
        //[Required(AllowEmptyStrings = false)]
        //[StringLength(maximumLength: 10, MinimumLength = 1, ErrorMessageResourceName = "StringLengthErrorMessage", ErrorMessageResourceType = typeof(Resources))]
        public string Name { get; set; }
        //[ResourceStringLength(5)]


        //[Display(Name = "车价格")]
        public decimal Price { get; set; }

        public string Email { get; set; }
    }
}