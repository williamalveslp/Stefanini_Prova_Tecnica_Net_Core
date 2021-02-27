using StefaniniCore.Application.InputModels.UserSystemInputModel;
using StefaniniCore.Application.ViewModels;
using StefaniniCore.Domain.Entities;

namespace StefaniniCore.Application.AppInterfaces
{
    public interface IUserSystemAppService : IBaseAppService
    {
        UserSystemDetailViewModel GetById(int id);

        UserSystemDetailViewModel GetListsPopulated();

        UserSystem GetSignIn(UserSystemSignInInputModel inputModel);

        UserSystem Save(UserSystemInputModel inputModel);

        void ValidationsToSave(UserSystemInputModel inputModel);
    }
}
