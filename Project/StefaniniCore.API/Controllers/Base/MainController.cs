using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StefaniniCore.API.Swagger.ResponseTypes;
using System;
using System.Net;

namespace StefaniniCore.API.Controllers.Base
{
    public abstract class MainController : ControllerBase
    {
        protected IActionResult ResponseWithError<T>(ILogger<T> logger, Exception ex)
        {
            LogError(logger, ex);

            ErrorViewModel viewModel = new ErrorViewModel(ex.Message, HttpStatusCode.BadRequest);
            return BadRequest(viewModel);
        }

        protected IActionResult ResponseWithError(ILogger<TasksController> logger, Exception ex, HttpStatusCode httpStatusCode)
        {
            LogError(logger, ex);

            ErrorViewModel viewModel = new ErrorViewModel(ex.Message, httpStatusCode);

            switch (httpStatusCode)
            {
                case HttpStatusCode.BadRequest:
                    return StatusCode((int)HttpStatusCode.BadRequest, viewModel);

                case HttpStatusCode.Forbidden:
                    return StatusCode((int)HttpStatusCode.Forbidden, viewModel);

                case HttpStatusCode.NotFound:
                    return StatusCode((int)HttpStatusCode.NotFound, viewModel);

                case HttpStatusCode.InternalServerError:
                    return StatusCode((int)HttpStatusCode.InternalServerError, viewModel);

                default:
                    return StatusCode((int)HttpStatusCode.BadRequest, viewModel);
            }
        }

        private void LogError<T>(ILogger<T> logger, Exception ex)
        {
            logger.LogError($"Error: {ex.Message}\r\nStackTrace: {ex.StackTrace}\r\n\r\n");
        }
    }
}
