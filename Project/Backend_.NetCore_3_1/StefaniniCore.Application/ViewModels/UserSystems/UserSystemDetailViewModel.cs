using StefaniniCore.Domain.Entities;
using System.Collections.Generic;

namespace StefaniniCore.Application.ViewModels
{
    public class UserSystemDetailViewModel : ViewModelBase
    {
        public virtual int Id { get; set; }

        public virtual string UserName { get; set; }

        public virtual string Password { get; set; }

        public virtual int ProfileTypeId { get; set; }

        public virtual IList<ProfileType> ProfileTypes { get; set; }

        public UserSystemDetailViewModel()
        {
            this.ProfileTypes = new List<ProfileType>();
        }

        public void Load(int id, string userName, string password, int profileTypeId, IList<ProfileType> profileTypes)
        {
            this.Id = id;
            this.UserName = userName;
            this.Password = password;
            this.ProfileTypeId = profileTypeId;
            this.ProfileTypes = profileTypes;
        }

        public void UpdateProfileTypes(IList<ProfileType> profileTypes)
        {
            this.ProfileTypes = profileTypes;
        }
    }
}
