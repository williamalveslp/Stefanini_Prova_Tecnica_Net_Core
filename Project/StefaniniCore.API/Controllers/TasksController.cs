using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StefaniniCore.API.Controllers.Base;
using StefaniniCore.Application.AppInterfaces;
using StefaniniCore.Application.InputModels.Tasks;
using System;
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
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                return Ok(_appService.GetById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // api/Tasks
        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] TaskInputModel inputModel)
        {
            try
            {
                return Created("/api/Tasks", _appService.Save(inputModel));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] TaskInputModel inputModel)
        {
            try
            {
                return Created("/api/Tasks", _appService.Save(inputModel));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // api/Tasks
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(_appService.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // api/Tasks
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                _appService.DeleteById(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
