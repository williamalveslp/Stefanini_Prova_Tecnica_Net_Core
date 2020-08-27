using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using StefaniniCore.API;
using StefaniniCore.Infra.DataStore.SQLServer;
using System.Net.Http;

namespace StefaniniCore.Integration.Tests
{
    public abstract class IntegrationTest
    {
        protected const string URL_BASE = "http://localhost:55612/api";
        protected readonly HttpClient _client;

        /// <summary>
        /// Create the Client Factory intance and set the database in memory.
        /// </summary>
        protected IntegrationTest()
        {
            var appFactory = new WebApplicationFactory<Startup>()
                .WithWebHostBuilder(builder =>
                {
                    builder.ConfigureServices(services =>
                    {
                        services.RemoveAll(typeof(StefDbContext));
                        services.AddDbContext<StefDbContext>(options =>
                        {
                            options.UseInMemoryDatabase("TestDb");
                        });
                    });
                });

            _client = appFactory.CreateClient();
        }
    }
}
