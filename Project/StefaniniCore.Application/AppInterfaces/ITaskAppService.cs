using StefaniniCore.Application.InputModels.Tasks;
using StefaniniCore.Application.ViewModels;
using StefaniniCore.Domain.Entities;

namespace StefaniniCore.Application.AppInterfaces
{
    public interface ITaskAppService : IBaseAppService
    {
        TaskDetailViewModel GetById(int id);

        TaskListViewModel GetAll();

        Task Save(TaskInputModel inputModel);

        void DeleteById(int id);
    }
}
