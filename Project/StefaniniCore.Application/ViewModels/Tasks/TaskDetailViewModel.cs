namespace StefaniniCore.Application.ViewModels
{
    public class TaskDetailViewModel : ViewModelBase
    {
        public virtual int Id { get; private set; }

        public virtual string Name { get; private set; }

        public virtual string Description { get; private set; }

        public void Load(int id, string name, string description)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
        }
    }
}
