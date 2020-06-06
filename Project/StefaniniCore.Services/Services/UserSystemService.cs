using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Repositories;
using StefaniniCore.Domain.Interfaces.Services;
using StefaniniCore.Services.Services.Base;

namespace StefaniniCore.Services.Services
{
    public class UserSystemService : ServiceBase<UserSystem>, IUserSystemService
    {
        private readonly IUserSystemRepository _repository;

        public UserSystemService(IUserSystemRepository repository) : base(repository)
        {
            this._repository = repository;
        }
    }
}
