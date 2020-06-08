using StefaniniCore.Application.InputModels.ProfileTypes;
using StefaniniCore.Application.ViewModels;
using StefaniniCore.Domain.Entities;

namespace StefaniniCore.Application.AppInterfaces
{
    public interface IProfileTypeAppService : IBaseAppService
    {
        ProfileTypeDetailViewModel GetById(int id);

        ProfileTypeListViewModel GetAll();

        ProfileTypeDetailViewModel GetListsPopulated();

        ProfileType Save(ProfileTypeInputModel inputModel);

        void DeleteById(int id);
    }
}
