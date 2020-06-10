using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Services.Base;
using System.Collections.Generic;

namespace StefaniniCore.Domain.Interfaces.Services
{
    public interface IProfileTypeTaskService : IServiceBase<ProfileTypeTask>
    {
        IList<ProfileTypeTask> GetByProfileTypeId(int profileTypeId);
    }
}
