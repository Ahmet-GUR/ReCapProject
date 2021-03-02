using Entities.Concrate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(ca => ca.DailyPrice).GreaterThan(0);
            RuleFor(ca => ca.Description).NotEmpty();
            RuleFor(ca => ca.ModelYear).NotEmpty();
        }
    }
}
