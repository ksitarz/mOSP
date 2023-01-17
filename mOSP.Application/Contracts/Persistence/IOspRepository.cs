using mOSP.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace mOSP.Application.Contracts.Persistence
{
    public interface IOspRepository : IAsyncRepository<OSP>
    {
        Task<List<OSP>> GetOspWithContainers(int OspId);
    }
}
