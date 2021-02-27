using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StefaniniCore.API.StartupConfigs.ApplicationBuilders;
using StefaniniCore.API.StartupConfigs.ServicesCollection;
using StefaniniCore.API.StartupConfigs.ServicesCollection.SQLServerConnection;
using StefaniniCore.API.StartupConfigs.ServicesCollection.Swagger;
using StefaniniCore.Infra.CrossCutting.IoC;

namespace StefaniniCore.API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.WriteIndented = true;
                });


            // SQLServer DbContext.
            services.AddDbContextSQLServer(Configuration);

            // Dependency Injections.
            services.AddDependencyInjections();

            // Cors.
            services.AddCorsSettings(Configuration);

            // Swagger Documentations.
            services.AddSwagger(Configuration);

            // Health Checks.
            services.AddHealthChecks(Configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            // Cors.
            app.UseCors(Configuration);

            // Are you allowed?  
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHealthChecksUI();
            });

            // Use Swagger.
            app.UseSwagger(Configuration);

            // HealthChecks.
            app.UseHealthChecks(Configuration);
        }
    }
}
