using StefaniniCore.Domain.Interfaces.Repositories.Base;
using StefaniniCore.Domain.Interfaces.Services.Base;
using System;
using System.Collections.Generic;

namespace StefaniniCore.Domain.Services.Services.Base
{
    public abstract class ServiceBase<T> : IDisposable, IServiceBase<T> where T : class
    {
        private readonly IRepositoryBase<T> _repository;

        protected ServiceBase(IRepositoryBase<T> repository)
        {
            _repository = repository;
        }

        public T GetById(int entityId) => _repository.GetById(entityId);

        public T Insert(T entity) => _repository.Insert(entity);

        public T Update(T entity) => _repository.Update(entity);

        public void DeleteById(int entityId) => _repository.DeleteById(entityId);

        public void Dispose() => _repository.Dispose();

        public IList<T> GetAll() => _repository.GetAll();
    }
}
