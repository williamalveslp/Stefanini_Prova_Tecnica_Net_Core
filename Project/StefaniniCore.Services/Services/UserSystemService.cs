using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Repositories;
using StefaniniCore.Domain.Interfaces.Services;
using StefaniniCore.Services.Services.Base;
using System;
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

        public UserSystem GetSignIn(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName))
                throw new Exception("Campo 'Nome do Usuário' não informado.");

            if (string.IsNullOrEmpty(password))
                throw new Exception("Campo 'Senha' não informado.");

            return _repository.GetSignIn(userName, password);
        }
    }
}
