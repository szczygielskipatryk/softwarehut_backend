using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.AspNetCore;
using KoronaWirusMonitor3.Models;

namespace KWMonitor.Validators
{
    public class DistrictValidator:AbstractValidator<District>
    {
        public DistrictValidator()
        {
            RuleFor(district => district.Name).NotEmpty().WithMessage("Nazwa powiatu nie może być pusta")
                .MinimumLength(3).WithMessage("Minimalna nazwa powiatu to 3 symbole");
            RuleFor(district => district.Region).NotEmpty().WithMessage("Region nie może być pusty");
        }
    }
}
