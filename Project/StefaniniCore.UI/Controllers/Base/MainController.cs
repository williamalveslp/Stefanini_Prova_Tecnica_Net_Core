using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net;

namespace StefaniniCore.UI.Controllers
{
    public abstract class MainController : Controller
    {
        public IActionResult SuccessMessage(string message, int? id, bool refreshPage, string urlToRedirect = null)
        {
            return GeneralMessage(message, id, refreshPage, HttpStatusCode.OK, urlToRedirect);
        }

        public IActionResult ErrorMessage(string message, ILogger<object> logger = null)
        {
            if (logger != null)
                logger.LogError($"[Erro] {message}");

            return GeneralMessage(message, null, false, HttpStatusCode.BadRequest);
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
