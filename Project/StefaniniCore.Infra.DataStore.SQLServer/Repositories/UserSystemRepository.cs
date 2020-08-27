using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Repositories;
using StefaniniCore.Infra.DataStore.SQLServer.Repositories.Base;
using System.Collections.Generic;
using System.Linq;

namespace StefaniniCore.Infra.DataStore.SQLServer.Repositories
{
    public class UserSystemRepository : RepositoryBase<UserSystem>, IUserSystemRepository
    {
        public IList<UserSystem> GetByProfileTypeId(int profileTypeId) =>
            ctx.UserSystem.Where(f => f.ProfileTypeId == profileTypeId).ToList();

        public IList<UserSystem> GetOnlyActives() =>
            ctx.UserSystem.Where(f => f.IsActive).OrderBy(f => f.Id).ToList();

        public UserSystem GetSignIn(string userName, string password)
        {
            return ctx.UserSystem.Where(f => f.UserName.ToUpper() == userName.ToUpper()
                                                   && f.Password == password).FirstOrDefault();
        }
    }
}
