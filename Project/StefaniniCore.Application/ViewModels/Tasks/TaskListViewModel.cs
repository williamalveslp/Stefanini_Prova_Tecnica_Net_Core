using StefaniniCore.Domain.Entities;
using System.Collections.Generic;

namespace StefaniniCore.Application.ViewModels
{
    public class TaskListViewModel : ViewModelBase
    {
        public virtual IList<Task> Tasks { get; private set; }

        public virtual int TotalRecords { get; private set; }

        public void Load(IList<Task> tasks)
        {
            this.Tasks = tasks;
            this.TotalRecords = (tasks != null) ? tasks.Count : 0;
        }
    }
}
