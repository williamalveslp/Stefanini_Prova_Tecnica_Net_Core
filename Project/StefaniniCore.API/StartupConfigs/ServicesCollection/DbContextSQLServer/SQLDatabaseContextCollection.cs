using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StefaniniCore.Infra.CrossCutting;
using StefaniniCore.Infra.DataStore.SQLServer;
using StefaniniCore.API.StartupConfigs.DataTransfers;

namespace StefaniniCore.API.StartupConfigs.ServicesCollection.SQLServerConnection
{
    internal static class SQLDatabaseContextCollection
    {
        public static void AddDbContextSQLServer(this IServiceCollection services, IConfiguration configuration)
        {
            var sqlServerContextData = ConfigurationTransfer.GetObject<SQLServerConnectionSettings>(configuration);

            string connection = sqlServerContextData.ConnectionString;
            services.AddScoped(_ => new StefDbContext(connection));
        }
    }
}
