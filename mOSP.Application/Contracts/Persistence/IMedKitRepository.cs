﻿using mOSP.Application.Common;
using mOSP.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace mOSP.Application.Contracts.Persistence
{
    public interface IMedKitRepository : IAsyncRepository<MedKit>
    {
        Task<List<MedKit>> GetMedKitWithItem(int containerId, SearchMedItemOptions searchOptions);
    }

}
