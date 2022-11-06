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

        public Task<List<OSP>> GetOspWithMedKit()
        {
            throw new NotImplementedException();
        }
    }
}
