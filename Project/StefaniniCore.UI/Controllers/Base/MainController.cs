using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net;

namespace StefaniniCore.UI.Controllers
{
    public abstract class MainController : Controller
    {
        protected IActionResult SuccessMessage(string message, int? id, bool refreshPage)
        {
            return GeneralMessage(message, id, refreshPage, HttpStatusCode.OK);
        }

        protected IActionResult ErrorMessage(string message, ILogger<TasksController> logger)
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

        protected IActionResult ErrorGlobalMessage()
        {
            return GeneralMessage("Não foi possível completar esta operação. Tente mais tarde."
                                 , null, false, HttpStatusCode.InternalServerError);
        }

        private IActionResult GeneralMessage(string message, int? id, bool refreshPage, HttpStatusCode statusCode)
        {
            if (statusCode != HttpStatusCode.OK)
            {
                return BadRequest(new
                {
                    message,
                    id,
                    refreshPage,
                    statusCode = (int)statusCode
                });
            }

            return Ok(new
            {
                message,
                id,
                refreshPage,
                statusCode = (int)statusCode
            });
        }
    }
}
