using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Services.Base;
using System.Collections.Generic;

namespace StefaniniCore.Domain.Interfaces.Services
{
    public interface ITaskService : IServiceBase<Task>
    {
        IList<Task> GetOnlyActives();

        bool Exists(string name);
    }
}
