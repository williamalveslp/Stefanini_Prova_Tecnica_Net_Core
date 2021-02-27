using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Repositories;
using StefaniniCore.Infra.DataStore.SQLServer.Repositories.Base;
using System.Collections.Generic;
using System.Linq;

namespace StefaniniCore.Infra.DataStore.SQLServer.Repositories
{
    public class ProfileTypeTaskRepository : RepositoryBase<ProfileTypeTask>, IProfileTypeTaskRepository
    {
        public ProfileTypeTaskRepository(StefDbContext ctx) : base(ctx) { }

        public IList<ProfileTypeTask> GetByProfileTypeId(int profileTypeId) =>
            ctx.ProfileTypeTask.Where(f => f.ProfileTypeId == profileTypeId).ToList();
    }
}
