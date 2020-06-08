using StefaniniCore.Domain.Entities;
using System.Collections.Generic;

namespace StefaniniCore.Application.ViewModels.ProfileTypes
{
    public class ProfileTypeDetailViewModel : ViewModelBase
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public IList<Task> Tasks { get; private set; }

        public void Load(int id, string name, IList<Task> tasks)
        {
            this.Id = id;
            this.Name = name;
            this.Tasks = tasks;
        }
    }
}
