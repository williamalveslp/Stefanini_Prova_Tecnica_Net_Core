using StefaniniCore.Domain.Entities;
using StefaniniCore.Domain.Interfaces.Services.Base;

namespace StefaniniCore.Domain.Interfaces.Services
{
    public interface IUserSystemService : IServiceBase<UserSystem>
    {
        UserSystem GetSignIn(string userName, string password);
    }
}
