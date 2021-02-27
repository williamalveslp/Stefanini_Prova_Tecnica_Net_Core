using Microsoft.AspNetCore.Mvc.Testing;
using StefaniniCore.API;
using System.Threading.Tasks;
using Xunit;

namespace StefaniniCore.Integration.Tests.Base
{
    public abstract class Fixture : IClassFixture<WebApplicationFactory<Startup>>
    {
        public readonly WebApplicationFactory<Startup> _factory;

        protected Fixture(WebApplicationFactory<Startup> factory)
        {   
            _factory = factory;
        }

        [Fact]
        public async Task GetAllTasks()
        {
            var client = _factory.CreateClient();

            var URL_BASE = "http://localhost:55612/api";

            var response = await client.GetAsync($"{URL_BASE}/Tasks");

            response.EnsureSuccessStatusCode();
            Assert.NotNull(response.Content);
        }
    }
}
