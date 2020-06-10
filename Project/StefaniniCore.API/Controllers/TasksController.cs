using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StefaniniCore.API.Controllers.Base;
using StefaniniCore.Application.AppInterfaces;
using System.Threading.Tasks;

namespace StefaniniCore.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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
        [HttpGet("{taskId}")]
        public async Task<IActionResult> GetById(int taskId)
        {
            return Ok(_appService.GetById(taskId));
        }

        // api/Tasks
        [HttpGet()]
        public async Task<IActionResult> Get()
        {
            return Ok(_appService.GetAll());
        }
    }
}
