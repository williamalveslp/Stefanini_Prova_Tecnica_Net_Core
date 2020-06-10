using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

namespace StefaniniCore.UI.Middlewares
{
    public class CustomActionFilterAttribute : ActionFilterAttribute, IExceptionFilter
    {
        /// <summary>
        /// Before the action to perform.
        /// </summary>
        /// <param name="context"></param>
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            string controller = ((ControllerActionDescriptor)((ActionContext)((ControllerBase)context.Controller).ControllerContext).ActionDescriptor).ControllerName;
            string action = ((ControllerActionDescriptor)((ActionContext)((ControllerBase)context.Controller).ControllerContext).ActionDescriptor).ActionName;
            bool isModelStateValid = context.ModelState.IsValid;
            string method = context.HttpContext?.Request?.Method;

            SaveLog(controller, action, isModelStateValid, method);
        }

        /// <summary>
        /// After the action be executed.
        /// </summary>
        /// <param name="context"></param>
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            string controller = ((ControllerActionDescriptor)((ActionContext)((ControllerBase)context.Controller).ControllerContext).ActionDescriptor).ControllerName;
            string action = ((ControllerActionDescriptor)((ActionContext)((ControllerBase)context.Controller).ControllerContext).ActionDescriptor).ActionName;
            bool isModelStateValid = context.ModelState.IsValid;

            SaveLog(controller, action, isModelStateValid);
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            string controller = ((ControllerActionDescriptor)((ActionContext)((ControllerBase)context.Controller).ControllerContext).ActionDescriptor).ControllerName;
            string action = ((ControllerActionDescriptor)((ActionContext)((ControllerBase)context.Controller).ControllerContext).ActionDescriptor).ActionName;
            bool isModelStateValid = context.ModelState.IsValid;

            SaveLog(controller, action, isModelStateValid);
        }

        public override void OnResultExecuted(ResultExecutedContext context)
        {
            string controller = ((ControllerActionDescriptor)((ActionContext)((ControllerBase)context.Controller).ControllerContext).ActionDescriptor).ControllerName;
            string action = ((ControllerActionDescriptor)((ActionContext)((ControllerBase)context.Controller).ControllerContext).ActionDescriptor).ActionName;
            bool isModelStateValid = context.ModelState.IsValid;

            SaveLog(controller, action, isModelStateValid);
        }

        /// <summary>
        /// It's not working.
        /// </summary>
        /// <param name="context"></param>
        public void OnException(ExceptionContext context)
        {
            var controller = string.Empty;
            string action = context?.ActionDescriptor?.DisplayName;
            bool isModelStateValid = context.ModelState.IsValid;

            SaveLog(controller, action, isModelStateValid);
        }

        private async Task SaveLog(string controller, string action, bool isModelStateValid, string method = null)
        {
            // TODO: Implement a log here.
        }
    }
}
