using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Repositories.Base;
using System.Collections.Generic;

namespace StefaniniCore.Domain.Interfaces.Repositories
{
    public interface IUserSystemRepository : IRepositoryBase<UserSystem>
    {
        IList<UserSystem> GetByProfileTypeId(int profileTypeId);

        IList<UserSystem> GetOnlyActives();

        UserSystem GetSignIn(string userName, string password);
    }
}
