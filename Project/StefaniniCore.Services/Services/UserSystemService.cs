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

        public UserSystem GetSignIn(string userName, string password)
        {
            if (string.IsNullOrEmpty(userName))
                throw new System.Exception("Campo 'Nome do Usuário' não informado.");

            if (string.IsNullOrEmpty(password))
                throw new System.Exception("Campo 'Senha' não informado.");

            return _repository.GetSignIn(userName, password);
        }
    }
}
