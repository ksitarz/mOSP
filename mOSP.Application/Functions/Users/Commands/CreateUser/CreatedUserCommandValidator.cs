using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mOSP.Application.Functions.Users.Commands
{
    public class CreatedUserCommandValidator : AbstractValidator<CreatedUserCommand>
    {
        public CreatedUserCommandValidator()
        {
            RuleFor(u => u.Email)
               .NotEmpty()
               .WithMessage("{PropertyName} is required")
               .EmailAddress()
               .NotNull();

            RuleFor(u => u.FirstName)
               .NotEmpty()
               .WithMessage("{PropertyName} is required")
               .Length(0, 15)
               .NotNull();

            RuleFor(u => u.LastName)
               .NotEmpty()
               .WithMessage("{PropertyName} is required")
               .Length(0, 15)
               .NotNull();

            RuleFor(u => u.Password)
               .NotEmpty()
               .WithMessage("{PropertyName} is required")
               .MinimumLength(8)
               .NotNull();

            RuleFor(u => u.RoleId)
               .NotEmpty()
               .WithMessage("{PropertyName} is required")
               .NotNull();
        }
    }
}
