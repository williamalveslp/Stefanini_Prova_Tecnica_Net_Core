using System.Net;

namespace StefaniniCore.API.Swagger.ResponseTypes
{
    /// <summary>
    /// View Model to send error informations.
    /// </summary>
    public class ErrorViewModel
    {
        public string ErrorMessage { get; private set; }

        public HttpStatusCode StatusCode { get; private set; }

        public ErrorViewModel(string errorMessage, HttpStatusCode statusCode)
        {
            this.ErrorMessage = errorMessage;
            this.StatusCode = statusCode;
        }
    }
}
