using MediatR;

namespace mOSP.Application.Functions.Users.Commands.CreateUser
{
    public class CreatedUserCommand : IRequest<CreatedUserCommandResponse>
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

    }
}
