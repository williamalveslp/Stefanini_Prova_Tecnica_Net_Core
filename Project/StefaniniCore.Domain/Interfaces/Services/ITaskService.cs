using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Services.Base;

namespace StefaniniCore.Domain.Interfaces.Services
{
    public interface ITaskService : IServiceBase<Task>
    {
        bool Exists(string name);
    }
}
