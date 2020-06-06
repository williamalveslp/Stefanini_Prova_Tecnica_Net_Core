using StefaniniCore.Domain.ValueObject;
using System.Collections.Generic;

namespace StefaniniCore.Domain.Entities
{
    public class ProfileType : ValueObjectBase
    {
        public string Name { get; private set; }
        public bool IsActive { get; private set; }

        public virtual ICollection<ProfileTypeTask> ProfileTypeTask { get; set; }
        public virtual ICollection<UserSystem> UserSystem { get; set; }

        private ProfileType() : base() { }

        public ProfileType(string name) : base()
        {
            this.Name = name;
            this.IsActive = true;
            this.ProfileTypeTask = new HashSet<ProfileTypeTask>();
            this.UserSystem = new HashSet<UserSystem>();
        }
    }
}
