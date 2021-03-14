using StefaniniCore.Domain.Entities;
using System.Collections.Generic;

namespace StefaniniCore.Application.ViewModels
{
    public class ProfileTypeListViewModel : ViewModelBase
    {
        public virtual IList<ProfileType> ProfileTypes { get; set; }

        public virtual int TotalRecords { get; set; }

        public void Load(IList<ProfileType> profileTypes)
        {
            this.ProfileTypes = profileTypes;
            this.TotalRecords = (profileTypes != null) ? profileTypes.Count : 0;
        }
    }
}
