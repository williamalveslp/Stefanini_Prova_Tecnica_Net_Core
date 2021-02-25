using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Repositories;
using StefaniniCore.Domain.Interfaces.Services;
using StefaniniCore.Domain.Services.Services.Base;
using System.Collections.Generic;

namespace StefaniniCore.Domain.Services.Services
{
    public class ProfileTypeService : ServiceBase<ProfileType>, IProfileTypeService
    {
        private readonly IProfileTypeRepository _repository;

        public ProfileTypeService(IProfileTypeRepository repository) : base(repository)
        {
            this._repository = repository;
        }

        public IList<ProfileType> GetActivesOnly() =>
                 _repository.GetActivesOnly();
    }
}
