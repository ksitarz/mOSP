using FluentValidation.Results;
using System.Collections.Generic;

namespace mOSP.Application.Responses
{
    public class BaseResponse
    {
        public ResponseStatus Status { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
        public List<string> ValidationErrors { get; set; }

        public BaseResponse()
        {
            ValidationErrors = new List<string>();
            Success = true;
        }

        public BaseResponse(string message = null)
        {
            ValidationErrors = new List<string>();
            Success = true;
            Message = message;
        }

        public BaseResponse(string message, bool success)
        {
            ValidationErrors = new List<string>();
            Success=success;
            Message = message;
        }

        public BaseResponse(ValidationResult validationResult)
        {
            ValidationErrors = new List<string>();
            Success = validationResult.Errors.Count < 0;
            foreach (var error in validationResult.Errors)
            {
                ValidationErrors.Add(error.ErrorMessage);
            }
        }
    }

    public enum ResponseStatus
    {
        Success = 0,
        NotFound = 1,
        BadQuery = 2,
        ValidationError = 3
    }
}
