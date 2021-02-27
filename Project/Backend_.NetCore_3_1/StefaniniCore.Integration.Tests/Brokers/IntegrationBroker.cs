using Microsoft.AspNetCore.Mvc.Testing;
using RESTFulSense.Clients;
using StefaniniCore.API;
using System.Net.Http;

namespace StefaniniCore.Integration.Tests.Brokers
{
    public partial class IntegrationBroker
    {
        private readonly WebApplicationFactory<Startup> _factory;
        private readonly HttpClient _client;
        private readonly IRESTFulApiFactoryClient _apiFactoryClient;

        public IntegrationBroker()
        {
            this._factory = new WebApplicationFactory<Startup>();
            this._client = this._factory.CreateClient();
            this._apiFactoryClient = new RESTFulApiFactoryClient(this._client);
        }
    }
}
