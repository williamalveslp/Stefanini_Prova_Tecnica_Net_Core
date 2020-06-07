using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StefaniniCore.Application.AppInterfaces;
using StefaniniCore.Application.InputModels.UserSystem;
using System;

namespace StefaniniCore.UI.Controllers
{
    public class UserSystemsController : MainController
    {
        private readonly IUserSystemAppService _appService;
        private readonly ILogger<UserSystemsController> _logger;

        public UserSystemsController(IUserSystemAppService appService, ILogger<UserSystemsController> logger)
        {
            _appService = appService;
            _logger = logger;
        }

        /// <summary>
        /// Detail with the fields of UserSystem.
        /// </summary>
        /// <returns></returns>
        public IActionResult Detail(int? userSystemId)
        {
            try
            {
                if ((userSystemId != null) && (userSystemId > 0))
                    return View(_appService.GetById((int)userSystemId));
                else
                    return View(_appService.GetListsPopulated());
            }
            catch (Exception ex)
            {
                return ErrorMessage(ex.Message, _logger);
            }
        }

        /// <summary>
        /// SingIn/Login on application.
        /// </summary>
        /// <returns></returns>
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        /// <summary>
        /// Save the UserSystem.
        /// </summary>
        /// <param name="taskId"></param>
        /// <returns></returns>
        public IActionResult Save(UserSystemInputModel inputModel)
        {
            try
            {
                var userSystem = _appService.Save(inputModel);
                return SuccessMessage("Salvo com sucesso!", userSystem.Id, false);
            }
            catch (Exception ex)
            {
                return ErrorMessage(ex.Message, _logger);
            }
        }
    }
}
