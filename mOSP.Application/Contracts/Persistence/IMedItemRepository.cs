﻿using mOSP.Domain.Entities;

namespace mOSP.Application.Contracts.Persistence
{
    public interface IMedItemRepository : IAsyncRepository<MedItem>
    {
    }
}
