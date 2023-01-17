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
                Name = "User"
            };

            Role manager = new Role()
            {
                Name = "Manager"
            };
            Role admin = new Role()
            {
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
