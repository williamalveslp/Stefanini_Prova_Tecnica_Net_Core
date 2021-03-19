using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using StefaniniCore.Infra.CrossCutting.Configs.DataTransfers;

namespace StefaniniCore.Infra.CrossCutting.Configs.ApplicationBuilders
{
    public static class SwaggerAppBuilder
    {
        public static void UseSwagger(this IApplicationBuilder app, IConfiguration configuration)
        {
            var swaggerData = ConfigurationTransfer.GetObject<SwaggerSettings>(configuration);

            string name = swaggerData.ServiceCollection.Title;
            string version = swaggerData.ServiceCollection.Version;

            string url = swaggerData.AppBuilder.UrlSwagger;
            url = string.Format(url, version);

            app.UseSwagger();
            app.UseSwaggerUI(options =>
            options.SwaggerEndpoint(url, name));
        }
    }
}