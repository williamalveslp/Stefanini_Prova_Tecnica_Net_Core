using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StefaniniCore.API.StartupConfigs.DataTransfers;
using StefaniniCore.Infra.CrossCutting;
using System;

namespace StefaniniCore.API.StartupConfigs.ServicesCollection
{
    internal static class HealthChecksCollection
    {
        public static void AddHealthChecks(this IServiceCollection services, IConfiguration configuration)
        {
            var healthChecksData = ConfigurationTransfer.GetObject<HeathChecksSettings>(configuration);

            string gcInfo = healthChecksData.ServiceCollection.GCInfo;
            string connectionString = healthChecksData.ServiceCollection.SQLServer.ConnectionString;
            string databaseName = healthChecksData.ServiceCollection.SQLServer.DatabaseName;
            string urlGroupName = healthChecksData.ServiceCollection.UrlGroup.Name;
            string urlGroup = healthChecksData.ServiceCollection.UrlGroup.Url;

            services.AddHealthChecks()
              .AddGCInfo(gcInfo)
              .AddSQLServerInfo(databaseName, connectionString)   // nuget: Microsoft.Extensions.Diagnostics.HealthChecks.EntityFramework
              .AddUrlGroup(new Uri(urlGroup), name: urlGroupName) // nuget: AspNetCore.HealthChecks.Uris
              .AddApplicationInsightsPublisher();                 // nuget: AspNetCore.HealthChecks.Publisher.ApplicationInsights

            services.AddHealthChecksUI()
                .AddInMemoryStorage();
        }
    }
}
