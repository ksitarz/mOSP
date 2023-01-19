using mOSP.Application.Contracts.Persistence;
using mOSP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mOSP.Persistence.EF.Repositories
{
    public class RoleRepository : BaseRepository<Role>, IRoleRepository
    {
        public RoleRepository(mOSPContext dbContext) : base(dbContext)
        {
        }
    }
}
