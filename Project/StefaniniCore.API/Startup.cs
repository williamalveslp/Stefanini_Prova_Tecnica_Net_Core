using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using StefaniniCore.API.HealthChecks;
using StefaniniCore.DI;
using StefaniniCore.Infra.CrossCutting.Constants;
using System;
using System.Linq;
using System.Threading.Tasks;

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
            services.AddControllers()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.WriteIndented = true;
                });

            services.AddDependencyInjections();

            services.ConfigureSwagger();

            services.AddHealthChecks().AddGCInfoCheck("GCInfo");
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

            // Activating Swagger middlewares
            app.UseSwagger();
            app.UseSwaggerUI(options =>
                options.SwaggerEndpoint($"/api/swagger/{ConstSwagger.API_Version}/swagger.json", "William Goi Scheme"));

            // Health Checks
            app.UseHealthChecks("/check", new HealthCheckOptions()
            {
                ResponseWriter = WriteResponse,
            });
        }

        /// <summary>
        /// Response from Health Checks.
        /// </summary>
        /// <param name="httpContext"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        private static Task WriteResponse(HttpContext httpContext, HealthReport result)
        {
            httpContext.Response.ContentType = "application/json";
            var json = new JObject(
                new JProperty("status", result.Status.ToString()),
                new JProperty("results", new JObject(result.Entries.Select(pair =>
                new JProperty(pair.Key, new JObject(
                new JProperty("status", pair.Value.Status.ToString()),
                new JProperty("description", pair.Value.Description),
                new JProperty("data", new JObject(pair.Value.Data.Select(p => new JProperty(p.Key, p.Value))))))))));
            return httpContext.Response.WriteAsync(json.ToString(Formatting.Indented));
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
