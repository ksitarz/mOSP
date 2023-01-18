using FluentValidation;

namespace mOSP.Application.Functions.Roles.Commands
{
    public class CreatedRoleCommandValidator : AbstractValidator<CreatedRoleCommand>
    {
        public CreatedRoleCommandValidator()
        {
            RuleFor(r => r.Name)
                .NotEmpty()
                .WithMessage("{PropertyName} is required")
                .NotNull();
        }
    }
}
