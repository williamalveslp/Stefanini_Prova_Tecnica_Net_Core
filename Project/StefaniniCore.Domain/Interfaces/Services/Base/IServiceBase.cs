using System.Collections.Generic;

namespace StefaniniCore.Domain.Interfaces.Services.Base
{
    public interface IServiceBase<T> where T : class
    {
        /// <summary>
        /// Insert the entity on database.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        T Insert(T entity);

        /// <summary>
        /// Update the registers.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        T Update(T entity);

        /// <summary>
        /// Get the entity by Id.
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        T GetById(int entityId);

        /// <summary>
        /// Get all register.
        /// </summary>
        /// <returns></returns>
        IList<T> GetAll();

        /// <summary>
        /// Delete the register by Id.
        /// </summary>
        /// <param name="entityId"></param>
        void DeleteById(int entityId);

        /// <summary>
        /// It will be triggered automatically after the database operations.
        /// </summary>
        void Dispose();
    }
}
