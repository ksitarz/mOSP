﻿using FluentValidation.Results;
using mOSP.Application.Responses;

namespace mOSP.Application.Functions.OSPs.Commands
{
    public class CreatedOSPCommandResponse : BaseResponse
    {
        public int? OspId { get; set; }

        public CreatedOSPCommandResponse() : base()
        {
        }

        public CreatedOSPCommandResponse(ValidationResult validationResult) : base(validationResult)
        {
        }

        public CreatedOSPCommandResponse(string message) : base(message)
        {
        }

        public CreatedOSPCommandResponse(string message, bool success) : base(message, success)
        {
        }

        public CreatedOSPCommandResponse(int ospId)
        {
            OspId = ospId;
        }
    }
}
