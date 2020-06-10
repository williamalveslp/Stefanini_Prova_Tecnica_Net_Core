using StefaniniCore.Application.AppInterfaces;
using StefaniniCore.Application.ViewModels;
using System;
using System.Net;

namespace StefaniniCore.Application.AppServices.Base
{
    public class BaseAppService : IBaseAppService
    {
        public ViewModelBase GetGlobalExceptionViewModel(ViewModelBase viewModel, Exception ex, HttpStatusCode? statusCode = null)
        {
            return viewModel;
        }
    }
}
