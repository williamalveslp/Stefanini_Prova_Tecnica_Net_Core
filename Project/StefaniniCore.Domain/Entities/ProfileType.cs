using StefaniniCore.Domain.ValueObject;
using System.Collections.Generic;

namespace StefaniniCore.Domain.Entities
{
    public class ProfileType : ValueObjectBase
    {
        public string Name { get; private set; }
        public bool IsActive { get; private set; }

        public virtual IList<ProfileTypeTask> ProfileTypeTask { get; set; }
        public virtual IList<UserSystem> UserSystem { get; set; }

        private ProfileType() : base() { }

        public ProfileType(string name) : base()
        {
            this.Name = name;
            this.IsActive = true;
            this.ProfileTypeTask = new List<ProfileTypeTask>();
            this.UserSystem = new List<UserSystem>();
        }
    }
}
