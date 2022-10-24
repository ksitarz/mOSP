using FluentValidation.Results;
using mOSP.Application.Responses;

namespace mOSP.Application.Functions.MedItems.Commands
{
    public class CreatedMedItemCommandResponse : BaseResponse
    {
        public int? ItemId { get; set; }

        public CreatedMedItemCommandResponse() : base()
        {
        }

        public CreatedMedItemCommandResponse(ValidationResult validationResult) : base(validationResult)
        {
        }

        public CreatedMedItemCommandResponse(string message) : base(message)
        {
        }

        public CreatedMedItemCommandResponse(string message, bool success) : base(message, success)
        {
        }

        public CreatedMedItemCommandResponse(int itemId)
        {
            ItemId = itemId;
        }
    }
}
