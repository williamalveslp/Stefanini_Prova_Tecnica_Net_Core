using System.Net;

namespace StefaniniCore.Application.Responses
{
    /// <summary>
    /// Response with error data.
    /// </summary>
    public class ErrorResponse
    {
        public string ErrorMessage { get; private set; }

        public HttpStatusCode StatusCode { get; private set; }

        public ErrorResponse(string errorMessage, HttpStatusCode statusCode)
        {
            this.ErrorMessage = errorMessage;
            this.StatusCode = statusCode;
        }
    }
}
