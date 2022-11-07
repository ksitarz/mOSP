using Microsoft.EntityFrameworkCore;
using mOSP.Application.Common;
using mOSP.Application.Contracts.Persistence;
using mOSP.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mOSP.Persistence.EF.Repositories
{
    public class MedKitRepository : BaseRepository<MedKit>, IMedKitRepository
    {
        public MedKitRepository(mOSPContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<MedKit>> GetMedKitWithItem(int containerId, SearchMedItemOptions searchOptions)
        {
            var medKit = await _dbContext.MedKits
                .Where(k => k.ContainerId == containerId)
                .Include(k => k.Items.Where(i => i.ContainerId == containerId))
                .ToListAsync();

            return medKit;
        }
    }
}
