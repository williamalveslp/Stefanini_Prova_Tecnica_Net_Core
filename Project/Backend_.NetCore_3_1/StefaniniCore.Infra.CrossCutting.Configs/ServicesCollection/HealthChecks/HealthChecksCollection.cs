using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StefaniniCore.Infra.CrossCutting.Configs.DataTransfers;
using System;

namespace StefaniniCore.Infra.CrossCutting.Configs.ServicesCollection
{
    public static class HealthChecksCollection
    {
        public static void AddHealthChecks(this IServiceCollection services, IConfiguration configuration)
        {
            var healthChecksData = ConfigurationTransfer.GetObject<HeathChecksSettings>(configuration);
            var dbContextSQLData = ConfigurationTransfer.GetObject<SQLServerConnectionSettings>(configuration);

            string gcInfo = healthChecksData.ServiceCollection.GCInfo;           
            string urlGroupName = healthChecksData.ServiceCollection.UrlGroup.Name;
            string urlGroup = healthChecksData.ServiceCollection.UrlGroup.Url;

            string connectionString = dbContextSQLData.ConnectionString;
            string databaseName = dbContextSQLData.DatabaseName;

            services.AddHealthChecks()
              .AddGCInfo(gcInfo)
              .AddSQLServerInfo(databaseName, connectionString)   // nuget: Microsoft.Extensions.Diagnostics.HealthChecks.EntityFramework
              .AddUrlGroup(new Uri(urlGroup), name: urlGroupName) // nuget: AspNetCore.HealthChecks.Uris
              .AddApplicationInsightsPublisher();                 // nuget: AspNetCore.HealthChecks.Publisher.ApplicationInsights

            services.AddHealthChecksUI()                          // nuget: AspNetCore.HealthChecks.UI
                .AddInMemoryStorage();                            // nuget: AspNetCore.HealthChecks.UI.InMemory.Storage
        }
    }
}