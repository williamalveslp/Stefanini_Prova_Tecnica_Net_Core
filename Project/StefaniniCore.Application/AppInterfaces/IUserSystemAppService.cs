using StefaniniCore.Application.InputModels.UserSystem;
using StefaniniCore.Application.ViewModels;
using StefaniniCore.Domain.Entities;

namespace StefaniniCore.Application.AppInterfaces
{
    public interface IUserSystemAppService : IBaseAppService
    {
        UserSystemDetailViewModel GetById(int id);

        UserSystemDetailViewModel GetListsPopulated();

        TaskListViewModel GetAll();

        UserSystem Save(UserSystemInputModel inputModel);

        void DeleteById(int id);
    }
}
