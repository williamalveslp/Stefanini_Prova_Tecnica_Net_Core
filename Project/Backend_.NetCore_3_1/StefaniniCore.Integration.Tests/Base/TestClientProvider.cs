using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using StefaniniCore.API;
using System.Net.Http;

namespace StefaniniCore.Integration.Tests.Base
{
    public abstract class TestClientProvider
    {
        protected const string URL_BASE = "http://localhost:55612/api";
        protected readonly HttpClient _client;

        protected TestClientProvider()
        {
            var server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            _client = server.CreateClient();
        }
    }
}
