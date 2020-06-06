using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Repositories;
using StefaniniCore.Domain.Interfaces.Services;
using StefaniniCore.Services.Services.Base;

namespace StefaniniCore.Services.Services
{
    public class ProfileTypeTaskService : ServiceBase<ProfileTypeTask>, IProfileTypeTaskService
    {
        private readonly IProfileTypeTaskRepository _repository;

        public ProfileTypeTaskService(IProfileTypeTaskRepository repository) : base(repository)
        {
            this._repository = repository;
        }
    }
}
