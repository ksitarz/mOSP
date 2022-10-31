using FluentValidation.Results;
using mOSP.Application.Responses;

namespace mOSP.Application.Functions.MedKits.Commands
{
    public class CreatedMedKitCommandResponse : BaseResponse
    {
        public int? ContainerId { get; set; }

        public CreatedMedKitCommandResponse() : base()
        {
        }

        public CreatedMedKitCommandResponse(ValidationResult validationResult) : base(validationResult)
        {
        }

        public CreatedMedKitCommandResponse(string message) : base(message)
        {
        }

        public CreatedMedKitCommandResponse(string message, bool success) : base(message, success)
        {
        }

        public CreatedMedKitCommandResponse(int itemId)
        {
            ContainerId = itemId;
        }
    }
}
