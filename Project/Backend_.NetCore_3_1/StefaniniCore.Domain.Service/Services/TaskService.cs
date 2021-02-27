using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Repositories;
using StefaniniCore.Domain.Interfaces.Services;
using StefaniniCore.Domain.Services.Services.Base;
using System.Collections.Generic;
using System.Linq;

namespace StefaniniCore.Domain.Services.Services
{
    public class TaskService : ServiceBase<Task>, ITaskService
    {
        private readonly ITaskRepository _repository;

        public TaskService(ITaskRepository repository) : base(repository)
        {
            this._repository = repository;
        }

        public bool Exists(string name)=> _repository.Exists(name);

        public IList<Task> GetActivesOnly() =>
                _repository.GetsActivesOnly();
    }
}
