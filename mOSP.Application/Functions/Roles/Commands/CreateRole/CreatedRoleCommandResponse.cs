using FluentValidation.Results;
using mOSP.Application.Responses;

namespace mOSP.Application.Functions.Roles.Commands
{
    public class CreatedRoleCommandResponse : BaseResponse
    {
        public int? RoleId { get; set; }

        public CreatedRoleCommandResponse() : base()
        {
        }

        public CreatedRoleCommandResponse(ValidationResult validationResult) : base(validationResult)
        {
        }

        public CreatedRoleCommandResponse(string message) : base(message)
        {
        }

        public CreatedRoleCommandResponse(string message, bool success) : base(message, success)
        {
        }

        public CreatedRoleCommandResponse(int roleId)
        {
            RoleId = roleId;
        }
    }
}