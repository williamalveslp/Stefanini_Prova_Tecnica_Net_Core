using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StefaniniCore.API.Controllers.Base;
using StefaniniCore.Application.AppInterfaces;
using StefaniniCore.Application.InputModels.Tasks;
using StefaniniCore.Application.Responses;
using StefaniniCore.Application.ViewModels;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Net;

namespace StefaniniCore.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class TasksController : MainController
    {
        private readonly ILogger<TasksController> _logger;
        private readonly ITaskAppService _appService;

        public TasksController(ILogger<TasksController> logger, ITaskAppService appService)
        {
            this._logger = logger;
            this._appService = appService;
        }

        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "List of Tasks by Id.")]
        [ProducesResponseType(typeof(TaskDetailViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorResponse), (int)HttpStatusCode.BadRequest)]
        public IActionResult GetById(int id)
        {
            try
            {
                return ResponseOk(_appService.GetById(id));
            }
            catch (Exception ex)
            {
                return ResponseWithError(_logger, ex);
            }
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Insert the Task.")]
        [ProducesResponseType(typeof(TaskDetailViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorResponse), (int)HttpStatusCode.BadRequest)]       
        public IActionResult Insert([FromBody] TaskInputModel inputModel)
        {
            try
            {
                return ResponseOk(_appService.Save(inputModel));
            }
            catch (Exception ex)
            {
                return ResponseWithError(_logger, ex);
            }
        }

        [HttpPut]
        [SwaggerOperation(Summary = "Update the Task")]
        [ProducesResponseType(typeof(TaskDetailViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorResponse), (int)HttpStatusCode.BadRequest)]
        public IActionResult Update([FromBody] TaskInputModel inputModel)
        {
            try
            {
                return ResponseOk(_appService.Save(inputModel));
            }
            catch (Exception ex)
            {
                return ResponseWithError(_logger, ex);
            }
        }

        [HttpGet]
        [SwaggerOperation(Summary = "List of Tasks.")]
        [ProducesResponseType(typeof(TaskListViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorResponse), (int)HttpStatusCode.BadRequest)]
        public IActionResult Get()
        {
            try
            {
                return ResponseOk(_appService.GetAll());
            }
            catch (Exception ex)
            {
                return ResponseWithError(_logger, ex);
            }
        }

        [HttpDelete("{id}")]
        [SwaggerOperation(Summary = " Delete the Task by Id.")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorResponse), (int)HttpStatusCode.BadRequest)]
        public IActionResult Delete(int id)
        {
            try
            {
                _appService.DeleteById(id);
                return ResponseOkEmpty();
            }
            catch (Exception ex)
            {
                return ResponseWithError(_logger, ex);
            }
        }
    }
}
