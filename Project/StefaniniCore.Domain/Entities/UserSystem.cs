using StefaniniCore.Domain.ValueObject;

namespace StefaniniCore.Domain.Entities
{
    public class UserSystem : ValueObjectBase
    {
        public string UserName { get; private set; }
        public string Password { get; private set; }
        public int ProfileTypeId { get; private set; }
        public bool IsActive { get; private set; }

        public virtual ProfileType ProfileType { get; set; }

        private UserSystem() : base() { }

        public UserSystem(string userName, string password, int profileTypeId) : base()
        {
            this.UserName = userName;
            this.Password = password;
            this.ProfileTypeId = profileTypeId;
            this.IsActive = true;
        }

        public void Update(string userName, string password, int profileTypeId)
        {
            this.UserName = userName;
            this.Password = password;
            this.ProfileTypeId = profileTypeId;
            RefreshDateUpdated();
        }
    }
}
