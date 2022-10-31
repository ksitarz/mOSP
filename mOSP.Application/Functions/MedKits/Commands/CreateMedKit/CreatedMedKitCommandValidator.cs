using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mOSP.Application.Functions.MedKits.Commands
{
    public class CreatedMedKitCommandValidator : AbstractValidator<CreatedMedKitCommand>
    {
        public CreatedMedKitCommandValidator()
        {
            RuleFor(k => k.Name)
                .NotEmpty()
                .WithMessage("{PropertyName} is required")
                .NotNull();

            RuleFor(k => k.OspId)
                .NotEmpty()
                .WithMessage("{PropertyName} is required")
                .NotNull();

            RuleFor(k => k.ContainerType)
                .NotEmpty()
                .WithMessage("{PropertyName} is required")
                .NotNull();
        }
    }
}
