using MediatR;

namespace mOSP.Application.Functions.Roles.Commands
{
    public class CreatedRoleCommand : IRequest<CreatedRoleCommandResponse>
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
    }
}
