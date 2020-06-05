using System;
using System.Collections.Generic;
using System.Text;

namespace StefaniniCore.Domain.Interfaces.Services.Base
{
    public interface IServiceBase<T> where T : class
    {
        T Insert(T entity);

        T Update(T entity);

        T GetById(int entityId);

        IList<T> GetAll();

        void DeleteById(int entityId);

        void Dispose();
    }
}
