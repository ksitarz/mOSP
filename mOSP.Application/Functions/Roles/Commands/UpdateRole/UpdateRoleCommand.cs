using MediatR;

namespace mOSP.Application.Functions.Roles.Commands
{
    public class UpdateRoleCommand : IRequest
    {
        public int RoleId { get; set; }
        public string Name { get; set;}
    }
}
