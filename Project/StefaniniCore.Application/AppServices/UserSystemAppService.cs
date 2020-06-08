using StefaniniCore.Application.AppInterfaces;
using StefaniniCore.Application.AppServices.Base;
using StefaniniCore.Application.InputModels.UserSystem;
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

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public TaskListViewModel GetAll()
        {
            throw new NotImplementedException();
        }

        public UserSystemDetailViewModel GetListsPopulated()
        {
            var profileTypes = _profileTypeService.GetAll().Where(f => f.IsActive).ToList();

            UserSystemDetailViewModel viewModel = new UserSystemDetailViewModel();
            viewModel.UpdateProfileTypes(profileTypes);

            return viewModel;
        }

        public UserSystemDetailViewModel GetById(int id)
        {
            var userSystem = _userSystemService.GetById(id);

            if (userSystem == null)
                throw new Exception("Usuário não encontrado.");

            var profileTypes = _profileTypeService.GetAll().Where(f => f.IsActive).ToList();

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

        #region .: PRIVATE METHODS :.
        private void ValidationsToSave(UserSystemInputModel inputModel)
        {
            if (inputModel == null)
                throw new Exception("Erro no envio dos dados.");

            if (string.IsNullOrEmpty(inputModel.UserName))
                throw new Exception("Campo 'Nome do Usuário' não foi preenchido.");

            if (string.IsNullOrEmpty(inputModel.Password))
                throw new Exception("Campo 'Senha' não foi preenchido.");

            if (inputModel.ProfileTypeId <= 0)
                throw new Exception("Campo 'Perfil' não foi selecionado.");
        }
        #endregion
    }
}
