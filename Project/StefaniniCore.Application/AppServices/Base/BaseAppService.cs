using StefaniniCore.Application.AppInterfaces;
using StefaniniCore.Application.ViewModels.Base;
using System;
using System.Net;

namespace StefaniniCore.Application.AppServices.Base
{
    public class BaseAppService : IBaseAppService
    {
        public ViewModelBase GetGlobalExceptionViewModel(ViewModelBase viewModel, Exception ex, HttpStatusCode? statusCode = null)
        {
            //TODO: Add error handler.
            // LogsRecord.SaveException(ex, EnumLogsRecord.EXCEPTION);
            viewModel.StackTrace = ex.StackTrace;
            viewModel.MessageError = ex.Message;

            return viewModel;
        }
    }
}
