﻿using StefaniniCore.Application.AppInterfaces;
using StefaniniCore.Application.AppServices.Base;
using StefaniniCore.Application.InputModels.ProfileTypes;
using StefaniniCore.Application.ViewModels.ProfileTypes;
using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Services;
using System;
using System.Linq;

namespace StefaniniCore.Application.AppServices
{
    public class ProfileTypeAppService : BaseAppService, IProfileTypeAppService
    {
        private readonly IProfileTypeService _profileTypeService;
        private readonly ITaskService _tasksService;
        private readonly IProfileTypeTaskService _profileTypeTaskService;

        public ProfileTypeAppService(IProfileTypeService profileTypeService, ITaskService tasksService, IProfileTypeTaskService profileTypeTaskService)
        {
            this._profileTypeService = profileTypeService;
            this._tasksService = tasksService;
            this._profileTypeTaskService = profileTypeTaskService;
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public ProfileTypeListViewModel GetAll()
        {
            var profileTypes = _profileTypeService.GetAll().Where(f => f.IsActive)
                                     .OrderBy(f => f.Name).ToList();

            ProfileTypeListViewModel viewModel = new ProfileTypeListViewModel();
            viewModel.Load(profileTypes);

            return viewModel;
        }

        public ProfileTypeDetailViewModel GetById(int id)
        {
            var profileType = _profileTypeService.GetById(id);

            if (profileType == null)
                throw new Exception("Perfil não encontrado.");

            // TODO: Add these queries to Repository layer with joins to match the data.
            var relation = _profileTypeTaskService.GetAll().Where(f => f.ProfileTypeId == profileType.Id).Select(f => f.TaskId).ToList();
            var tasks = _tasksService.GetAll().Where(f => relation.Contains(f.Id)).ToList();

            ProfileTypeDetailViewModel viewModel = new ProfileTypeDetailViewModel();
            viewModel.Load(profileType.Id, profileType.Name, tasks);

            return viewModel;
        }

        public ProfileType Save(ProfileTypeInputModel inputModel)
        {
            ValidationsToSave(inputModel);

            ProfileType profileType;
            ProfileTypeTask profileTypeTask;

            if (inputModel.Id <= 0)
            {
                profileType = new ProfileType(inputModel.Name);
                profileType = _profileTypeService.Insert(profileType);

                foreach (var item in inputModel.TaskIds)
                {
                    profileTypeTask = new ProfileTypeTask(item, profileType.Id);
                    _profileTypeTaskService.Insert(profileTypeTask);
                }
            }
            else
            {
                profileType = _profileTypeService.GetById(inputModel.Id);
                profileType.Update(inputModel.Name);

                _profileTypeService.Update(profileType);
            }
            return profileType;
        }

        private void ValidationsToSave(ProfileTypeInputModel inputModel)
        {
            if (inputModel == null)
                throw new Exception("Erro no envio dos dados.");

            if (string.IsNullOrEmpty(inputModel.Name))
                throw new Exception("Campo 'Nome' não foi preenchido.");

            if (inputModel.TaskIds == null)
                throw new Exception("Campo 'Funcionalidades' estão inválidos");

            if (!inputModel.TaskIds.Any())
                throw new Exception("Campo 'Funcionalidades' não foi preenchido.");
        }
    }
}
