using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mOSP.Application.Functions.OSPs.Queries
{
    public class GetOSPWithMedKitListQuery : IRequest<List<OSPWithMedKitsViewModel>>
    {
        public int OspId { get; set; }
    }
}
