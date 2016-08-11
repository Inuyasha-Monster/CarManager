using CarManager.Web.Models.Cars;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarManager.Web.FulentValidationModels
{
    public class CarValidator : AbstractValidator<CarViewModel>
    {
        public CarValidator()
        {
            this.RuleFor(x => x.Name).NotEmpty().Length(1, 5);
            this.RuleFor(x => x.Email).NotEmpty().EmailAddress();
            this.RuleFor(x => x.Price).NotEmpty().GreaterThanOrEqualTo(1000m);
        }
    }
}