using StefaniniCore.API.Controllers.Base;
using StefaniniCore.Application.InputModels.Tasks;
using StefaniniCore.Application.ViewModels;
using System.Threading.Tasks;

namespace StefaniniCore.Integration.Tests.Brokers
{
    public partial class IntegrationBroker
    {
        private const string TasksUrl = "api/Tasks";

        //public async ValueTask<ResponseData<TaskDetailViewModel>> PostTaskAsync(TaskInputModel inputModel)
        //{
        //    var response = await this._apiFactoryClient.PostContentAsync(TasksUrl, inputModel);
        //    // convert to json to return.
        //    return response;
        //}
       
        public async ValueTask<Domain.Entities.Task> GetTaskByIdAsync(int id) =>
            await this._apiFactoryClient.GetContentAsync<Domain.Entities.Task>($"{TasksUrl}/{id}");
       
        public async ValueTask<ResponseData<TaskListViewModel>> GetAllTaksAsync() =>
            await this._apiFactoryClient.GetContentAsync<ResponseData<TaskListViewModel>>($"{TasksUrl}");
    }
}
