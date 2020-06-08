using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Repositories;
using StefaniniCore.Infra.DataStore.SQLServer.Repositories.Base;
using System.Linq;

namespace StefaniniCore.Infra.DataStore.SQLServer.Repositories
{
    public class UserSystemRepository : RepositoryBase<UserSystem>, IUserSystemRepository
    {
        public UserSystem GetSignIn(string userName, string password)
        {
            UserSystem userSystem = null;
            using (var ctx = new StefDbContext())
            {
                userSystem = ctx.UserSystem.Where(f => (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
                                                  && f.UserName.ToUpper() == userName.ToUpper()
                                                  && f.Password == password).FirstOrDefault();
            }
            return userSystem;
        }
    }
}
