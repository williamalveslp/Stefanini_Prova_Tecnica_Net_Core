using Microsoft.EntityFrameworkCore;
using StefaniniCore.Domain.Interfaces.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StefaniniCore.Infra.DataStore.SQLServer.Repositories.Base
{
    public abstract class RepositoryBase<T> : IDisposable, IRepositoryBase<T> where T : class
    {
        protected StefDbContext databaseContext = new StefDbContext();

        public T Insert(T entity)
        {
            databaseContext.Set<T>().Add(entity);
            databaseContext.SaveChanges();
            return entity;
        }

        public T Update(T entity)
        {
            databaseContext.Entry(entity).State = EntityState.Modified;
            databaseContext.SaveChanges();
            return entity;
        }

        public IList<T> GetAll()
        {
            return databaseContext.Set<T>().ToList();
        }

        public T GetById(int entityId)
        {
            return databaseContext.Set<T>().Find(entityId);
        }

        public void DeleteById(int entityId)
        {
            var entity = GetById(entityId);
            databaseContext.Set<T>().Remove(entity);
            databaseContext.SaveChanges();
        }

        public void Dispose()
        {
            databaseContext.Dispose();
        }
    }
}
