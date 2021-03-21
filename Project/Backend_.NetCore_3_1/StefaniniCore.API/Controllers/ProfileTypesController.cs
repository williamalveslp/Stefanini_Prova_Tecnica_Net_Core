using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StefaniniCore.API.Controllers.Base;
using StefaniniCore.Application.AppInterfaces;
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
    public class ProfileTypesController : MainController
    {
        private readonly ILogger<ProfileTypesController> _logger;
        private readonly IProfileTypeAppService _appService;

        public ProfileTypesController(ILogger<ProfileTypesController> logger, IProfileTypeAppService appService)
        {
            this._logger = logger;
            this._appService = appService;
        }

        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "List of ProfileType by Id.")]
        [ProducesResponseType(typeof(ProfileTypeDetailViewModel), (int)HttpStatusCode.OK)]
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

        [HttpGet]
        [SwaggerOperation(Summary = "List of ProfileTypes.")]
        [ProducesResponseType(typeof(ProfileTypeListViewModel), (int)HttpStatusCode.OK)]
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
        [SwaggerOperation(Summary = "Delete the ProfileType by Id.")]
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
