using StefaniniCore.Domain.Entities;
using System.Collections.Generic;

namespace StefaniniCore.Application.ViewModels.ProfileTypes
{
    public class ProfileTypeListViewModel : ViewModelBase
    {
        public IList<ProfileType> ProfileTypes { get; private set; }

        public int TotalRecords { get; private set; }

        public void Load(IList<ProfileType> profileTypes)
        {
            this.ProfileTypes = profileTypes;
            this.TotalRecords = (profileTypes != null) ? profileTypes.Count : 0;
        }
    }
}
