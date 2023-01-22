using FluentValidation.Results;
using mOSP.Application.Responses;

namespace mOSP.Application.Functions.Users.Commands
{
    public class CreatedUserCommandResponse : BaseResponse
    {
        public int? UserId { get; set; }

        public CreatedUserCommandResponse() : base()
        {
        }

        public CreatedUserCommandResponse(ValidationResult validationResult) : base(validationResult)
        {
        }

        public CreatedUserCommandResponse(string message) : base(message)
        {
        }

        public CreatedUserCommandResponse(string message, bool success) : base(message, success)
        {
        }

        public CreatedUserCommandResponse(int userId)
        {
            UserId = userId;
        }
    }
}