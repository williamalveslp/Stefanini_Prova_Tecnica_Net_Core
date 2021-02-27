using StefaniniCore.Application.InputModels.Tasks;
using StefaniniCore.Application.ViewModels;

namespace StefaniniCore.Application.AppInterfaces
{
    public interface ITaskAppService : IBaseAppService
    {
        TaskDetailViewModel GetById(int id);

        TaskListViewModel GetAll();

        TaskDetailViewModel Save(TaskInputModel inputModel);

        void ValidationsToSave(TaskInputModel inputModel);

        void DeleteById(int id);
    }
}
