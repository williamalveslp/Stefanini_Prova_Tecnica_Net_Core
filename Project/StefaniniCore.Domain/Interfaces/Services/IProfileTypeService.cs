using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Services.Base;
using System.Collections.Generic;

namespace StefaniniCore.Domain.Interfaces.Services
{
    public interface IProfileTypeService : IServiceBase<ProfileType>
    {
        /// <summary>
        /// Get the Profile Types that are 'Active' only.
        /// </summary>
        /// <returns></returns>
        IList<ProfileType> GetActivesOnly();
    }
}
