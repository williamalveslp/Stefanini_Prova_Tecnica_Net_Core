namespace StefaniniCore.Application.ViewModels
{
    public class TaskDetailViewModel : ViewModelBase
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public void Load(int id, string name, string description)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
        }
    }
}
