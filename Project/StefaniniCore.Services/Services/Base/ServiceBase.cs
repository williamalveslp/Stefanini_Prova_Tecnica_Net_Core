using StefaniniCore.Domain.Interfaces.Repositories.Base;
using StefaniniCore.Domain.Interfaces.Services.Base;
using System;
using System.Collections.Generic;

namespace StefaniniCore.Services.Services.Base
{
    public abstract class ServiceBase<T> : IDisposable, IServiceBase<T> where T : class
    {
        private readonly IRepositoryBase<T> _repository;

        public ServiceBase(IRepositoryBase<T> repository)
        {
            _repository = repository;
        }

        public T GetById(int entityId)
        {
            return _repository.GetById(entityId);
        }

        public T Insert(T entity)
        {
            return _repository.Insert(entity);
        }

        public T Update(T entity)
        {
            return _repository.Update(entity);
        }
        public void DeleteById(int entityId)
        {
            _repository.DeleteById(entityId);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public IList<T> GetAll()
        {
            return _repository.GetAll();
        }
    }
}
