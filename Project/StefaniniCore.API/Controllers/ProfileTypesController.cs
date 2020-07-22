using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StefaniniCore.API.Controllers.Base;
using StefaniniCore.API.Swagger.ResponseTypes;
using StefaniniCore.Application.AppInterfaces;
using StefaniniCore.Application.ViewModels;
using System;
using System.Net;
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
        /// <summary>
        /// List of ProfileType by Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ProfileTypeDetailViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorViewModel), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                return Ok(_appService.GetById(id));
            }
            catch (Exception ex)
            {
                return ResponseWithError(_logger, ex);
            }
        }

        // api/ProfileType
        /// <summary>
        /// List of ProfileTypes.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(ProfileTypeListViewModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorViewModel), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(_appService.GetAll());
            }
            catch (Exception ex)
            {
                return ResponseWithError(_logger, ex);
            }
        }

        // api/Tasks
        /// <summary>
        /// Delete the ProfileType by Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorViewModel), (int)HttpStatusCode.BadRequest)]
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
