using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mOSP.Application.Functions.OSPs.Commands
{
    public class CreatedOSPCommandValidator : AbstractValidator<CreatedOSPCommand>
    {
        public CreatedOSPCommandValidator()
        {
            RuleFor(o => o.Name)
                .NotEmpty()
                .WithMessage("{PropertyName} is required")
                .NotNull();
        }
    }
}
