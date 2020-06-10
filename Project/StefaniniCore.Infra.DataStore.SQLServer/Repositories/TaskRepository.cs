using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Repositories;
using StefaniniCore.Infra.DataStore.SQLServer.Repositories.Base;
using System.Collections.Generic;
using System.Linq;

namespace StefaniniCore.Infra.DataStore.SQLServer.Repositories
{
    public class TaskRepository : RepositoryBase<Task>, ITaskRepository
    {
        public bool Exists(string name) =>
                 ctx.Task.Where(f => f.Name.ToLower().Trim() == name.ToLower().Trim()).Any();

        public IList<Task> GetOnlyActives() =>
                ctx.Task.Where(f => f.IsActive).ToList();
    }
}
