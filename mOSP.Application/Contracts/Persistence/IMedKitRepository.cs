using mOSP.Application.Common;
using mOSP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mOSP.Application.Contracts.Persistence
{
    public interface IMedKitRepository : IAsyncRepository<MedKit>
    {
        Task<List<MedKit>> GetMedKitWithItem(SearchMedItemOptions searchOptions);
    }

}
