using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mOSP.Application.Functions.MedItems.Commands
{
    public class CreatedMedItemCommandValidator : AbstractValidator<CreatedMedItemCommand>
    {
        public CreatedMedItemCommandValidator()
        {
                RuleFor(i => i.Name)
                .NotEmpty()
                .WithMessage("{PropertyName} is required")
                .NotNull();

                RuleFor(i => i.ExpirationDate)
                .NotEmpty()
                .WithMessage("{PropertyName} is required")
                .NotNull()
                .GreaterThan(DateTime.Now);
        }
    }
}
