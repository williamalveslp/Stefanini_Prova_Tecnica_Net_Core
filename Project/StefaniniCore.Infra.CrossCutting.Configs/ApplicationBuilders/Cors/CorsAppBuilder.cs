using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using StefaniniCore.Infra.CrossCutting.Configs.DataTransfers;

namespace StefaniniCore.Infra.CrossCutting.Configs.ApplicationBuilders
{
    public static class CorsAppBuilder
    {
        public static void UseCors(this IApplicationBuilder app, IConfiguration configuration)
        {
            var corsAppBuilderData = ConfigurationTransfer.GetObject<CorsSettings>(configuration);
            app.UseCors(corsAppBuilderData.Key);
        }
    }
}