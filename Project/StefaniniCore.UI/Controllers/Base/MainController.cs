using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net;

namespace StefaniniCore.UI.Controllers
{
    public abstract class MainController : Controller
    {
        protected IActionResult SuccessMessage(string message, int? id, bool refreshPage, string urlToRedirect = null)
        {
            return GeneralMessage(message, id, refreshPage, HttpStatusCode.OK, urlToRedirect);
        }

        protected IActionResult ErrorMessage(string message, ILogger<object> logger)
        {
            logger.LogError("Error ocorreu.");
            return GeneralMessage(message, null, false, HttpStatusCode.BadRequest);
        }

        protected IActionResult ConflictMessage(string message)
        {
            return GeneralMessage(message, null, false, HttpStatusCode.InternalServerError);
        }

        protected IActionResult RequiredFieldsMessage(string message)
        {
            return GeneralMessage(message, null, false, HttpStatusCode.BadRequest);
        }

        private IActionResult GeneralMessage(string message, int? id, bool refreshPage, HttpStatusCode statusCode
                                            , string urlToRedirect = null)
        {
            if (statusCode != HttpStatusCode.OK)
            {
                return BadRequest(new
                {
                    message,
                    id,
                    refreshPage,
                    statusCode = (int)statusCode,
                    urlToRedirect
                });
            }

            return Ok(new
            {
                message,
                id,
                refreshPage,
                statusCode = (int)statusCode,
                urlToRedirect
            });
        }
    }
}
