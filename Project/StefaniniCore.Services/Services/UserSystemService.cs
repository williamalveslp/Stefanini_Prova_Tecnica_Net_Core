using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Repositories;
using StefaniniCore.Domain.Interfaces.Services;
using StefaniniCore.Services.Services.Base;
using System.Collections.Generic;
using System.Linq;

namespace StefaniniCore.Services.Services
{
    public class UserSystemService : ServiceBase<UserSystem>, IUserSystemService
    {
        private readonly IUserSystemRepository _repository;

        public UserSystemService(IUserSystemRepository repository) : base(repository)
        {
            this._repository = repository;
        }

        public IList<UserSystem> GetByProfileTypeId(int profileTypeId) =>
            _repository.GetByProfileTypeId(profileTypeId);

        public IList<UserSystem> GetOnlyActives() =>
             _repository.GetOnlyActives().OrderBy(f => f.UserName).ToList();

        public UserSystem GetSignIn(string userName, string password) =>
            _repository.GetSignIn(userName, password);
    }
}
