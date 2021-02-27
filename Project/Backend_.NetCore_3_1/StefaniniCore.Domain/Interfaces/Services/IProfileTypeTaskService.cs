using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Services.Base;
using System.Collections.Generic;

namespace StefaniniCore.Domain.Interfaces.Services
{
    public interface IProfileTypeTaskService : IServiceBase<ProfileTypeTask>
    {
        /// <summary>
        /// Get the Profile Types list By Id.
        /// </summary>
        /// <param name="profileTypeId"></param>
        /// <returns></returns>
        IList<ProfileTypeTask> GetByProfileTypeId(int profileTypeId);
    }
}
