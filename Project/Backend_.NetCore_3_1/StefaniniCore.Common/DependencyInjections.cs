using Microsoft.Extensions.DependencyInjection;
using StefaniniCore.Application.AppInterfaces;
using StefaniniCore.Application.AppServices;
using StefaniniCore.Domain.Interfaces.Repositories;
using StefaniniCore.Domain.Interfaces.Services;
using StefaniniCore.Infra.DataStore.SQLServer.Repositories;
using StefaniniCore.Services.Services;

namespace StefaniniCore.Common
{
    public static class DependencyInjections
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
            _ = services.AddScoped<IProfileTypeAppService, ProfileTypeAppService>();
        }
        #endregion
    }
}
