using MediatR;
using System;

namespace mOSP.Application.Functions.MedItems.Commands
{
    public class CreatedMedItemCommand : IRequest<CreatedMedItemCommandResponse>
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }

        public int ContainerId { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsIgnored { get; set; }
    }
}
