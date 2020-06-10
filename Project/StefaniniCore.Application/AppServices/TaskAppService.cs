using StefaniniCore.Application.AppInterfaces;
using StefaniniCore.Application.AppServices.Base;
using StefaniniCore.Application.InputModels.Tasks;
using StefaniniCore.Application.ViewModels;
using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Services;
using System;

namespace StefaniniCore.Application.AppServices
{
    public class TaskAppService : BaseAppService, ITaskAppService
    {
        private readonly ITaskService _taskService;

        public TaskAppService(ITaskService taskService)
        {
            _taskService = taskService;
        }

        public void DeleteById(int id)
        {
            _taskService.DeleteById(id);
        }

        public TaskListViewModel GetAll()
        {
            var tasks = _taskService.GetOnlyActives();

            TaskListViewModel viewModel = new TaskListViewModel();
            viewModel.Load(tasks);

            return viewModel;
        }

        public TaskDetailViewModel GetById(int id)
        {
            var task = _taskService.GetById(id);

            if (task == null)
                throw new Exception("Funcionalidade não encontrada.");
          
            TaskDetailViewModel viewModel = new TaskDetailViewModel();
            viewModel.Load(task.Id, task.Name, task.Description);

            return viewModel;
        }

        public Task Save(TaskInputModel inputModel)
        {
            ValidationsToSave(inputModel);

            Task task;
            if (inputModel.Id <= 0)
            {
                task = new Task(inputModel.Name, inputModel.Description);
                _taskService.Insert(task);
            }
            else
            {
                task = _taskService.GetById(inputModel.Id);
                task.Update(inputModel.Name, inputModel.Description);
                _taskService.Update(task);
            }
            return task;
        }

        #region .: PRIVATE METHODS :.
        private void ValidationsToSave(TaskInputModel inputModel)
        {
            if (inputModel == null)
                throw new Exception("Erro no envio dos dados.");

            if (string.IsNullOrEmpty(inputModel.Name))
                throw new Exception("Campo 'Nome' não foi preenchido.");
        }
        #endregion
    }
}
