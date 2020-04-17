using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using KoronaWirusMonitor3.Models;

namespace KWMonitor.Validators
{
    public class CityValidator :AbstractValidator<City>
    {
        public CityValidator()
        {
            RuleFor(city => city.Name).NotEmpty().WithMessage("Nazwa miasta nie może być pusta")
                .MinimumLength(3).WithMessage("Nazwa miasta musi być większa od 3 znaków");
            RuleFor(city => city.District).NotEmpty().WithMessage("Powiat nie może być pusty");
        }
    }
}
