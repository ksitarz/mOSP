using MediatR;
using mOSP.Application.Common;
using System.Collections.Generic;

namespace mOSP.Application.Functions.MedKits
{
    public class GetMedKitWithItemListQuery : IRequest<List<MedKitViewModel>>
    {
        public SearchMedItemOptions SearchOptions { get; set; }
    }
}
