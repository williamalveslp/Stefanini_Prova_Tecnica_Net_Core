using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Repositories.Base;
using System.Collections.Generic;

namespace StefaniniCore.Domain.Interfaces.Repositories
{
    public interface ITaskRepository : IRepositoryBase<Task>
    {
        IList<Task> GetsActivesOnly();

        bool Exists(string name);
    }
}
