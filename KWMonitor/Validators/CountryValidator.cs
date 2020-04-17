using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Results;
using KoronaWirusMonitor3.Models;

namespace KWMonitor.Validators
{
    public class CountryValidator :AbstractValidator<Country>
    {
        public CountryValidator()
        {
            RuleFor(country => country.Name).NotEmpty().WithMessage("Nazwa kraju nie może być pusta")
                .MinimumLength(3).WithMessage("Nazwa kraju powinna być dłuższa niż 3 znaki")
                .MaximumLength(20).WithMessage("Nazwa kraju powinna być krótsza niż 20 znaków");
            RuleFor(country => country.Shortcut).NotEmpty().WithMessage("Nie wpisano skrótu");
        }

    }
}
