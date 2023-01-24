using Microsoft.EntityFrameworkCore;
using mOSP.Application.Contracts.Persistence;
using mOSP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mOSP.Persistence.EF.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(mOSPContext dbContext) : base(dbContext)
        {
        }

        public async Task<bool> EmailInUse(string email)
        {
            return await _dbContext.Users.AnyAsync(u => u.Email == email);
  
        }
    }
}
