using Entities.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidatior
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.DailyPrice).NotNull();
            RuleFor(p => p.ModelYear).Must(NotBigger);
        }
        private bool NotBigger(int arg) 
        { 
            return arg<DateTime.Now.Year ? true : false;
        }
    }
}
