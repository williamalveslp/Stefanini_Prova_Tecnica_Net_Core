using Microsoft.EntityFrameworkCore;
using StefaniniCore.Domain.Interfaces.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StefaniniCore.Infra.DataStore.SQLServer.Repositories.Base
{
    public abstract class RepositoryBase<T> : IDisposable, IRepositoryBase<T> where T : class
    {
        protected readonly StefDbContext ctx;

        protected RepositoryBase(StefDbContext ctx)
        {
            this.ctx = ctx;

            #region .: OLD WAY :.
        /*    var optionsBuilder = new DbContextOptionsBuilder<StefDbContext>();
            optionsBuilder.UseSqlServer(ConnectionString.Path);
           
            this.ctx = new StefDbContext(optionsBuilder.Options); */
            #endregion
        }

        public T Insert(T entity)
        {
            ctx.Set<T>().Add(entity);
            ctx.SaveChanges();

            return entity;
        }

        public T Update(T entity)
        {
            ctx.Entry(entity).State = EntityState.Modified;
            ctx.SaveChanges();
            return entity;
        }

        public IList<T> GetAll() => ctx.Set<T>().ToList();

        public T GetById(int entityId) => ctx.Set<T>().Find(entityId);

        public void DeleteById(int entityId)
        {
            var entity = GetById(entityId);
            ctx.Set<T>().Remove(entity);
            ctx.SaveChanges();
        }

        public void Dispose()
        {
            ctx.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
