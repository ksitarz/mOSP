using mOSP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mOSP.Application.Contracts.Persistence
{
    public interface IOspRepository : IAsyncRepository<OSP>
    {
    }
}
