using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StefaniniCore.API.Controllers.Base;
using StefaniniCore.Application.AppInterfaces;
using StefaniniCore.Application.InputModels.Tasks;
using StefaniniCore.Application.Responses;
using StefaniniCore.Application.Responses.Tasks;
using StefaniniCore.Application.ViewModels;
using System;
using System.Net;
using System.Threading.Tasks;

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

        // api/Tasks/5
        /// <summary>
        /// List of Tasks by Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(TaskDetailViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorResponse), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetById(int id)
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

        // api/Tasks
        /// <summary>
        ///  Insert the Task.
        /// </summary>
        /// <param name="inputModel"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(TaskDetailResponse), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorResponse), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Insert([FromBody] TaskInputModel inputModel)
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

        // api/Tasks
        /// <summary>
        /// Update the Task.
        /// </summary>
        /// <param name="inputModel"></param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(typeof(TaskDetailResponse), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorResponse), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Update([FromBody] TaskInputModel inputModel)
        {
            try
            {
                return ResponseOk(await _appService.Save(inputModel));
            }
            catch (Exception ex)
            {
                return ResponseWithError(_logger, ex);
            }
        }

        // api/Tasks
        /// <summary>
        /// List of Tasks.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(TaskListResponse), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorResponse), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Get()
        {
            try
            {
                return ResponseOk(await _appService.GetAll());
            }
            catch (Exception ex)
            {
                return ResponseWithError(_logger, ex);
            }
        }

        // api/Tasks
        /// <summary>
        /// Delete the Task by Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorResponse), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                _appService.DeleteById(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return ResponseWithError(_logger, ex);
            }
        }
    }
}
