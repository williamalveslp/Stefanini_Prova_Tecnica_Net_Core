﻿using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Repositories;
using StefaniniCore.Infra.DataStore.SQLServer.Repositories.Base;

namespace StefaniniCore.Infra.DataStore.SQLServer.Repositories
{
    public class UserSystemRepository : RepositoryBase<UserSystem>, IUserSystemRepository
    {
    }
}
