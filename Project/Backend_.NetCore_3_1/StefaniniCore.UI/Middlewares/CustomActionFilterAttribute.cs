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
            var actionDescriptor = ((ControllerActionDescriptor)((ActionContext)((ControllerBase)context.Controller).ControllerContext).ActionDescriptor);

            string controller = actionDescriptor.ControllerName;
            string action = actionDescriptor.ActionName;
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
            var actionDescriptor = ((ControllerActionDescriptor)((ActionContext)((ControllerBase)context.Controller).ControllerContext).ActionDescriptor);

            string controller = actionDescriptor.ControllerName;
            string action = actionDescriptor.ActionName;
            bool isModelStateValid = context.ModelState.IsValid;

            SaveLog(controller, action, isModelStateValid);
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            var actionDescriptor = ((ControllerActionDescriptor)((ActionContext)((ControllerBase)context.Controller).ControllerContext).ActionDescriptor);

            string controller = actionDescriptor.ControllerName;
            string action = actionDescriptor.ActionName;
            bool isModelStateValid = context.ModelState.IsValid;

            SaveLog(controller, action, isModelStateValid);
        }

        public override void OnResultExecuted(ResultExecutedContext context)
        {
            var actionDescriptor = ((ControllerActionDescriptor)((ActionContext)((ControllerBase)context.Controller).ControllerContext).ActionDescriptor);

            string controller = actionDescriptor.ControllerName;
            string action = actionDescriptor.ActionName;
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

        /// <summary>
        /// Save the log.
        /// </summary>
        /// <param name="controller"></param>
        /// <param name="action"></param>
        /// <param name="isModelStateValid"></param>
        /// <param name="method"></param>
        /// <returns></returns>
        private void SaveLog(string controller, string action, bool isModelStateValid, string method = null)
        {
            // TODO: Implement a log here.
        }
    }
}
