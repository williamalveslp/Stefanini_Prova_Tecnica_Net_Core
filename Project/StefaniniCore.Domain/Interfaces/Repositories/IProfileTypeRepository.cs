using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Repositories.Base;
using System.Collections.Generic;

namespace StefaniniCore.Domain.Interfaces.Repositories
{
    public interface IProfileTypeRepository : IRepositoryBase<ProfileType>
    {
        IList<ProfileType> GetActivesOnly();
    }
}
