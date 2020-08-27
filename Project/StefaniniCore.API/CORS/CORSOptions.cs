﻿using Microsoft.Extensions.DependencyInjection;
using StefaniniCore.Infra.CrossCutting.Constants;

namespace StefaniniCore.API.CORS
{
    internal static class CorsOptions
    {
        /// <summary>
        /// Add Policies to Cors to accept requests from another specifics domains.
        /// It's a Access-Control-Allow-Origin.
        /// </summary>
        /// <param name="services"></param>
        public static void CorsConfigurations(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: ConstCors.Key, builder =>
                                {
                                    builder.WithOrigins(ConstCors.EndpointToAllow);
                                });
            });
        }
    }
}
