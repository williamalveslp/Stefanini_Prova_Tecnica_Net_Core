using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StefaniniCore.Application.AppInterfaces;
using StefaniniCore.Application.InputModels.ProfileTypes;
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
        public IActionResult Detail(int? profileTypeId)
        {
            try
            {
                if ((profileTypeId != null) && (profileTypeId > 0))
                    return View(_appService.GetById((int)profileTypeId));
                else
                    return View(_appService.GetListsPopulated());
            }
            catch (Exception ex)
            {
                return ErrorMessage(ex.Message, _logger);
            }
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

        [HttpPost]
        /// <summary>
        /// Save the ProfileType.
        /// </summary>
        /// <param name="taskId"></param>
        /// <returns></returns>
        public IActionResult Save(ProfileTypeInputModel inputModel)
        {
            try
            {
                var profileType = _appService.Save(inputModel);
                return SuccessMessage("Salvo com sucesso!", profileType.Id, false);
            }
            catch (Exception ex)
            {
                return ErrorMessage(ex.Message, _logger);
            }
        }

        [HttpDelete]
        /// <summary>
        /// Delete the ProfileType.
        /// </summary>
        /// <param name="taskId"></param>
        /// <returns></returns>
        public IActionResult Remove(int profileTypeId)
        {
            try
            {
                _appService.DeleteById(profileTypeId);
                return SuccessMessage("Excluído com sucesso!", null, true);
            }
            catch (Exception ex)
            {
                return ErrorMessage(ex.Message, _logger);
            }
        }
    }
}
