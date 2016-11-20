using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using Newtonsoft.Json;

namespace qwertyuiop.Filters
{
    public class LoggingFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            string methodName = actionContext.ActionDescriptor.ActionName;
            var arguments = actionContext.ActionArguments;
            var serializedArguments = JsonConvert.SerializeObject(arguments);      
            string log = string.Format("Method {0} started at {1} with arguments {2}", methodName, DateTime.Now, serializedArguments);
            File.AppendAllText("log.txt", log);
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            string log = string.Format("Method {0} finished at {1} with status code {2}", actionExecutedContext.ActionContext.ActionDescriptor.ActionName,
                DateTime.Now,
                actionExecutedContext.ActionContext.Response.StatusCode.ToString());
            File.AppendAllText("log.txt", log);
        }
    }
}