using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mOSP.Application.Functions.Roles.Queries
{
    public class GetAllRoleQuery : IRequest<List<RoleViewModel>>
    {
        public int RoleID { get; set; }
    }
}
