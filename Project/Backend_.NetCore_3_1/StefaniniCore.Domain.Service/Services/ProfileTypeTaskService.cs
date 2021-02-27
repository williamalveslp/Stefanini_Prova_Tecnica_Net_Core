using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Repositories;
using StefaniniCore.Domain.Interfaces.Services;
using StefaniniCore.Domain.Services.Services.Base;
using System.Collections.Generic;

namespace StefaniniCore.Domain.Services.Services
{
    public class ProfileTypeTaskService : ServiceBase<ProfileTypeTask>, IProfileTypeTaskService
    {
        private readonly IProfileTypeTaskRepository _repository;

        public ProfileTypeTaskService(IProfileTypeTaskRepository repository) : base(repository)
        {
            this._repository = repository;
        }

        public IList<ProfileTypeTask> GetByProfileTypeId(int profileTypeId) =>
             _repository.GetByProfileTypeId(profileTypeId);
    }
}
