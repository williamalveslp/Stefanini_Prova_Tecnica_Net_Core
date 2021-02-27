using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using StefaniniCore.API.StartupConfigs.DataTransfers;
using StefaniniCore.Infra.CrossCutting;

namespace StefaniniCore.API.StartupConfigs.ApplicationBuilders
{
    internal static class CorsAppBuilder
    {
        public static void UseCors(this IApplicationBuilder app, IConfiguration configuration)
        {
            var corsAppBuilderData = ConfigurationTransfer.GetObject<CorsSettings>(configuration);
            app.UseCors(corsAppBuilderData.Key);
        }
    }
}
