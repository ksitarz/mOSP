using MediatR;
using System.Collections.Generic;

namespace mOSP.Application.Functions.Roles.Queries
{
    public class GetAllRoleQuery : IRequest<List<RoleViewModel>>
    {
    }
}