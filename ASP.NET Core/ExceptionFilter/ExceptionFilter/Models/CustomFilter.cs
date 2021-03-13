using log4net.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExceptionFilter.Models
{
    public class CustomFilter:IExceptionFilter
    {
         

        public void OnException(ExceptionContext context)
        {
            var result = new ViewResult { ViewName = "CustomException" };
            var modelMetaData = new EmptyModelMetadataProvider();
            result.ViewData = new ViewDataDictionary(modelMetaData, context.ModelState);
            result.ViewData.Add("HandleException", context.Exception);
            context.Result = result;
            context.ExceptionHandled = true;
            LoggerManager loggerManager = new LoggerManager();
            loggerManager.LogInformation("Exception : " + context.Exception.Message);
        }
    }
}

