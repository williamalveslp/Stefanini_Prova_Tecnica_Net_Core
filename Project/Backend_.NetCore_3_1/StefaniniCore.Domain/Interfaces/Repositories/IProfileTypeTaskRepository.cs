using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Repositories.Base;
using System.Collections.Generic;

namespace StefaniniCore.Domain.Interfaces.Repositories
{
    public interface IProfileTypeTaskRepository : IRepositoryBase<ProfileTypeTask>
    {
        IList<ProfileTypeTask> GetByProfileTypeId(int profileTypeId);
    }
}
