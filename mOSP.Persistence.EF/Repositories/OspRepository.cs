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
    public class OspRepository : BaseRepository<OSP>, IOspRepository
    {
        public OspRepository(mOSPContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<OSP>> GetOspWithMedKit(int ospId)
        {
            var osp = await _dbContext.Osps
               .Where(o => o.OspId == ospId)
               .Include(o => o.Containers.Where(k =>k.OspId == ospId))
               .ToListAsync();

            return osp;
        }
    }
}
