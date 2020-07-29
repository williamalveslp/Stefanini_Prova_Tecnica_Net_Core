using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StefaniniCore.Application.Responses;
using System;
using System.Net;

namespace StefaniniCore.API.Controllers.Base
{
    public abstract class MainController : ControllerBase
    {
        /// <summary>
        /// Use for 2xx (Ok) responses.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        protected IActionResult ResponseOk<T>(T entity)
        {
            return Ok(new ResponseData<T>(entity));
        }

        /// <summary>
        /// User for BadRequest.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="logger"></param>
        /// <param name="ex"></param>
        /// <returns></returns>
        protected IActionResult ResponseWithError<T>(ILogger<T> logger, Exception ex)
        {
            LogError(logger, ex);

            ErrorResponse viewModel = new ErrorResponse(ex.Message, HttpStatusCode.BadRequest);
            return BadRequest(viewModel);
        }

        /// <summary>
        /// User for specific Http Status.
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="ex"></param>
        /// <param name="httpStatusCode"></param>
        /// <returns></returns>
        protected IActionResult ResponseWithError(ILogger<TasksController> logger, Exception ex, HttpStatusCode httpStatusCode)
        {
            LogError(logger, ex);

            ErrorResponse viewModel = new ErrorResponse(ex.Message, httpStatusCode);

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

        private class ResponseData<T>
        {
            public T Data { get; private set; }

          //  public HttpStatusCode StatusCode { get; private set; }

            // , HttpStatusCode statusCode
            public ResponseData(T data)
            {
                this.Data = data;
            //    this.StatusCode = statusCode;
            }
        }
    }
}
