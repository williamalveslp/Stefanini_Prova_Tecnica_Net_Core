using StefaniniCore.Application.InputModels.ProfileTypes;
using StefaniniCore.Application.ViewModels.ProfileTypes;
using StefaniniCore.Domain.Entities;

namespace StefaniniCore.Application.AppInterfaces
{
    public interface IProfileTypeAppService : IBaseAppService
    {
        ProfileTypeDetailViewModel GetById(int id);

        ProfileTypeListViewModel GetAll();

        ProfileType Save(ProfileTypeInputModel inputModel);

        void DeleteById(int id);
    }
}
