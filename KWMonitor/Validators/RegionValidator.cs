using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using KoronaWirusMonitor3.Models;

namespace KWMonitor.Validators
{
    public class RegionValidator :AbstractValidator<Region>

    {
        public RegionValidator()
        {
            RuleFor(region => region.Name).NotEmpty().WithMessage("Region nie powinien być pusty")
                .MinimumLength(3).WithMessage("Minimalna długość regionu to 3");
            RuleFor(region => region.Country).NotEmpty().WithMessage("Kraj nie może być pusty");
        }

    }
}
