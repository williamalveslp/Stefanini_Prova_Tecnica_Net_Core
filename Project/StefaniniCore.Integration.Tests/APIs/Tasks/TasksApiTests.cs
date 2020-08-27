//using Microsoft.AspNetCore.Authorization.Infrastructure;
//using StefaniniCore.Integration.Tests.Brokers;
//using System.Threading.Tasks;
//using Xunit;

//namespace StefaniniCore.Integration.Tests.APIs.Tasks
//{
//    /// <summary>
//    /// TODO: It's not working.
//    /// </summary>
//    [Collection(nameof(ApiTestCollection))]
//    public class TasksApiTests
//    {
//        private readonly IntegrationBroker _broker;

//        public TasksApiTests(IntegrationBroker broker)
//        {
//            _broker = broker;
//        }

//        [Fact]
//        public async Task GetById()
//        {
//            // FALSE POSITIVE
//            var response = this._broker.GetTaskByIdAsync(2);

//            Assert.NotNull(response);
//        }

//        [Fact]
//        public async Task GetAll()
//        {
//            // FALSE POSITIVE
//            var response = this._broker.GetAllTaksAsync();

//            Assert.NotNull(response);
//        }
//    }
//}
