using Microsoft.Extensions.DependencyInjection;
using StefaniniCore.Infra.CrossCutting.Constants;

namespace StefaniniCore.UI.Middlewares
{
    public static class AuthenticationHandler
    {
        public static void AddAuthenticationHandler(this IServiceCollection services)
        {
            string schemeName = "StefaniniCoreAuthentication";

            services.AddAuthentication(schemeName)
                    .AddCookie(schemeName, config =>
                    {
                        config.Cookie.Name = ConstCookies.AuthenticationCookieName;
                        config.LoginPath = "/UserSystems/SignIn";
                    });
        }
    }
}
