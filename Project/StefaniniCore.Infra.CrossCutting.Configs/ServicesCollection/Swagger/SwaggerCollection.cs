using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.IO;
using System.Reflection;
using StefaniniCore.Infra.CrossCutting.Configs.DataTransfers;

namespace StefaniniCore.Infra.CrossCutting.Configs.ServicesCollection
{
    public static class SwaggerCollection
    {
        public static void AddSwagger(this IServiceCollection services, IConfiguration configuration)
        {
            var swaggerData = ConfigurationTransfer.GetObject<SwaggerSettings>(configuration);

            _ = services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(swaggerData.ServiceCollection.Version,
                    new OpenApiInfo
                    {
                        Title = swaggerData.ServiceCollection.Title,
                        Version = swaggerData.ServiceCollection.Version,
                        Description = swaggerData.ServiceCollection.Description,
                        Contact = new OpenApiContact
                        {
                            Name = swaggerData.ServiceCollection.Contact?.Name,
                            Email = swaggerData.ServiceCollection.Contact?.Email,
                            Url = new Uri(swaggerData.ServiceCollection.Contact?.Url)
                        }
                    });

                // Set the comments path for the Swagger JSON and UI (Properties > Build > set 'XML documentation file').
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
        }
    }
}