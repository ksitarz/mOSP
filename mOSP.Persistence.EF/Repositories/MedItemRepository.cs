using mOSP.Application.Contracts.Persistence;
using mOSP.Domain.Entities;

namespace mOSP.Persistence.EF.Repositories
{
    public class MedItemRepository : BaseRepository<MedItem>, IMedItemRepository
    {
        public MedItemRepository(mOSPContext dbContext) : base(dbContext)
        {
        }
    }
}
