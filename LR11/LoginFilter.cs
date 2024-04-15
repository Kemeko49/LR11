using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.IO;

namespace LR11
{
	public class LogActionFilter : ActionFilterAttribute
	{
		public override void OnActionExecuting(ActionExecutingContext context)
		{
			string controllerName = context.ActionDescriptor.DisplayName;
			string actionName = context.ActionDescriptor.DisplayName;

			
			string logMessage = $"Date: {DateTime.Now} |  Action: {actionName} |  Controller: {controllerName}";

			string filePath = "Log.txt";
			File.AppendAllText(filePath, logMessage + Environment.NewLine);

			base.OnActionExecuting(context);
		}
	}
}
