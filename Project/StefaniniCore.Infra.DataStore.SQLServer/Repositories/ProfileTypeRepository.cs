using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Repositories;
using StefaniniCore.Infra.DataStore.SQLServer.Repositories.Base;
using System.Collections.Generic;
using System.Linq;

namespace StefaniniCore.Infra.DataStore.SQLServer.Repositories
{
    public class ProfileTypeRepository : RepositoryBase<ProfileType>, IProfileTypeRepository
    {
        public ProfileTypeRepository(StefDbContext ctx) : base(ctx) { }

        public IList<ProfileType> GetActivesOnly() =>
                ctx.ProfileType.Where(f => f.IsActive)
                                .OrderBy(f=> f.Name).ToList();
    }
}
