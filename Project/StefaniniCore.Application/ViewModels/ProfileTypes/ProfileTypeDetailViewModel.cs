using StefaniniCore.Domain.Entities;
using System.Collections.Generic;

namespace StefaniniCore.Application.ViewModels
{
    public class ProfileTypeDetailViewModel : ViewModelBase
    {
        public virtual int Id { get; private set; }

        public virtual string Name { get; private set; }

        public virtual IList<Task> Tasks { get; private set; }

        public virtual IList<Task> TasksByProfileType { get; private set; }

        public ProfileTypeDetailViewModel()
        {
            this.Tasks = new List<Task>();
            this.TasksByProfileType = new List<Task>();
        }

        public void Load(int id, string name, IList<Task> tasks, IList<Task> tasksByProfileType)
        {
            this.Id = id;
            this.Name = name;
            this.Tasks = tasks;
            this.TasksByProfileType = tasksByProfileType;
        }

        public void UpdateTasks(IList<Task> tasks)
        {
            this.Tasks = tasks;
        }
    }
}
