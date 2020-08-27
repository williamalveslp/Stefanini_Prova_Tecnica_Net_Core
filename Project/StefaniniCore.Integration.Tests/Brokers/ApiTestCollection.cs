using Xunit;

namespace StefaniniCore.Integration.Tests.Brokers
{
    /// <summary>
    /// Broker instantiator.
    /// </summary>
    [CollectionDefinition(nameof(ApiTestCollection))]
    public class ApiTestCollection : ICollectionFixture<IntegrationBroker>
    {
    }
}
