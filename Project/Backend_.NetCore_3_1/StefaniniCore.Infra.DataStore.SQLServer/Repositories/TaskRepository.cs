using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Repositories;
using StefaniniCore.Infra.DataStore.SQLServer.Repositories.Base;
using System.Collections.Generic;
using System.Linq;

namespace StefaniniCore.Infra.DataStore.SQLServer.Repositories
{
    public class TaskRepository : RepositoryBase<Task>, ITaskRepository
    {
        public TaskRepository(StefDbContext ctx) : base(ctx) { }

        public bool Exists(string name) =>
                 ctx.Task.Where(f => !string.IsNullOrEmpty(name)
                                && f.Name.ToLower().Trim() == name.ToLower().Trim()).Any();

        public IList<Task> GetsActivesOnly() =>
                ctx.Task.Where(f => f.IsActive)
                        .OrderBy(f=> f.Name).ToList();
    }
}
