using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StefaniniCore.Application.AppInterfaces;
using StefaniniCore.Application.InputModels.Tasks;
using StefaniniCore.Application.ViewModels;
using System;

namespace StefaniniCore.UI.Controllers
{
    public class TasksController : MainController
    {
        private readonly ILogger<TasksController> _logger;
        private readonly ITaskAppService _appService;

        public TasksController(ILogger<TasksController> logger, ITaskAppService appService)
        {
            _logger = logger;
            _appService = appService;
        }

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
                return ErrorMessage(_logger, ex);
            }
        }

        [Authorize]
        public IActionResult Detail(int? taskId)
        {
            try
            {
                if ((taskId != null) && (taskId > 0))
                    return View(_appService.GetById((int)taskId));
                else
                    return View(new TaskDetailViewModel());
            }
            catch (Exception ex)
            {
                return ErrorMessage(_logger, ex);
            }
        }

        [Authorize]
        [HttpPost]
        public IActionResult Save(TaskInputModel inputModel)
        {
            try
            {
                var task = _appService.Save(inputModel);
                return SuccessMessage("Salvo com sucesso!", task.Id, false);
            }
            catch (Exception ex)
            {
                return ErrorMessage(_logger, ex);
            }
        }

        [Authorize]
        [HttpDelete]
        public IActionResult Remove(int taskId)
        {
            try
            {
                _appService.DeleteById(taskId);
                return SuccessMessage("Excluído com sucesso!", null, true);
            }
            catch (Exception ex)
            {
                return ErrorMessage(_logger, ex);
            }
        }
    }
}
