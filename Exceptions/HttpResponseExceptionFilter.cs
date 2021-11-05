﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace amir_apparel_demo_api_dotnet_5.Exceptions
{
    public class HttpResponseExceptionFilter : IActionFilter, IOrderedFilter
    {
        public int Order { get; } = int.MaxValue - 10;
        public void OnActionExecuting(ActionExecutingContext context) { }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Exception is IHttpResponseException exception)
            {
                context.Result = new ObjectResult(exception.ObjectData)
                {
                    StatusCode = exception.Status
                };
                context.ExceptionHandled = true;
            }
        }

    }
}