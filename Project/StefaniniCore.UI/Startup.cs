using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StefaniniCore.Application.AppInterfaces;
using StefaniniCore.Application.AppServices;
using StefaniniCore.Domain.Interfaces.Repositories;
using StefaniniCore.Domain.Interfaces.Services;
using StefaniniCore.Infra.DataStore.SQLServer.Repositories;
using StefaniniCore.Services.Services;

namespace StefaniniCore.UI
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
            services.AddControllersWithViews();

            services.AddDependencyInjections();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }

    public static class DependecyInjections
    {
        public static void AddDependencyInjections(this IServiceCollection services)
        {
            AddScopedRepositories(services);
            AddScopedServices(services);
            AddScopedAppServices(services);
        }

        #region .: PRIVATE METHODS :.
        private static void AddScopedRepositories(IServiceCollection services)
        {
            _ = services.AddScoped<IProfileTypeRepository, ProfileTypeRepository>();
            _ = services.AddScoped<IProfileTypeTaskRepository, ProfileTypeTaskRepository>();
            _ = services.AddScoped<ITaskRepository, TaskRepository>();
            _ = services.AddScoped<IUserSystemRepository, UserSystemRepository>();
        }

        private static void AddScopedServices(IServiceCollection services)
        {
            _ = services.AddScoped<IProfileTypeService, ProfileTypeService>();
            _ = services.AddScoped<IProfileTypeTaskService, ProfileTypeTaskService>();
            _ = services.AddScoped<ITaskService, TaskService>();
            _ = services.AddScoped<IUserSystemService, UserSystemService>();
        }

        private static void AddScopedAppServices(IServiceCollection services)
        {
            _ = services.AddScoped<ITaskAppService, TaskAppService>();
            _ = services.AddScoped<IUserSystemAppService, UserSystemAppService>();
        }
        #endregion
    }
}
