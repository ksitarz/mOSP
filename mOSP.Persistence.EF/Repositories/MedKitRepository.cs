using mOSP.Application.Common;
using mOSP.Application.Contracts.Persistence;
using mOSP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mOSP.Persistence.EF.Repositories
{
    public class MedKitRepository : BaseRepository<MedKit>, IMedKitRepository
    {
        public MedKitRepository(mOSPContext dbContext) : base(dbContext)
        {
        }

        public Task<List<MedKit>> GetMedKitWithItem(SearchMedItemOptions searchOptions)
        {
            throw new NotImplementedException();
        }
    }
}
