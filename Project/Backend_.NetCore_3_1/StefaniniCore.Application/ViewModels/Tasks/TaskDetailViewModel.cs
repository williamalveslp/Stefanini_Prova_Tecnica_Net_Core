using StefaniniCore.Domain.Entities;

namespace StefaniniCore.Application.ViewModels
{
    public class TaskDetailViewModel : ViewModelBase
    {
        public virtual Task Task { get; set; }

        public void Load(Task task)
        {
            this.Task = task;
        }
    }
}
