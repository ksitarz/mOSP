using MediatR;
using System.Collections.Generic;

namespace mOSP.Application.Functions.MedItems
{
    public class GetMedItemByContainerQuery : IRequest<List<MedItemViewModel>>
    {
        public int ContainerId { get; set; }
    }
}
