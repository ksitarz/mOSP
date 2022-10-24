using MediatR;

namespace mOSP.Application.Functions.MedItems.Commands
{
    public class DeleteMedItemCommand : IRequest
    {
        public int ItemId { get; set; }
    }
}
