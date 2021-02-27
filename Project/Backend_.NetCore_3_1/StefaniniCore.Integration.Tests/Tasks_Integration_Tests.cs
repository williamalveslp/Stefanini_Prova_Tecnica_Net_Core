//using System.Threading.Tasks;
//using Xunit;
//using FluentAssertions;
//using System.Net;
//using StefaniniCore.Application.ViewModels;
//using StefaniniCore.API.Controllers.Base;
//using System.Net.Http;

//namespace StefaniniCore.Integration.Tests
//{
//    /// <summary>
//    /// TODO: It's not working.
//    /// </summary>
//    public class Tasks_Integraton_Tests : IntegrationTest
//    {
//        [Fact]
//        public async Task GetAll()
//        {
//            // Arrange
//            string url = $"{URL_BASE}/Tasks/";

//            // Action
//            var response = await _client.GetAsync(url);

//            // Assert
//            response.StatusCode.Should().Be(HttpStatusCode.OK);
//            (await response.Content.ReadAsAsync<ResponseData<TaskListViewModel>>())
//                                   .Should().NotBeNull();
//        }
//    }
//}
