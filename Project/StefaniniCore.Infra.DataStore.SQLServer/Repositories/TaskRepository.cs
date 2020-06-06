using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Repositories;
using StefaniniCore.Infra.DataStore.SQLServer.Repositories.Base;
using System.Linq;

namespace StefaniniCore.Infra.DataStore.SQLServer.Repositories
{
    public class TaskRepository : RepositoryBase<Task>, ITaskRepository
    {
        public bool Exists(string name)
        {
            bool exists = false;
            using (var ctx = new StefDbContext())
            {
                var task = ctx.Task.Where(f => f.Name.ToLower().Trim() == name.ToLower().Trim())
                                    .ToList();

                exists = task.Any();
            }
            return exists;
        }
    }
}
