//using StefaniniCore.Integration.Tests.Base;
//using System.Net;
//using System.Threading.Tasks;
//using Xunit;

//namespace StefaniniCore.Integration.Tests
//{
//    /// <summary>
//    /// TODO: It's not working.
//    /// </summary>
//    public class Tasks_TestProvider_Tests : TestClientProvider
//    {
//        [Fact]
//        public async Task GetAll()
//        {
//            // Arrange
//            string endpoint = $"{URL_BASE}/Tasks";

//            // Action
//            var response = await _client.GetAsync(endpoint);

//            // Assert
//            response.EnsureSuccessStatusCode();
//            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
//            Assert.NotNull(response.Content);
//        }
//    }
//}
