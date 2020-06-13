using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StefaniniCore.API.Controllers.Base;
using StefaniniCore.Application.AppInterfaces;
using System;
using System.Threading.Tasks;

namespace StefaniniCore.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class ProfileTypesController : MainController
    {
        private readonly ILogger<ProfileTypesController> _logger;
        private readonly IProfileTypeAppService _appService;

        public ProfileTypesController(ILogger<ProfileTypesController> logger, IProfileTypeAppService appService)
        {
            this._logger = logger;
            this._appService = appService;
        }

        // api/ProfileType/5
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

        // api/ProfileType
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
