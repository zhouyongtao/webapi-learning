using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace webapi_learning.Filters
{
    public class AsyncLoggingFilter : ActionFilterAttribute
    {
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