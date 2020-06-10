using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Services.Base;
using System.Collections.Generic;

namespace StefaniniCore.Domain.Interfaces.Services
{
    public interface IUserSystemService : IServiceBase<UserSystem>
    {
        IList<UserSystem> GetByProfileTypeId(int profileTypeId);

        IList<UserSystem> GetOnlyActives();

        UserSystem GetSignIn(string userName, string password);
    }
}
