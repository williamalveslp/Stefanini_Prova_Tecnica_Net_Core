using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Services.Base;
using System.Collections.Generic;

namespace StefaniniCore.Domain.Interfaces.Services
{
    public interface ITaskService : IServiceBase<Task>
    {
        /// <summary>
        /// Get the Tasks that are 'Active' only.
        /// </summary>
        /// <returns></returns>
        IList<Task> GetActivesOnly();

        /// <summary>
        /// Check if the same 'Name' field is already stored.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        bool Exists(string name);
    }
}
