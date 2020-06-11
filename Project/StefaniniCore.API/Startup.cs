using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using StefaniniCore.DI;
using StefaniniCore.Infra.CrossCutting.Constants;
using System;

namespace StefaniniCore.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddDependencyInjections();

            services.ConfigureSwagger();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            // Activating Swagger middlewares.
            app.UseSwagger();
            app.UseSwaggerUI(options =>
                     options.SwaggerEndpoint("/api/swagger/v1/swagger.json", "William Goi Scheme"));
        }
    }

    internal static class DependencyInjectionSwagger
    {
        public static void ConfigureSwagger(this IServiceCollection services)
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
              });
        }
    }
}
