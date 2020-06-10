using Microsoft.Extensions.DependencyInjection;
using StefaniniCore.Infra.CrossCutting.Constants;

namespace StefaniniCore.UI.Middlewares
{
    public static class AuthenticationHandler
    {
        public static void AddAuthenticationHandler(this IServiceCollection services)
        {
            const string schemeName = ConstAuthentication.SchemeName;

            services.AddAuthentication(schemeName)
                    .AddCookie(schemeName, config =>
                    {
                        config.Cookie.Name = ConstAuthentication.CookieName;
                        config.LoginPath = ConstAuthentication.RedirectionUrl;
                    });
        }
    }
}
