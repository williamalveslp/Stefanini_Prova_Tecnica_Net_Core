using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StefaniniCore.Application.AppInterfaces;
using System;

namespace StefaniniCore.UI.Controllers
{
    public class ProfileTypesController : MainController
    {
        private readonly IProfileTypeAppService _appService;
        private readonly ILogger<UserSystemsController> _logger;

        public ProfileTypesController(IProfileTypeAppService appService, ILogger<UserSystemsController> logger)
        {
            _appService = appService;
            _logger = logger;
        }

        /// <summary>
        /// Detail of ProfileTypes.
        /// </summary>
        /// <returns></returns>
        [Authorize]
        public IActionResult Detail()
        {
            return View();
        }

        /// <summary>
        /// List of Tasks.
        /// </summary>
        /// <returns></returns>
        [Authorize]
        public IActionResult List()
        {
            try
            {
                var viewModel = _appService.GetAll();
                return View(viewModel);
            }
            catch (Exception ex)
            {
                return ErrorMessage(ex.Message, _logger);
            }
        }
    }
}
