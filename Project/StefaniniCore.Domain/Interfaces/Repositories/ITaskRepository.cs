using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Repositories.Base;

namespace StefaniniCore.Domain.Interfaces.Repositories
{
    public interface ITaskRepository : IRepositoryBase<Task>
    {
        bool Exists(string name);
    }
}
