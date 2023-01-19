using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mOSP.Application.Functions.Roles.Queries
{
    public class GetRoleQuery : IRequest<RoleViewModel>
    {
        public int RoleID { get; set; }
    }
}
