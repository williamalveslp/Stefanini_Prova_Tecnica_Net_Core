using Microsoft.Extensions.DependencyInjection;
using StefaniniCore.Infra.CrossCutting.Constants;

namespace StefaniniCore.UI.Middlewares
{
    public static class AuthenticationHandler
    {
        public static void AddAuthenticationHandler(this IServiceCollection services)
        {
            services.AddAuthentication(ConstAuthentication.SchemeName)
                    .AddCookie(ConstAuthentication.SchemeName, config =>
                    {
                        config.Cookie.Name = ConstAuthentication.CookieName;
                        config.LoginPath = ConstAuthentication.RedirectionUrl;
                    });
        }
    }
}
