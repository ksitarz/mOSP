using mOSP.Application.Contracts.Persistence;
using mOSP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mOSP.Persistence.EF.Repositories
{
    public class MedItemRepository : BaseRepository<MedItem>, IMedItemRepository
    {
        public MedItemRepository(mOSPContext dbContext) : base(dbContext)
        {
        }
    }
}
