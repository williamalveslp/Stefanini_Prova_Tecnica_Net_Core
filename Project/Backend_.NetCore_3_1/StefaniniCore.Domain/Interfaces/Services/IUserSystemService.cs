using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Services.Base;
using System.Collections.Generic;

namespace StefaniniCore.Domain.Interfaces.Services
{
    public interface IUserSystemService : IServiceBase<UserSystem>
    {
        /// <summary>
        /// Get the User Systems list by Id.
        /// </summary>
        /// <param name="profileTypeId"></param>
        /// <returns></returns>
        IList<UserSystem> GetByProfileTypeId(int profileTypeId);

        /// <summary>
        /// Get the User System that are 'Active' only.
        /// </summary>
        /// <returns></returns>
        IList<UserSystem> GetActivesOnly();

        /// <summary>
        /// Get the UserSystem information when found.
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        UserSystem GetSignIn(string userName, string password);
    }
}
