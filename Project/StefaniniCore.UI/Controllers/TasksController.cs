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

        /// <summary>
        /// List of Tasks.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Detail of the fields of Tasks.
        /// </summary>
        /// <param name="taskId"></param>
        /// <returns></returns>
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
                return ErrorMessage(ex.Message, _logger);
            }
        }

        [HttpPost]
        /// <summary>
        /// Save the Task.
        /// </summary>
        /// <param name="taskId"></param>
        /// <returns></returns>
        public IActionResult Save(TaskInputModel inputModel)
        {
            try
            {
                var task = _appService.Save(inputModel);
                return SuccessMessage("Salvo com sucesso!", task.Id, false);
            }
            catch (Exception ex)
            {
                return ErrorMessage(ex.Message, _logger);
            }
        }

        [HttpDelete]
        /// <summary>
        /// Delete the Task.
        /// </summary>
        /// <param name="taskId"></param>
        /// <returns></returns>
        public IActionResult Remove(int taskId)
        {
            try
            {
                _appService.DeleteById(taskId);
                return SuccessMessage("Excluído com sucesso!", null, true);
            }
            catch (Exception ex)
            {
                return ErrorMessage(ex.Message, _logger);
            }
        }
    }
}
