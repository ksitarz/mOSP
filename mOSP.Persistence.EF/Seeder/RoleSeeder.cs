using mOSP.Domain.Entities;
using System.Collections.Generic;

namespace mOSP.Persistence.EF.Seeder
{
    public class RoleSeeder
    {
        public static List<Role> Get()
        {
            Role user = new Role()
            {
                RoleId= 1,
                Name = "User"
            };

            Role manager = new Role()
            {
                RoleId= 2,
                Name = "Manager"
            };
            Role admin = new Role()
            {
                RoleId= 3,
                Name = "Admin"
            };

            List<Role> roles = new List<Role>();
            roles.Add(user);
            roles.Add(manager);
            roles.Add(admin);

            return roles;
        }
    }
}
