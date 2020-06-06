using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Repositories;
using StefaniniCore.Domain.Interfaces.Services;
using StefaniniCore.Services.Services.Base;

namespace StefaniniCore.Services.Services
{
    public class TaskService : ServiceBase<Task>, ITaskService
    {
        private readonly ITaskRepository _repository;

        public TaskService(ITaskRepository repository) : base(repository)
        {
            this._repository = repository;
        }

        public bool Exists(string name)
        {
            return _repository.Exists(name);
        }
    }
}
