using MediatR;

namespace mOSP.Application.Functions.Roles.Commands
{
    public class DeleteRoleCommand : IRequest
    {
        public int RoleId { get; set; }
    }
}
