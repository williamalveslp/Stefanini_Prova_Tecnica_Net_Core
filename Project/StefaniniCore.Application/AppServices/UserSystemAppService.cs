using StefaniniCore.Application.AppInterfaces;
using StefaniniCore.Application.AppServices.Base;
using StefaniniCore.Application.InputModels.UserSystemInputModel;
using StefaniniCore.Application.Validators;
using StefaniniCore.Application.ViewModels;
using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Services;
using System;
using System.Linq;

namespace StefaniniCore.Application.AppServices
{
    public class UserSystemAppService : BaseAppService, IUserSystemAppService
    {
        private readonly IUserSystemService _userSystemService;
        private readonly IProfileTypeService _profileTypeService;

        public UserSystemAppService(IUserSystemService userSystemService, IProfileTypeService profileTypeService)
        {
            _userSystemService = userSystemService;
            _profileTypeService = profileTypeService;
        }

        public UserSystemDetailViewModel GetListsPopulated()
        {
            var profileTypes = _profileTypeService.GetAll().Where(f => f.IsActive).OrderBy(f => f.Id).ToList();

            UserSystemDetailViewModel viewModel = new UserSystemDetailViewModel();
            viewModel.UpdateProfileTypes(profileTypes);

            return viewModel;
        }

        public UserSystemDetailViewModel GetById(int id)
        { 
            var userSystem = _userSystemService.GetById(id);

            if (userSystem == null)
                throw new Exception("Usuário não encontrado.");

            var profileTypes = _profileTypeService.GetAll();

            UserSystemDetailViewModel viewModel = new UserSystemDetailViewModel();
            viewModel.Load(userSystem.Id, userSystem.UserName, userSystem.Password, userSystem.ProfileTypeId, profileTypes);

            return viewModel;
        }

        public UserSystem GetSignIn(UserSystemSignInInputModel inputModel)
        {
            var userSystem = _userSystemService.GetSignIn(inputModel.UserName, inputModel.Password);

            if (userSystem == null)
                throw new Exception("Usuário não encontrado.");

            return userSystem;
        }

        public UserSystem Save(UserSystemInputModel inputModel)
        {
            ValidationsToSave(inputModel);

            UserSystem userSystem;
            if (inputModel.Id <= 0)
            {
                userSystem = new UserSystem(inputModel.UserName, inputModel.Password, inputModel.ProfileTypeId);
                _userSystemService.Insert(userSystem);
            }
            else
            {
                userSystem = _userSystemService.GetById(inputModel.Id);
                userSystem.Update(inputModel.UserName, inputModel.Password, inputModel.ProfileTypeId);
                _userSystemService.Update(userSystem);
            }
            return userSystem;
        }

        public void ValidationsToSave(UserSystemInputModel inputModel)
        {
            var validate = new UserSystemInputModelValidator().Validate(inputModel);

            if (!validate.IsValid)
                throw new Exception(validate.Errors.FirstOrDefault().ErrorMessage);
        }
    }
}
