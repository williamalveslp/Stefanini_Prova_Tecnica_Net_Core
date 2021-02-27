using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StefaniniCore.API.StartupConfigs.DataTransfers;
using StefaniniCore.Infra.CrossCutting;

namespace StefaniniCore.API.StartupConfigs.ServicesCollection
{
    internal static class CorsCollection
    {
        /// <summary>
        /// Add Policies to Cors to accept requests from another specifics domains.
        /// It's a Access-Control-Allow-Origin.
        /// </summary>
        /// <param name="services"></param>
        public static void AddCorsSettings(this IServiceCollection services, IConfiguration configuration)
        {
            var corsData = ConfigurationTransfer.GetObject<CorsSettings>(configuration);

            services.AddCors(options =>
            {
                options.AddPolicy(name: corsData.Key, builder =>
                {
                    builder.WithOrigins(corsData.OriginUrlsAllowed);
                });
            });
        }
    }
}
