using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Repositories;
using StefaniniCore.Infra.DataStore.SQLServer.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace StefaniniCore.Infra.DataStore.SQLServer.Repositories
{
    public class ProfileTypeTaskRepository : RepositoryBase<ProfileTypeTask>, IProfileTypeTaskRepository
    {
    }
}
