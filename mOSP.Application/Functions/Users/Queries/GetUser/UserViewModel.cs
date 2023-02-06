using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mOSP.Application.Functions.Users.Queries.GetUser
{
    public class UserViewModel
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string ConfirmPassword { get; set; }

        public RoleDto Role { get; set; }

        public OspDto Osp { get; set; }
    }
}
