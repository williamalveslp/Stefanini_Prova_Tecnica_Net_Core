using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Net;

namespace StefaniniCore.UI.Controllers
{
    public abstract class MainController : Controller
    {
        public IActionResult SuccessMessage(string message, int? id, bool refreshPage, string urlToRedirect = null)
        {
            return GeneralMessage(message, id, refreshPage, HttpStatusCode.OK, urlToRedirect);
        }

        public IActionResult ErrorMessage<T>(ILogger<T> logger, Exception ex)
        {
            logger.LogError($"Error: {ex.Message}\r\nStackTrace: {ex.StackTrace}\r\n\r\n");
            return GeneralMessage(ex.Message, null, false, HttpStatusCode.BadRequest);
        }

        private IActionResult GeneralMessage(string message, int? id, bool refreshPage, HttpStatusCode statusCode
                                            , string urlToRedirect = null)
        {
            var objectToUI = ObjectToUI(message, id, refreshPage, statusCode, urlToRedirect);

            if (statusCode != HttpStatusCode.OK)
                return BadRequest(objectToUI);

            return Ok(objectToUI);
        }

        private object ObjectToUI(string message, int? id, bool refreshPage, HttpStatusCode statusCode
                                            , string urlToRedirect = null)
        {
            return new
            {
                message,
                id,
                refreshPage,
                statusCode = (int)statusCode,
                urlToRedirect
            };
        }
    }
}
