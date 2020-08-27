using StefaniniCore.Application.InputModels.Tasks;
using StefaniniCore.Application.ViewModels;

namespace StefaniniCore.Application.AppInterfaces
{
    public interface ITaskAppService : IBaseAppService
    {
        TaskDetailViewModel GetById(int id);

        System.Threading.Tasks.Task<TaskListViewModel> GetAll();

        System.Threading.Tasks.Task<TaskDetailViewModel> Save(TaskInputModel inputModel);

        void ValidationsToSave(TaskInputModel inputModel);

        void DeleteById(int id);
    }
}
