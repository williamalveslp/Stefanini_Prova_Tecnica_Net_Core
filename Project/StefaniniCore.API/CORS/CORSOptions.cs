using Microsoft.Extensions.DependencyInjection;
using StefaniniCore.Infra.CrossCutting.Constants;

namespace StefaniniCore.API.CORS
{
    internal static class CORSOptions
    {
        /// <summary>
        /// Add Policies to CORS to accept requests from another specifics domains.
        /// It's a Access-Control-Allow-Origin.
        /// </summary>
        /// <param name="services"></param>
        public static void CORSConfigurations(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: ConstCORS.Key, builder =>
                                {
                                    builder.WithOrigins(ConstCORS.LocalHost_UI_React);
                                });
            });
        }
    }
}
