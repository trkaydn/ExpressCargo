using BusinessLayer.DbLogger;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace ExpressCargo.Middlewares
{
	public class ExceptionMiddleware
	{
		private readonly RequestDelegate _next;

		public ExceptionMiddleware(RequestDelegate next)
		{
			_next = next;
		}

		public async Task Invoke(HttpContext context)
		{
			try
			{
				await _next.Invoke(context);

				if (context.Response.StatusCode >= 400 && context.Response.StatusCode < 500)
				{
					DbLogger.Write(context, null);
					context.Response.Redirect("/Error/Index");
				}

			}
			catch (Exception ex)
			{
				DbLogger.Write(context, ex);
				context.Response.Redirect("/Error/Index");
			}
		}
	}

	public static class ErrorMiddlewareExtensions
	{
		public static IApplicationBuilder UseExceptionMiddleware(this IApplicationBuilder builder)
		{
			return builder.UseMiddleware<ExceptionMiddleware>();
		}
	}
}
