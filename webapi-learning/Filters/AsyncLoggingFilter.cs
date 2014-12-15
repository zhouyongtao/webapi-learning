using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace webapi_learning.Filters
{
    public class AsyncLoggingFilter : ActionFilterAttribute
    {
        /*
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var actionDescriptor = filterContext.ActionDescriptor;
            string controllerName = actionDescriptor.ControllerDescriptor.ControllerName;
            string actionName = actionDescriptor.ActionName;
            string userName = filterContext.HttpContext.User.Identity.Name.ToString();
            DateTime timeStamp = filterContext.HttpContext.Timestamp;
            string routeId = string.Empty;
            if (filterContext.RouteData.Values["id"] != null)
            {
                routeId = filterContext.RouteData.Values["id"].ToString();
            }
            var message = new StringBuilder();
            message.Append("UserName=");
            message.Append(userName + "|");
            message.Append("Controller=");
            message.Append(controllerName + "|");
            message.Append("Action=");
            message.Append(actionName + "|");
            message.Append("TimeStamp=");
            message.Append(timeStamp.ToString() + "|");
            if (!string.IsNullOrEmpty(routeId))
            {
                message.Append("RouteId=");
                message.Append(routeId);
            }
            //logger.Log(message.ToString());
            base.OnActionExecuted(filterContext);
        } 
        */

        /*
       	This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, 
        or 'await Task.Run(...)' to do CPU-bound work on a background thread.	
       */


        /// <summary>
        /// 异步记录请求的日志
        /// </summary>
        /// <param name="actionContext"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override async Task OnActionExecutingAsync(HttpActionContext actionContext, CancellationToken cancellationToken)
        {
            /*
            await Trace.WriteAsync("Executing action named {0} for request {1}.",
                        actionContext.ActionDescriptor.ActionName,
                        actionContext.Request.GetCorrelationId());
             */
        }

        /// <summary>
        /// 异步记录返回的日志
        /// </summary>
        /// <param name="actionExecutedContext"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override Task OnActionExecutedAsync(HttpActionExecutedContext actionExecutedContext, CancellationToken cancellationToken)
        {
            return base.OnActionExecutedAsync(actionExecutedContext, cancellationToken);
        }
    }
}