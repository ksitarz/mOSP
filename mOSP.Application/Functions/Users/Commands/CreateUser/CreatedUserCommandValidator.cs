using FluentValidation;

namespace mOSP.Application.Functions.Users.Commands
{
    public class CreatedUserCommandValidator : AbstractValidator<CreatedUserCommand>
    {
        public CreatedUserCommandValidator(bool emailInUse)
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

            RuleFor(u => u.ConfirmPassword)
               .Equal(e => e.Password);

            RuleFor(u => u.RoleId)
               .NotEmpty()
               .WithMessage("{PropertyName} is required")
               .NotNull();

            RuleFor(u => u.Email)
                .Custom((value, context) =>
                {
                    if (emailInUse)
                    {
                        context.AddFailure("Email", "That email is taken");
                    }
                });
        }
    }
}
