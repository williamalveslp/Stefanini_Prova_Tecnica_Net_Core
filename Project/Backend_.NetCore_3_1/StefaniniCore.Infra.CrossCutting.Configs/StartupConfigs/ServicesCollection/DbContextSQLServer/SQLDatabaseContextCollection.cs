using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StefaniniCore.Infra.DataStore.SQLServer;
using StefaniniCore.Infra.CrossCutting.Configs.DataTransfers;

namespace StefaniniCore.Infra.CrossCutting.Configs.ServicesCollection
{
    public static class SqlDatabaseContextCollection
    {
        public static void AddDbContextSQLServer(this IServiceCollection services, IConfiguration configuration)
        {
            var sqlServerContextData = ConfigurationTransfer.GetObject<SQLServerConnectionSettings>(configuration);

            string connection = sqlServerContextData.ConnectionString;
            services.AddScoped(_ => new StefDbContext(connection));
        }
    }
}