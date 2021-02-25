using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using StefaniniCore.Infra.CrossCutting.Constants;
using System;
using System.IO;
using System.Reflection;

namespace StefaniniCore.API.ServicesCollection.Swagger
{
    internal static class SwaggerCollection
    {
        public static void AddSwagger(this IServiceCollection services)
        {
            _ = services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(ConstSwagger.API_Version,
                    new OpenApiInfo
                    {
                        Title = ConstSwagger.Title,
                        Version = ConstSwagger.API_Version,
                        Description = ConstSwagger.Description,
                        Contact = new OpenApiContact
                        {
                            Name = ConstSwagger.Contact_Name,
                            Email = ConstSwagger.Contact_Email,
                            Url = new Uri(ConstSwagger.Contact_Url)
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
