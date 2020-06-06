using StefaniniCore.Domain.ValueObject;
using System.Collections.Generic;

namespace StefaniniCore.Domain.Entities
{
    public class Task : ValueObjectBase
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public bool IsActive { get; private set; }

        public virtual ICollection<ProfileTypeTask> ProfileTypeTask { get; set; }

        private Task() { }

        public Task(string name, string description) : base()
        {
            this.Name = name;
            this.Description = description;
            this.ProfileTypeTask = new HashSet<ProfileTypeTask>();
        }
    }
}
