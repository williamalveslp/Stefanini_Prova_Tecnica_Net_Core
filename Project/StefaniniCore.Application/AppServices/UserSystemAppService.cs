using StefaniniCore.Application.AppInterfaces;
using StefaniniCore.Application.AppServices.Base;
using StefaniniCore.Domain.Interfaces.Services;

namespace StefaniniCore.Application.AppServices
{
    public class UserSystemAppService : BaseAppService, IUserSystemAppService
    {
        private readonly IUserSystemService _userSystemService;

        public UserSystemAppService(IUserSystemService userSystemService)
        {
            _userSystemService = userSystemService;
        }
    }
}
