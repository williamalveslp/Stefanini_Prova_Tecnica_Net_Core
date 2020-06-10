using StefaniniCore.Application.AppInterfaces;
using StefaniniCore.Application.AppServices.Base;
using StefaniniCore.Application.InputModels.ProfileTypes;
using StefaniniCore.Application.ViewModels;
using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StefaniniCore.Application.AppServices
{
    public class ProfileTypeAppService : BaseAppService, IProfileTypeAppService
    {
        private readonly IProfileTypeService _profileTypeService;
        private readonly ITaskService _tasksService;
        private readonly IProfileTypeTaskService _profileTypeTaskService;
        private readonly IUserSystemService _userSystemService;

        public ProfileTypeAppService(IProfileTypeService profileTypeService, ITaskService tasksService
                                  , IProfileTypeTaskService profileTypeTaskService, IUserSystemService userSystemService)
        {
            this._profileTypeService = profileTypeService;
            this._tasksService = tasksService;
            this._profileTypeTaskService = profileTypeTaskService;
            this._userSystemService = userSystemService;
        }

        public void DeleteById(int id)
        {
            var userSystemsList = _userSystemService.GetByProfileTypeId(id);

            if (userSystemsList.Any())
                throw new Exception("Não foi possível excluir este perfil, está em uso.");

            var profileTypesTaskList = _profileTypeTaskService.GetByProfileTypeId(id);

            foreach (var item in profileTypesTaskList)
                _profileTypeTaskService.DeleteById(item.Id);

            var profileType = _profileTypeService.GetById(id);

            if (profileType != null)
                _profileTypeService.DeleteById(id);
        }

        public ProfileTypeListViewModel GetAll()
        {
            var profileTypes = _profileTypeService.GetOnlyActives();

            ProfileTypeListViewModel viewModel = new ProfileTypeListViewModel();
            viewModel.Load(profileTypes);

            return viewModel;
        }

        public ProfileTypeDetailViewModel GetById(int id)
        {
            var profileType = _profileTypeService.GetById(id);

            if (profileType == null)
                throw new Exception("Perfil não encontrado.");

            var relation = _profileTypeTaskService.GetByProfileTypeId(id).Select(f => f.TaskId).ToList();
            var tasks = _tasksService.GetAll();
            var tasksByProfileType = tasks.Where(f => relation.Contains(f.Id)).ToList();

            ProfileTypeDetailViewModel viewModel = new ProfileTypeDetailViewModel();
            viewModel.Load(profileType.Id, profileType.Name, tasks, tasksByProfileType);

            return viewModel;
        }

        public ProfileTypeDetailViewModel GetListsPopulated()
        {
            ProfileTypeDetailViewModel viewModel = new ProfileTypeDetailViewModel();
            viewModel.UpdateTasks(_tasksService.GetAll());

            return viewModel;
        }

        public ProfileType Save(ProfileTypeInputModel inputModel)
        {
            ValidationsToSave(inputModel);

            ProfileType profileType;

            if (inputModel.Id <= 0)
            {
                profileType = new ProfileType(inputModel.Name);
                profileType = _profileTypeService.Insert(profileType);

                foreach (var item in inputModel.TaskIds)
                {
                    ProfileTypeTask profileTypeTask = new ProfileTypeTask(item, profileType.Id);
                    _profileTypeTaskService.Insert(profileTypeTask);
                }
            }
            else
            {
                profileType = _profileTypeService.GetById(inputModel.Id);
                profileType.Update(inputModel.Name);

                _profileTypeService.Update(profileType);

                var allProfileTypeTask = _profileTypeTaskService.GetAll();
                var profileTypesTask = allProfileTypeTask.Where(f => f.ProfileTypeId == profileType.Id).ToList();

                DeleteOldRelations(profileTypesTask, inputModel.TaskIds);
                AddNewRelations(inputModel.TaskIds, profileType, allProfileTypeTask);
            }
            return profileType;
        }

        private void AddNewRelations(int[] taskIds, ProfileType profileType
                                     , IList<ProfileTypeTask> allProfileTypeTask)
        {
            foreach (var item in taskIds)
            {
                if (!allProfileTypeTask.Any(f => f.ProfileTypeId == profileType.Id && f.TaskId == item))
                {
                    ProfileTypeTask profileTypeTask = new ProfileTypeTask(item, profileType.Id);
                    _profileTypeTaskService.Insert(profileTypeTask);
                }
            }
        }

        private void DeleteOldRelations(IList<ProfileTypeTask> profileTypesTask, int[] taskIds)
        {
            foreach (var item in profileTypesTask)
            {
                bool match = false;
                foreach (var taskIdInput in taskIds)
                {
                    if (item.TaskId == taskIdInput)
                    {
                        match = true;
                        break;
                    }
                }

                if (!match)
                {
                    _profileTypeTaskService.DeleteById(item.Id);
                }
            }
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
