using StefaniniCore.Domain.Entities;
using System.Collections.Generic;

namespace StefaniniCore.Application.ViewModels
{
    public class ProfileTypeDetailViewModel : ViewModelBase
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual IList<Task> Tasks { get; set; }

        public virtual IList<Task> TasksByProfileType { get; set; }

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
